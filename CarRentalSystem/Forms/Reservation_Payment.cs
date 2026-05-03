using System;
using System.Windows.Forms;
using CarRentalSystem.Services;
using CarRentalSystem.Core;

namespace CarRentalSystem.Forms
{
    public partial class Reservation_Payment : Form
    {
        private int _vehicleId;
        private decimal _totalAmount;
        private DateTime _dateFrom;
        private DateTime _dateTo;
        private ReservationService _reservationService; // The service lives here now!

        // 1. CATCH THE DATA
        public Reservation_Payment(int vehicleId, decimal totalAmount, DateTime from, DateTime to)
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;


            _reservationService = new ReservationService();

            _vehicleId = vehicleId;
            _totalAmount = totalAmount;
            _dateFrom = from;
            _dateTo = to;

            // Example: lblAmountToPay.Text = $"{_totalAmount:N0} EGP";
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            // ... (Your dummy payment validation logic here) ...

            // Move the database save logic here!
            int currentUserId = UserSession.CurrentUser.Id;
            bool success = _reservationService.CreateReservation(currentUserId, _vehicleId, _dateFrom, _dateTo);

            if (success)
            {
                MessageBox.Show("Payment successful! Your reservation is confirmed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 2. THE SUCCESS SIGNAL: This tells Car_View to also close itself!
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}