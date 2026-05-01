using CarRentalSystem.Core;
using CarRentalSystem.Data;
using CarRentalSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarRentalSystem.Forms
{
    public partial class account_information : Form
    {
        // session's current user.
        private Customer current_customer;


        public account_information(Customer customer)
        {
            InitializeComponent();
            current_customer = customer;

            // time to load a ton of data
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.PhoneNumber;
            txtSsn.Text = customer.Ssn;
            txtUsername.Text = customer.Username;

            // Full name display in avatar panel 
            label3.Text = customer.FirstName + " " + customer.LastName;

            // Initials on the avatar 
            string firstInitial = "";
            string lastInitial = "";

            if (customer.FirstName.Length > 0)
                firstInitial = customer.FirstName[0].ToString().ToUpper();

            if (customer.LastName.Length > 0)
                lastInitial = customer.LastName[0].ToString().ToUpper();

            label4.Text = firstInitial + lastInitial;
            label6.Text = firstInitial + lastInitial;

            // Customer ID 
            label5.Text = "#" + customer.Id.ToString();

            // License 
            txtLicenseNum.Text = customer.LicenseNum;

            // Expiry date coloring 
            if (customer.ExpirationDate < DateTime.Now)
            {
                lblExpiry.Text = "✕  " + customer.ExpirationDate.ToString("MMM dd, yyyy") + " — Expired";
                lblExpiry.BackColor = Color.FromArgb(253, 246, 246);
                lblExpiry.ForeColor = Color.FromArgb(170, 51, 51);
            }
            else
            {
                lblExpiry.Text = "✓  " + customer.ExpirationDate.ToString("MMM dd, yyyy") + " — Valid";
                lblExpiry.BackColor = Color.FromArgb(234, 246, 238);
                lblExpiry.ForeColor = Color.FromArgb(42, 122, 69);
            }

            // Activity stats 
            int totalRentals = 0;
            int totalReservations = 0;
            int activeRentals = 0;

            if (customer.Rentals != null)
            {
                totalRentals = customer.Rentals.Count;

                foreach (var rental in customer.Rentals)
                {
                    if (rental.PlannedReturn == null || rental.PlannedReturn > DateTime.Now)
                        activeRentals++;
                }
            }

            if (customer.Reservations != null)
                totalReservations = customer.Reservations.Count;

            lblStatRentalsNum.Text = totalRentals.ToString();
            lblStatReservationsNum.Text = totalReservations.ToString();
            lblStatActiveNum.Text = activeRentals.ToString();
        }

        private void account_information_Load(object sender, EventArgs e)
        {

        }

        private void lblUsernameTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            change_password changepswrd = new change_password(current_customer);
            changepswrd.Show();
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            // Loading all fields.
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();

            // if any fields are empty, display the needed message.
            if (string.IsNullOrWhiteSpace(firstName) ||
                string.IsNullOrWhiteSpace(lastName) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // validation using regex.
            if (!Regex.IsMatch(firstName, ValidationHelp.NameRegex))
            {
                MessageBox.Show("First name must be 2–50 letters only.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(lastName, ValidationHelp.NameRegex))
            {
                MessageBox.Show("Last name must be 2–50 letters only.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(email, ValidationHelp.EmailRegex))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(phone, ValidationHelp.PhoneRegex))
            {
                MessageBox.Show("Phone must be 10–15 digits, optionally starting with +.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // verification time. 
            current_customer.FirstName = firstName;
            current_customer.LastName = lastName;
            current_customer.Email = email;
            current_customer.PhoneNumber = phone;

            using (var db = new AppDbContext())
            {
                db.Customers.Update(current_customer);
                db.SaveChanges();
            }

            // ── Refresh display ─────────────────────────────────────
            label3.Text = $"{current_customer.FirstName} {current_customer.LastName}";

            MessageBox.Show("Details updated successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
