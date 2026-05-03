using CarRentalSystem.Core;
using CarRentalSystem.DTOs;
using CarRentalSystem.Forms;
using System;
using System.Windows.Forms;

namespace CarRentalSystem.Forms
{
    public partial class Customer_Dashboard : Form
    {
        public Customer_Dashboard()
        {
            InitializeComponent();
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            var user = UserSession.CurrentUser;

            if (user == null || user.Role != UserRole.Customer)
            {
                MessageBox.Show("Invalid session. Please log in again.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            label3.Text = user.FullName;
            label6.Text = $"{user.FullName}!";

            string currentDate = DateTime.Now.ToString("dddd, MMMM dd yyyy");
            label7.Text = currentDate;

        }


        // My Account Button
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var accountForm = new Account_Information())
            {
                accountForm.ShowDialog();
            }
            this.Show();
            
        }

        // My Orders Button
        private void button1_Click(object sender, EventArgs e)
        {
             using(var ordersForm = new Order_View())
            {
              ordersForm.ShowDialog();
            }
            
        }

        // Search Cars Button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var searchForm = new Customer_Car_Search())
            {
                searchForm.ShowDialog();
            }
            this.Show();
        }

        // Logout Button
        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // CRITICAL: Actually clear the session memory!
                UserSession.Logout();

                Application.Restart();
            }
        }

        // This runs whenever the 'X' in the title bar is clicked
        private void Customer_Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // This is the "Master Kill Switch"
            // It ensures that even if you have a hidden Login form, the .exe stops.
            Application.Exit();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
    }
}