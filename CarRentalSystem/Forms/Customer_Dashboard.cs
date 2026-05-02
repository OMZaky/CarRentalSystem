using CarRentalSystem.Forms;
using CarRentalSystem.Models;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace car_rental_system.Forms
{
    public partial class Customer_Dashboard : Form
    {
        private Customer CurrentUser;
        public Customer_Dashboard(Customer User)
        {
            InitializeComponent();
            this.CurrentUser = User;
            loaduserdashboard();

        }
        private void loaduserdashboard()
        {
            label3.Text = $"{CurrentUser.FirstName} {CurrentUser.LastName}";
            label6.Text = $"{CurrentUser.FirstName} {CurrentUser.LastName}";
            string currentdate = DateTime.Now.ToString();
            label7.Text = currentdate;
            label12.Text = currentdate;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are u sure  u want to log out???????????????", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                var loginPage = new Login_Page();
                loginPage.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            var frm = new Customer_Car_Search();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var frm = new account_information(this.CurrentUser);
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Show();
            this.Hide();
        }
    }
}
