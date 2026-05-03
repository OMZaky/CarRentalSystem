using System;
using System.Windows.Forms;
using CarRentalSystem.DTOs;
using CarRentalSystem.Services;

namespace CarRentalSystem.Forms
{
    public partial class Final_Registration : Form
    {
        private RegistrationDTO _userData;
        private CustomerService _customerService;

        public Final_Registration(RegistrationDTO userData)
        {
            InitializeComponent();
            _userData = userData;
            _customerService = new CustomerService();

            btnRegister.Click += btnRegister_Click;
            btnCancel.Click += btnCancel_Click;

            // Wire up the "Enter" key trick for smooth UX
            txtPhoneNumber.KeyDown += SubmitOnEnter_KeyDown;
            txtSSN.KeyDown += SubmitOnEnter_KeyDown;
            txtLicenseNum.KeyDown += SubmitOnEnter_KeyDown;

            // UX Rule: Prevent users from picking a license expiration date in the past!
            DateSSNExpirationDate.MinDate = DateTime.Today;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string phone = txtPhoneNumber.Text.Trim();
            string ssn = txtSSN.Text.Trim();
            string license = txtLicenseNum.Text.Trim();
            DateTime expiry = DateSSNExpirationDate.Value.Date;

            if (string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(ssn) || string.IsNullOrWhiteSpace(license))
            {
                MessageBox.Show("Please fill out all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Disable the button to prevent double-clicks while Azure is processing
            btnRegister.Enabled = false;
            btnRegister.Text = "Creating Account...";

            bool success = _customerService.RegisterCustomer(_userData, phone, ssn, license, expiry);

            if (success)
            {
                MessageBox.Show("Registration Complete! Welcome to DriveEasy.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("A database error occurred. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRegister.Enabled = true;
                btnRegister.Text = "Register";
            }
        }

        // --- CANCEL BUTTON ---
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void SubmitOnEnter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Kills the "Ding" sound
                btnRegister.PerformClick(); // Simulates clicking Register
            }
        }
    }
}