using System;
using System.Windows.Forms;
using CarRentalSystem.Core;
using CarRentalSystem.Services;
namespace CarRentalSystem.Forms
{
    public partial class Car_View : Form
    {
        private int _vehicleId;
        private DateTime _dateFrom;
        private DateTime _dateTo;
        private ReservationService reservationService;
        private decimal _totalPrice; // Added to easily pass the cost to the payment screen

        public Car_View(int vehicleId, string model, string category, decimal dailyPrice, DateTime from, DateTime to,string PlateNum)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;


            _vehicleId = vehicleId;
            _dateFrom = from;
            _dateTo = to;
            reservationService = new ReservationService();

            LoadCarDetails(model, category, dailyPrice,PlateNum);
        }

        private void LoadCarDetails(string model, string category, decimal dailyPrice,string PlateNum)
        {
            int totalDays = (_dateTo.Date - _dateFrom.Date).Days;
            if (totalDays <= 0) totalDays = 1; // Failsafe so it never multiplies by 0
            _totalPrice = dailyPrice * totalDays; // Store the calculated total


            decimal depositAmount = _totalPrice * 0.25m;

            label6.Text = $"Car_ID:{_vehicleId}";
            label4.Text = model;
            label7.Text = category;
            label9.Text = PlateNum;
            label14.Text = _dateFrom.ToString("MMM dd, yyyy");
            label16.Text = _dateTo.ToString("MMM dd, yyyy");

            label17.Text = $"{_totalPrice:N0} EGP";
            label19.Text = $"{depositAmount:F2} EGP";
        }

        // --- PROCEED TO PAYMENT BUTTON ---
        private void button3_Click(object sender, EventArgs e)
        {
            // 1. Security Check
            if (UserSession.CurrentUser == null)
            {
                MessageBox.Show("Your session has expired. Please log in again.", "Security Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            reservationService.CreateReservation(
                UserSession.CurrentUser.Id, 
                _vehicleId, 
                _dateFrom, 
                _dateTo
            );
                MessageBox.Show("Reservation completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close(); 
            
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