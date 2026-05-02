using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CarRentalSystem.Data;
using CarRentalSystem.Models;
using CarRentalSystem.Core;

namespace CarRentalSystem.Forms
{
    public partial class Car_View : Form
    {
        private Vehicle car;
        private DateTime dateto;
        private DateTime datefrom;


        public Car_View(Vehicle carobject,DateTime from,DateTime to)
        {
            InitializeComponent();
            car = carobject;
            loadcardetails();
            dateto = to;
            datefrom = from;
        }
        private void loadcardetails()
        {
            label6.Text = car.Id.ToString();
            label4.Text = car.Model;
            label9.Text = car.PlateNum;
            label7.Text = car.Category.VehicleType;
            label14.Text = datefrom.ToString();
            label16.Text = dateto.ToString();
            int  temp = (dateto - datefrom).Days;
            decimal rate = car.Category.DailyRate;
            rate *=temp;
            label13.Text = rate.ToString();
            
            
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using ( var context = new AppDbContext())
            {
                var newreserves = new Reserves
                {
                    VehicleId = car.Id,CustomerId = UserSession.CurrentUser.Id,ReservationDate = datefrom,Duration = (dateto-datefrom).Days,Status = ReservationStatus.Reserved

                };
                context.Reservations.Add(newreserves);
                context.SaveChanges();
                MessageBox.Show("u have bought the car successfully!","Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
