using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CarRentalSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Forms
{
    public partial class employeeCarSearch : Form
    {
        private DataGridView dgvCars = null!;

        public employeeCarSearch()
        {
            InitializeComponent();
            SetupForm();
            LoadFilterOptions();
            SearchCars();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cmbBranch.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            rbAll.Checked = true;
            txtMinPrice.Clear();
            txtMaxPrice.Clear();
            dtpFromDate.Value = DateTime.Today;
            dtpToDate.Value = DateTime.Today.AddDays(1);
            SearchCars();
        }

        private void lblPriceRange_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchCars();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            if (dgvCars.SelectedRows.Count > 0 &&
                dgvCars.SelectedRows[0].DataBoundItem is EmployeeCarSearchResult selectedCar)
            {
                using (var manageForm = new Create_vehicle(selectedCar.Id))
                {
                    manageForm.ShowDialog();
                }
            }
            else
            {
                using (var createForm = new Create_vehicle())
                {
                    createForm.ShowDialog();
                }
            }

            SearchCars();
        }

        private void SetupForm()
        {
            dtpFromDate.MinDate = DateTime.Today;
            dtpToDate.MinDate = DateTime.Today;
            dtpFromDate.Value = DateTime.Today;
            dtpToDate.Value = DateTime.Today.AddDays(1);
            rbAll.Checked = true;

            dgvCars = new DataGridView
            {
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoGenerateColumns = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize,
                Location = new Point(31, 369),
                MultiSelect = false,
                Name = "dgvCars",
                ReadOnly = true,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                Size = new Size(895, 200),
                TabIndex = 11
            };

            dgvCars.CellMouseDown += dgvCars_CellMouseDown;
            dgvCars.MouseDown += dgvCars_MouseDown;

            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(EmployeeCarSearchResult.Id), HeaderText = "ID", Width = 55 });
            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(EmployeeCarSearchResult.PlateNumber), HeaderText = "Plate", Width = 95 });
            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(EmployeeCarSearchResult.Model), HeaderText = "Model", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(EmployeeCarSearchResult.Year), HeaderText = "Year", Width = 70 });
            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(EmployeeCarSearchResult.Category), HeaderText = "Category", Width = 110 });
            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(EmployeeCarSearchResult.Branch), HeaderText = "Branch", Width = 120 });
            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(EmployeeCarSearchResult.Status), HeaderText = "Status", Width = 95 });
            dgvCars.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = nameof(EmployeeCarSearchResult.DailyPrice), HeaderText = "EGP/Day", Width = 90, DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" } });

            panelMain.Controls.Add(dgvCars);
        }

        private void LoadFilterOptions()
        {
            cmbBranch.Items.Clear();
            cmbCategory.Items.Clear();
            cmbBranch.Items.Add("All Branches");
            cmbCategory.Items.Add("All Categories");

            try
            {
                using (var context = new AppDbContext())
                {
                    cmbBranch.Items.AddRange(context.Branches
                        .AsNoTracking()
                        .OrderBy(b => b.City)
                        .Select(b => b.City)
                        .Distinct()
                        .Cast<object>()
                        .ToArray());

                    cmbCategory.Items.AddRange(context.VehicleCategories
                        .AsNoTracking()
                        .OrderBy(c => c.VehicleType)
                        .Select(c => c.VehicleType)
                        .Distinct()
                        .Cast<object>()
                        .ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load car filters.\n\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cmbBranch.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
        }

        private void SearchCars()
        {
            if (!TryReadFilters(out decimal? minPrice, out decimal? maxPrice))
            {
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    var query = context.Vehicles
                        .AsNoTracking()
                        .Include(v => v.Branch)
                        .Include(v => v.Category)
                        .AsQueryable();

                    if (rbAvailable.Checked)
                    {
                        query = query.Where(v => v.Status == VehicleStatus.Available);
                    }
                    else if (rbRented.Checked)
                    {
                        query = query.Where(v => v.Status == VehicleStatus.Rented);
                    }

                    if (cmbBranch.SelectedIndex > 0 && cmbBranch.SelectedItem != null)
                    {
                        string selectedBranch = cmbBranch.SelectedItem.ToString() ?? string.Empty;
                        query = query.Where(v => v.Branch != null && v.Branch.City == selectedBranch);
                    }

                    if (cmbCategory.SelectedIndex > 0 && cmbCategory.SelectedItem != null)
                    {
                        string selectedCategory = cmbCategory.SelectedItem.ToString() ?? string.Empty;
                        query = query.Where(v => v.Category != null && v.Category.VehicleType == selectedCategory);
                    }

                    if (minPrice.HasValue)
                    {
                        query = query.Where(v => v.Category != null && v.Category.DailyRate >= minPrice.Value);
                    }

                    if (maxPrice.HasValue)
                    {
                        query = query.Where(v => v.Category != null && v.Category.DailyRate <= maxPrice.Value);
                    }

                    DateTime fromDate = dtpFromDate.Value.Date;
                    DateTime toDate = dtpToDate.Value.Date;
                    var blockedVehicleIds = GetBlockedVehicleIds(context, fromDate, toDate);

                    if (rbAvailable.Checked)
                    {
                        query = query.Where(v => !blockedVehicleIds.Contains(v.Id));
                    }

                    var cars = query
                        .OrderBy(v => v.Model)
                        .Select(v => new EmployeeCarSearchResult
                        {
                            Id = v.Id,
                            PlateNumber = v.PlateNum,
                            Model = v.Model,
                            Year = v.Year,
                            Category = v.Category != null ? v.Category.VehicleType : "Uncategorized",
                            Branch = v.Branch != null ? v.Branch.City : "Unknown",
                            Status = v.Status.ToString(),
                            DailyPrice = v.Category != null ? v.Category.DailyRate : 0
                        })
                        .ToList();

                    dgvCars.DataSource = cars;
                    ClearCarSelection();
                    lblAvailableCars.Text = $"{cars.Count} Cars Found";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not search cars.\n\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool TryReadFilters(out decimal? minPrice, out decimal? maxPrice)
        {
            minPrice = null;
            maxPrice = null;

            if (dtpToDate.Value.Date < dtpFromDate.Value.Date)
            {
                MessageBox.Show("To Date must be the same as or after From Date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!TryReadPrice(txtMinPrice.Text, "Minimum price", out minPrice))
            {
                return false;
            }

            if (!TryReadPrice(txtMaxPrice.Text, "Maximum price", out maxPrice))
            {
                return false;
            }

            if (minPrice.HasValue && maxPrice.HasValue && minPrice.Value > maxPrice.Value)
            {
                MessageBox.Show("Minimum price cannot be greater than maximum price.", "Invalid Price Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private static bool TryReadPrice(string text, string fieldName, out decimal? price)
        {
            price = null;

            if (string.IsNullOrWhiteSpace(text))
            {
                return true;
            }

            if (!decimal.TryParse(text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal parsedPrice) || parsedPrice < 0)
            {
                MessageBox.Show($"{fieldName} must be a valid positive number.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            price = parsedPrice;
            return true;
        }

        private static int[] GetBlockedVehicleIds(AppDbContext context, DateTime fromDate, DateTime toDate)
        {
            var rentedIds = context.Rentals
                .AsNoTracking()
                .Where(r =>
                    (r.Status == RentalStatus.Active || r.Status == RentalStatus.Overdue) &&
                    r.PlannedStart <= toDate &&
                    r.PlannedReturn >= fromDate)
                .Select(r => r.VehicleId);

            var reservedIds = context.Reservations
                .AsNoTracking()
                .Where(r =>
                    r.Status == ReservationStatus.Reserved &&
                    r.ReservationDate <= toDate &&
                    r.ReservationDate.AddDays(r.Duration) >= fromDate)
                .Select(r => r.VehicleId);

            return rentedIds.Concat(reservedIds).Distinct().ToArray();
        }

        private void dgvCars_CellMouseDown(object? sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvCars.Rows[e.RowIndex].Selected)
            {
                BeginInvoke(new Action(ClearCarSelection));
            }
        }

        private void dgvCars_MouseDown(object? sender, MouseEventArgs e)
        {
            var hit = dgvCars.HitTest(e.X, e.Y);

            if (hit.RowIndex < 0)
            {
                ClearCarSelection();
            }
        }

        private void ClearCarSelection()
        {
            dgvCars.ClearSelection();
            dgvCars.CurrentCell = null;
        }

        private class EmployeeCarSearchResult
        {
            public int Id { get; set; }
            public string PlateNumber { get; set; } = string.Empty;
            public string Model { get; set; } = string.Empty;
            public int Year { get; set; }
            public string Category { get; set; } = string.Empty;
            public string Branch { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;
            public decimal DailyPrice { get; set; }
        }

        private void panelFilters_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
