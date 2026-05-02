using car_rental_system;
using car_rental_system.Forms;
using CarRentalSystem.Core;
using CarRentalSystem.Data;
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


            // 1. Create an instance of your new service
            var authService = new AuthService();

            // 2. Ask the service to handle the complex database login
            IUser user = authService.Login(inputUsername, inputPassword);

            if (user != null)
            {
                // Success! Save the session and route the user
                UserSession.CurrentUser = user;

                if (user is Customer customer)
                {
                    var frm = new Customer_Dashboard(customer); 
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.Show();
                }
                else if (user is Employee employee)
                {
                    var frm = new employeeDashboard(employee);
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.Show();
                }

                this.Hide();

                //var dashboard = new Main_Dashboard();
                //dashboard.Show();

                txtUsername.Clear();
                txtPassword.Clear();
                this.Hide();
            }
            else
            {
                // Failure! The service returned null.
                ShowError("Invalid username, password, or connection error.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Code to navigate to the register page
            // Register_Page registerPage = new Register_Page();
            // registerPage.Show();
            // this.Hide();
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
            var frm = new Register_Page();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }
    }
}