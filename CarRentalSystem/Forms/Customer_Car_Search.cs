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

            lblDateSummary.Text = $"{dtpPickup.Value:MMM dd} — {dtpReturn.Value:MMM dd} · {days} days";

            // Fetch the baseline available cars from the Service
            var allCars = _vehicleService.SearchAvailableCars();

            // Start building our Filter Chain (In-Memory)
            var filteredCars = allCars.AsEnumerable();

            // -- CATEGORY FILTER --
            if (cmbCategory.SelectedIndex > 0 && cmbCategory.SelectedItem != null)
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString();
                filteredCars = filteredCars.Where(c => c.Category == selectedCategory);
            }

            // -- BRANCH FILTER --
            if (comboBox2.SelectedIndex > 0 && comboBox2.SelectedItem != null)
            {
                string selectedBranch = comboBox2.SelectedItem.ToString();
                filteredCars = filteredCars.Where(c => c.BranchName == selectedBranch);
            }

            // -- MIN PRICE FILTER --
            if (decimal.TryParse(textBox1.Text, out decimal minPrice))
            {
                filteredCars = filteredCars.Where(c => c.DailyPrice >= minPrice);
            }

            // -- MAX PRICE FILTER --
            if (decimal.TryParse(textBox3.Text, out decimal maxPrice))
            {
                filteredCars = filteredCars.Where(c => c.DailyPrice <= maxPrice);
            }

            // Apply Default Sorting (if they clicked search while a sort is active)
            filteredCars = ApplySorting(filteredCars);

            // Save to our class-level variable and Render
            _currentSearchResults = filteredCars.ToList();

            lblResultsCount.Text = $"{_currentSearchResults.Count} cars available for your dates";
            PopulateResults(_currentSearchResults, days);
        }

        private IEnumerable<CarSearchDTO> ApplySorting(IEnumerable<CarSearchDTO> cars)
        {
            if (cmbSort.SelectedIndex == 0) // "Price: Low to High"
                return cars.OrderBy(c => c.DailyPrice);

            if (cmbSort.SelectedIndex == 2) // "Price: High to Low"
                return cars.OrderByDescending(c => c.DailyPrice);

            if (cmbSort.SelectedIndex == 4) // "Newest First"
                return cars.OrderByDescending(c => c.Year);

            // Default return if nothing is selected
            return cars;
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Only sort if we actually have search results on the screen
            if (_currentSearchResults != null && _currentSearchResults.Any())
            {
                int days = (dtpReturn.Value.Date - dtpPickup.Value.Date).Days;

                // Re-sort the existing data
                var sortedCars = ApplySorting(_currentSearchResults).ToList();

                // Update the screen
                _currentSearchResults = sortedCars;
                PopulateResults(_currentSearchResults, days);
            }
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

                // "Hey Card, when your Rent button is clicked, trigger my method!"
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
                this.Hide();
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
                this.Show();
            }
            else
            {
                MessageBox.Show("Error: Could not locate car details.", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear the UI inputs
            cmbCategory.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            cmbSort.SelectedIndex = -1;

            textBox1.Clear();
            textBox3.Clear();
        }

        private void lblFilterTitle_Click(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void pnlResults_Paint(object sender, PaintEventArgs e) { }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e) { }
        private void flowCars_Paint(object sender, PaintEventArgs e) { }
    }
}