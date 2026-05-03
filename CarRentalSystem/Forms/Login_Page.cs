using CarRentalSystem;
using CarRentalSystem.Forms;
using CarRentalSystem.Core;
using CarRentalSystem.Data;
using CarRentalSystem.DTOs;
using CarRentalSystem.Models;
using CarRentalSystem.Services;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CarRentalSystem.Forms
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            string inputUsername = txtUsername.Text.Trim();
            string inputPassword = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(inputUsername) || string.IsNullOrEmpty(inputPassword))
            {
                ShowError("Please enter both username and password.");
                return;
            }

            // 1. Ask the service to handle the complex database login
            var authService = new AuthService();
            UserDTO user = authService.Login(inputUsername, inputPassword);

            if (user != null)
            {
                // 2. Success! Save the session centrally
                UserSession.Login(user);

                // 3. Role-Based Routing (No parameters passed!)
                Form nextForm;

                switch (UserSession.CurrentUser.Role)
                {
                    case UserRole.SystemAdmin:
                    case UserRole.BranchManager:
                    case UserRole.RentalAgent:
                        nextForm = new Employee_Dashboard();
                        break;

                    case UserRole.Customer:
                        nextForm = new Customer_Dashboard();
                        break;

                    default:
                        ShowError("Unknown user role detected.");
                        return;
                }

                this.Hide();

                nextForm.Show();

                txtUsername.Clear();
                txtPassword.Clear();
            }
            else
            {
                // Failure!
                ShowError("Invalid username, password, or connection error.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
        }

        private void ShowError(string errorMessage)
        {
            errorLabel.ForeColor = Color.Red;
            errorLabel.Text = errorMessage;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void RegisterLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            using (var registerPage = new Register_Page())
            {
                registerPage.ShowDialog();
            }
            this.Show();
        }
    }
}