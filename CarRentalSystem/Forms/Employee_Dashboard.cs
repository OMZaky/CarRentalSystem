using car_rental_system;
using CarRentalSystem.Core;  
using CarRentalSystem.DTOs;
using CarRentalSystem.Forms;
using System;
using System.Windows.Forms;

namespace CarRentalSystem
{
    public partial class Employee_Dashboard : Form
    {
        public Employee_Dashboard()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            var user = UserSession.CurrentUser;

            if (user == null)
            {
                MessageBox.Show("Session expired. Please log in again.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            label3.Text = user.FullName;
            label4.Text = user.Role.ToString();
            label6.Text = $"{user.FullName}!";

            label7.Text = DateTime.Now.ToString("dddd, MMMM dd yyyy");

            label9.Text = !string.IsNullOrEmpty(user.BranchCity) ? $"{user.BranchCity} Branch" : "Main Branch";

            if (user.Role == UserRole.BranchManager || user.Role == UserRole.SystemAdmin)
            {
                this.Text = $"DriveEasy - {user.Role} Portal";

                // Show "Manager Section" header

                label11.Visible = true;
                pictureBox6.Visible = true;

                button3.Visible = true;
                button3.Enabled = true;
                pictureBox7.Visible = true;
                label15.Visible = true;
            }
            else if(user.Role == UserRole.RentalAgent)
            {
                this.Text = "DriveEasy - Employee Portal";

                // Hide "Manager Section" header
                label11.Visible = false;
                pictureBox6.Visible = false;

                button3.Visible = false;
                button3.Enabled = false;
                pictureBox7.Visible = false;
                label15.Visible = false;
            }
        }


        // Car Search Button
        private void button1_Click(object sender, EventArgs e)
        {
            //we need here to do make a check, if manager or admin, make him go to sepearte form where he can CRUD cars


            // var carSearchForm = new CarSearchForm();
            // carSearchForm.ShowDialog();
            MessageBox.Show("Opening Car Search module...", "Navigation");
        }

        // Orders/Rentals Button
        private void button2_Click(object sender, EventArgs e)
        {
            // var ordersForm = new OrdersForm();
            // ordersForm.ShowDialog();
            MessageBox.Show("Opening Orders and Rentals module...", "Navigation");
        }

        // Employee Management Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser?.Role == UserRole.SystemAdmin ||
                UserSession.CurrentUser?.Role == UserRole.BranchManager)
            {
               
                this.Hide();
                using (var empMgmtForm = new employeeSearch())
                {
                    empMgmtForm.ShowDialog();
                }
                this.Show();
                
            }
            else
            {
                MessageBox.Show("Access Denied. You do not have administrator privileges.", "Security", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // This runs whenever the 'X' in the title bar is clicked
        private void Employee_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This is the "Master Kill Switch"
            // It ensures that even if you have a hidden Login form, the .exe stops.
            Application.Exit();
        }

       

        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
    }
}