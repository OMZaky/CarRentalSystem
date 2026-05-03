using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using CarRentalSystem.Core;       // For UserSession
using CarRentalSystem.Services;   // For CustomerService and AuthService

namespace CarRentalSystem.Forms
{
    public partial class Change_Password : Form
    {
        private CustomerService _customerService;
        private AuthService _authService;

        public Change_Password()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            _customerService = new CustomerService();
            _authService = new AuthService();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string currPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confPassword = txtConfirmPassword.Text;

            // 1. Empty checks 
            if (string.IsNullOrWhiteSpace(currPassword) ||
                string.IsNullOrWhiteSpace(newPassword) ||
                string.IsNullOrWhiteSpace(confPassword))
            {
                ShowError("Please fill in all fields.", txtCurrentPassword);
                return;
            }

            // Verify current password securely via the Service Layer
            string username = UserSession.CurrentUser.Username;
            var verifiedUser = _authService.Login(username, currPassword);

            if (verifiedUser == null)
            {
                ShowError("Current password is incorrect.", txtCurrentPassword);
                return;
            }

            // New password must differ from current 
            if (newPassword == currPassword)
            {
                ShowError("New password must be different from your current password.", txtNewPassword);
                return;
            }

            // Regex validation 
            if (!Regex.IsMatch(newPassword, ValidationHelp.PassRegex))
            {
                ShowError("Password must be at least 8 characters with uppercase, lowercase and a number.", txtNewPassword);
                txtConfirmPassword.Clear();
                return;
            }

            // Confirm password match 
            if (newPassword != confPassword)
            {
                ShowError("Passwords do not match.", txtConfirmPassword);
                return;
            }

            // Save securely using the Service Layer
            string hashedNewPassword = PasswordHasher.HashPassword(newPassword);
            int currentUserId = UserSession.CurrentUser.Id;

            bool success = _customerService.UpdatePassword(currentUserId, hashedNewPassword);

            if (success)
            {
                lblError.Visible = false;
                MessageBox.Show("Password changed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Closes the popup safely
            }
            else
            {
                ShowError("System error: Could not update password.", txtCurrentPassword);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // Simply closes the dialog without saving
        }

        private void ShowError(string message, TextBox focusBox)
        {
            lblError.Text = message;
            lblError.Visible = true;
            focusBox.Clear();
            focusBox.Focus();
        }
    }
}