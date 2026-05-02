using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CarRentalSystem.Core;      // UserSession
using CarRentalSystem.DTOs;      // CustomerProfileDTO
using CarRentalSystem.Services;  // CustomerService

namespace CarRentalSystem.Forms
{
    public partial class Account_Information : Form
    {
        private CustomerProfileDTO _profile;
        private CustomerService _customerService;
        private bool _isEditing = false; // Tracks the toggle state of the button

        public Account_Information()
        {
            InitializeComponent();
            _customerService = new CustomerService();
            LoadProfileData();
        }

        private void LoadProfileData()
        {
            // Get the ID from the global session
            int currentUserId = UserSession.CurrentUser.Id;

            _profile = _customerService.GetProfile(currentUserId);

            if (_profile == null)
            {
                MessageBox.Show("Error loading profile data.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            txtFirstName.Text = _profile.FirstName;
            txtLastName.Text = _profile.LastName;
            txtEmail.Text = _profile.Email;
            txtPhone.Text = _profile.PhoneNumber;
            txtSsn.Text = _profile.Ssn;
            txtUsername.Text = _profile.Username;
            txtLicenseNum.Text = _profile.LicenseNum;

            label3.Text = $"{_profile.FirstName} {_profile.LastName}";
            label5.Text = $"#{_profile.Id}";

            string initials = $"{(_profile.FirstName.Length > 0 ? _profile.FirstName[0] : ' ')}{(_profile.LastName.Length > 0 ? _profile.LastName[0] : ' ')}".ToUpper();
            label4.Text = initials;
            label6.Text = initials;

            if (_profile.ExpirationDate < DateTime.Now)
            {
                lblExpiry.Text = $"✕  {_profile.ExpirationDate:MMM dd, yyyy} — Expired";
                lblExpiry.BackColor = Color.FromArgb(253, 246, 246);
                lblExpiry.ForeColor = Color.FromArgb(170, 51, 51);
            }
            else
            {
                lblExpiry.Text = $"✓  {_profile.ExpirationDate:MMM dd, yyyy} — Valid";
                lblExpiry.BackColor = Color.FromArgb(234, 246, 238);
                lblExpiry.ForeColor = Color.FromArgb(42, 122, 69);
            }

            lblStatRentalsNum.Text = _profile.TotalRentals.ToString();
            lblStatReservationsNum.Text = _profile.ActiveReservations.ToString();
            lblStatActiveNum.Text = _profile.CurrentlyRenting.ToString();

            LockTextBoxes();
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            if (!_isEditing)
            {
                UnlockTextBoxes();
                _isEditing = true;
                btnEditDetails.Text = "Save Details";
                btnEditDetails.BackColor = Color.SeaGreen;
            }
            else
            {
                string first = txtFirstName.Text.Trim();
                string last = txtLastName.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phone = txtPhone.Text.Trim();

                if (string.IsNullOrWhiteSpace(first) || string.IsNullOrWhiteSpace(last) ||
                    string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone))
                {
                    MessageBox.Show("Please fill in all editable fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(first, ValidationHelp.NameRegex) || !Regex.IsMatch(last, ValidationHelp.NameRegex))
                {
                    MessageBox.Show("Names must be 2–50 letters only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(email, ValidationHelp.EmailRegex))
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!Regex.IsMatch(phone, ValidationHelp.PhoneRegex))
                {
                    MessageBox.Show("Phone must be 10–15 digits, optionally starting with +.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool success = _customerService.UpdateContactInfo(_profile.Id, first, last, email, phone);

                if (success)
                {
                    UserSession.CurrentUser.FullName = $"{first} {last}";
                    MessageBox.Show("Details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _isEditing = false;
                    btnEditDetails.Text = "Edit Details";
                    btnEditDetails.BackColor = Color.FromArgb(34, 34, 34);

                    LoadProfileData();
                }
                else
                {
                    MessageBox.Show("Failed to save. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UnlockTextBoxes()
        {
            txtFirstName.ReadOnly = false; txtFirstName.BackColor = Color.White;
            txtLastName.ReadOnly = false; txtLastName.BackColor = Color.White;
            txtEmail.ReadOnly = false; txtEmail.BackColor = Color.White;
            txtPhone.ReadOnly = false; txtPhone.BackColor = Color.White;
        }

        private void LockTextBoxes()
        {
            txtFirstName.ReadOnly = true; txtFirstName.BackColor = Color.FromArgb(250, 250, 250);
            txtLastName.ReadOnly = true; txtLastName.BackColor = Color.FromArgb(250, 250, 250);
            txtEmail.ReadOnly = true; txtEmail.BackColor = Color.FromArgb(250, 250, 250);
            txtPhone.ReadOnly = true; txtPhone.BackColor = Color.FromArgb(250, 250, 250);
        }

        private void btnEditPassword_Click(object sender, EventArgs e)
        {
            var changePasswordForm = new change_password();
            changePasswordForm.ShowDialog(); // Use Dialog so they can't click away!
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Go back to the Customer Dashboard safely
            var dashboard = new Customer_Dashboard();
            dashboard.Location = this.Location;
            dashboard.StartPosition = FormStartPosition.Manual;
            dashboard.Show();
            this.Hide();
        }

        private void Account_Information_Load(object sender, EventArgs e) { }
        private void lblUsernameTitle_Click(object sender, EventArgs e) { }
        private void txtFirstName_TextChanged(object sender, EventArgs e) { }
    }
}