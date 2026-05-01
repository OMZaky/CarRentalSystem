using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CarRentalSystem.Data;
using CarRentalSystem.Models;

namespace CarRentalSystem
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

            try
            {
                // Database Validation using Entity Framework
                using (var context = new AppDbContext())
                {
                    var user = context.Employees
                        .FirstOrDefault(emp => emp.Username == inputUsername && emp.PasswordHash == inputPassword);

                    if (user != null)
                    {
                        // 1. Save the user to the global session!
                        UserSession.CurrentUser = user;

                        // 2. Create the next page
                        //var dashboard = new Main_Dashboard(); // We will create this file next

                        // 3. Show the dashboard
                        //dashboard.Show();

                        txtUsername.Clear();
                        txtPassword.Clear();
                        txtUsername.Focus();

                        // 4. Hide the login screen (don't close it, or the whole app shuts down)
                        this.Hide();
                    }
                    else
                    {
                        ShowError("Username or Password not correct.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Catches Azure firewall issues or missing database connections
                ShowError("Failed to connect to the database. Check your connection.");
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
    }
}