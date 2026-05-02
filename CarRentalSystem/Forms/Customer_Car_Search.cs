using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CarRentalSystem.Core;
using CarRentalSystem.DTOs;       // Added to recognize CarSearchDTO
using CarRentalSystem.Services;

namespace CarRentalSystem.Forms
{
    public partial class Customer_Car_Search : Form
    {
        private VehicleService _vehicleService;

        private List<CarSearchDTO> _currentSearchResults;
        public Customer_Car_Search()
        {
            InitializeComponent();
            _vehicleService = new VehicleService();
            SetupDashboard();
        }

        private void SetupDashboard()
        {
            if (UserSession.CurrentUser != null)
            {
                string firstName = UserSession.CurrentUser.FullName.Split(' ')[0];
                lblWelcome.Text = $"Welcome, {firstName}!";
            }

            dtpPickup.MinDate = DateTime.Today;
            dtpReturn.MinDate = DateTime.Today.AddDays(1);

            lblResultsCount.Text = "Enter your dates and hit search.";
            lblDateSummary.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int days = (dtpReturn.Value.Date - dtpPickup.Value.Date).Days;

            if (days <= 0)
            {
                MessageBox.Show("Return date must be at least 1 day after pickup date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update Dynamic Labels
            lblDateSummary.Text = $"{dtpPickup.Value:MMM dd} — {dtpReturn.Value:MMM dd} · {days} days";

            // Call the Service Layer
            _currentSearchResults = _vehicleService.SearchAvailableCars();
            // Update Count Label
            lblResultsCount.Text = $"{_currentSearchResults.Count} cars available for your dates";
            // Render Results safely
            PopulateResults(_currentSearchResults, days);
        }

        private void PopulateResults(System.Collections.Generic.List<DTOs.CarSearchDTO> cars, int totalDays)
        {
            // CRITICAL FOR PERFORMANCE: Stops the UI from freezing/flickering while loading 50 cards
            flowCars.SuspendLayout();
            flowCars.Controls.Clear();

            foreach (var carDto in cars)
            {
                var card = new CarCardControl(carDto, totalDays);
                card.Margin = new Padding(10);

                // UNCOMMENT THIS LINE: "Hey Card, when your Rent button is clicked, trigger my method!"
                card.RentButtonClicked += Card_RentButtonClicked;

                flowCars.Controls.Add(card);
            }

            flowCars.ResumeLayout();
        }

        private void Card_RentButtonClicked(object sender, int clickedVehicleId)
        {
            // Find the specific car data from our saved search results
            var selectedCar = _currentSearchResults.FirstOrDefault(c => c.Id == clickedVehicleId);

            if (selectedCar != null)
            {
                using (var viewForm = new Car_View(
                    selectedCar.Id,
                    selectedCar.Model,
                    selectedCar.Category,
                    selectedCar.DailyPrice,
                    dtpPickup.Value,
                    dtpReturn.Value))
                {
                    viewForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Error: Could not locate car details.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblFilterTitle_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { } // Reset Button
        private void pnlResults_Paint(object sender, PaintEventArgs e) { }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) { }
        private void flowCars_Paint(object sender, PaintEventArgs e) { }
    }
}