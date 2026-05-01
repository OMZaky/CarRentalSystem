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
    public partial class change_password : Form
    {
        Customer current_customer;
        public change_password(Customer current_customer)
        {
            InitializeComponent();
            this.current_customer = current_customer;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string currPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confPassword = txtConfirmPassword.Text;

            // Empty checks 
            if (string.IsNullOrWhiteSpace(currPassword) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confPassword))
            {
                lblError.Text = "Please fill in all fields.";
                lblError.Visible = true;
                return;
            }

            // Verify current password 
            string hashedCurrent = PasswordHasher.HashPassword(currPassword);
            if (hashedCurrent != current_customer.PasswordHash)
            {
                lblError.Text = "Current password is incorrect.";
                lblError.Visible = true;
                txtCurrentPassword.Clear();
                txtCurrentPassword.Focus();
                return;
            }

            // New password must differ from current 
            if (newPassword == currPassword)
            {
                lblError.Text = "New password must be different from your current password.";
                lblError.Visible = true;
                txtNewPassword.Clear();
                txtNewPassword.Focus();
                return;
            }

            // Regex validation 
            if (!Regex.IsMatch(newPassword, ValidationHelp.PassRegex))
            {
                lblError.Text = "Password must be at least 8 characters with uppercase, lowercase and a number.";
                lblError.Visible = true;
                txtNewPassword.Clear();
                txtConfirmPassword.Clear();
                txtNewPassword.Focus();
                return;
            }

            // Confirm password match 
            if (newPassword != confPassword)
            {
                lblError.Text = "Passwords do not match.";
                lblError.Visible = true;
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            // Save 
            current_customer.PasswordHash = PasswordHasher.HashPassword(newPassword);

            using (var db = new AppDbContext())
            {
                db.Customers.Update(current_customer);
                db.SaveChanges();
            }

            lblError.Visible = false;
            MessageBox.Show("Password changed successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();

        }
    }
}
