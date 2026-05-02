using System;
using System.Windows.Forms;
using CarRentalSystem.Core;       // For UserSession
using CarRentalSystem.Services;   // For ReservationService

namespace CarRentalSystem.Forms
{
    public partial class Car_View : Form
    {
        private int _vehicleId;
        private DateTime _dateFrom;
        private DateTime _dateTo;
        private ReservationService _reservationService;

        public Car_View(int vehicleId, string model, string category, decimal dailyPrice, DateTime from, DateTime to)
        {
            InitializeComponent();

            _reservationService = new ReservationService();

            _vehicleId = vehicleId;
            _dateFrom = from;
            _dateTo = to;

            LoadCarDetails(model, category, dailyPrice);
        }

        private void LoadCarDetails(string model, string category, decimal dailyPrice)
        {
            int totalDays = (_dateTo - _dateFrom).Days;
            decimal totalPrice = dailyPrice * totalDays;

            label6.Text = _vehicleId.ToString();
            label4.Text = model;
            label7.Text = category;

            label14.Text = _dateFrom.ToString("MMM dd, yyyy");
            label16.Text = _dateTo.ToString("MMM dd, yyyy");

            label13.Text = $"{totalPrice:N0} EGP";
        }

        // --- RESERVE BUTTON ---
        private void button3_Click(object sender, EventArgs e)
        {
            if (UserSession.CurrentUser == null)
            {
                MessageBox.Show("Your session has expired. Please log in again.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Disable button to prevent double-booking if the user clicks twice quickly
            button3.Enabled = false;
            button3.Text = "Processing...";

            // 3. Talk to the Service Layer
            int currentUserId = UserSession.CurrentUser.Id;
            bool success = _reservationService.CreateReservation(currentUserId, _vehicleId, _dateFrom, _dateTo);

            if (success)
            {
                MessageBox.Show("Your reservation was successful! You can view it in 'My Orders'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("A system error occurred while processing your reservation. Please try again.", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Re-enable the button so they can try again
                button3.Enabled = true;
                button3.Text = "Reserve";
            }
        }

        // --- BACK BUTTON ---
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label3_Click_1(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label16_Click(object sender, EventArgs e) { }
    }
}