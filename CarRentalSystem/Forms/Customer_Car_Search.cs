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
            flowCars.SizeChanged += flowCars_SizeChanged;
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
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(new object[] { "All Branches", "Cairo International Airport", "Alexandria", "New Cairo HQ" });
            comboBox2.SelectedIndex = 0;
            label2.Text = "LEVEL";
            label2.Visible = true;
            comboBox1.Visible = true;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new object[] { "All Levels", "Economy", "Standard", "Premium", "VIP" });
            comboBox1.SelectedIndex = 0;
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

            var allCars = _vehicleService.SearchAvailableCars();
            var filteredCars = allCars.AsEnumerable();

            // -- CATEGORY FILTER (FIXED: Case Insensitive & Trimmed) --
            if (cmbCategory.SelectedIndex > 0 && cmbCategory.SelectedItem != null)
            {
                string selectedCategory = cmbCategory.SelectedItem.ToString().Trim();
                filteredCars = filteredCars.Where(c => c.Category.Equals(selectedCategory, StringComparison.OrdinalIgnoreCase));
            }

            // -- BRANCH FILTER (FIXED: Case Insensitive & Trimmed) --
            if (comboBox2.SelectedIndex > 0 && comboBox2.SelectedItem != null)
            {
                string selectedBranch = comboBox2.SelectedItem.ToString().Trim();
                filteredCars = filteredCars.Where(c => c.BranchName.Equals(selectedBranch, StringComparison.OrdinalIgnoreCase));
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

            filteredCars = ApplySorting(filteredCars);
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
            if (_currentSearchResults != null && _currentSearchResults.Any())
            {
                var sortedCars = ApplySorting(_currentSearchResults).ToList();
                _currentSearchResults = sortedCars;

                int days = (dtpReturn.Value.Date - dtpPickup.Value.Date).Days;

                // 1. FREEZE THE ENTIRE PANEL
                flowCars.SuspendLayout();

                for (int i = 0; i < sortedCars.Count; i++)
                {
                    var card = (CarCardControl)flowCars.Controls[i];

                    // 2. FREEZE THE INDIVIDUAL CARD
                    card.SuspendLayout();
                    card.UpdateData(sortedCars[i], days);
                    card.ResumeLayout();
                }

                // 3. UNFREEZE (Calculates the math exactly ONCE)
                flowCars.ResumeLayout();
            }
        }

        private void PopulateResults(System.Collections.Generic.List<DTOs.CarSearchDTO> cars, int totalDays)
        {
            flowCars.SuspendLayout();

            // THE FIX: Physically destroy the old cards in RAM
            foreach (Control c in flowCars.Controls)
            {
                c.Dispose();
            }
            flowCars.Controls.Clear(); // Now it is safe to clear

            foreach (var carDto in cars)
            {
                var card = new CarCardControl(carDto, totalDays);
                card.Margin = new Padding(10);
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
                    dtpReturn.Value,
                    selectedCar.PlateNum))
                {
                    viewForm.ShowDialog();
                }
                
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
        // ADD THIS METHOD TO FIX THE RED SQUIGGLY
        private void flowCars_SizeChanged(object sender, EventArgs e)
        {
            flowCars.SuspendLayout();
            foreach (Control card in flowCars.Controls)
            {
                card.Width = flowCars.ClientSize.Width - 25; 
            }
            flowCars.ResumeLayout();
        }
    }
}