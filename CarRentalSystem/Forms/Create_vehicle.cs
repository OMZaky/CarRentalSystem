using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CarRentalSystem.Data;
using CarRentalSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Forms
{
    public partial class Create_vehicle : Form
    {
        private readonly int? _vehicleId;

        public Create_vehicle()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            SetupCreateMode();
        }

        public Create_vehicle(int vehicleId)
        {
            InitializeComponent();
            _vehicleId = vehicleId;
            SetupManageMode();
        }

        // Setup 

        private void SetupCreateMode()
        {
            Text = "Create Vehicle";
            label4.Text = "Create Vehicle";
            btnEditDetails.Text = "Create";

            LoadComboData();
            SetFieldsReadOnly(false);       // everything editable
            ClearFields();

            btnEditDetails.Click += btnEditDetails_Click;
        }

        private void SetupManageMode()
        {
            Text = "Manage Vehicle";
            label4.Text = "Manage Vehicle";
            btnEditDetails.Text = "Save Changes";

            LoadComboData();

            // Model & Year are read-only; the rest are editable
            txtFirstName.ReadOnly = true;
            txtSsn.ReadOnly = true;
            txtEmail.ReadOnly = false;   // PlateNo editable
            textBox1.ReadOnly = false;   // Color editable
            comboBox1.Enabled = true;    // Branch editable
            cmbCategory.Enabled = true;    // Category editable
            comboBox2.Enabled = true;    // Status editable
            dtpPickup.Enabled = false;   // Purchase date locked

            LoadVehicleDetails();

            btnEditDetails.Click += btnEditDetails_Click;
        }

        //  Load combo data 

        private void LoadComboData()
        {
            comboBox2.Items.Clear();
            foreach (VehicleStatus status in Enum.GetValues(typeof(VehicleStatus)))
                comboBox2.Items.Add(status);

            try
            {
                using (var context = new AppDbContext())
                {
                    comboBox1.Items.Clear();
                    var branches = context.Branches.AsNoTracking().ToList();
                    foreach (var b in branches)
                        comboBox1.Items.Add(b);
                    comboBox1.DisplayMember = "City";
                    comboBox1.ValueMember = "Id";

                    cmbCategory.Items.Clear();
                    var categories = context.VehicleCategories.AsNoTracking().ToList();
                    foreach (var c in categories)
                        cmbCategory.Items.Add(c);
                    cmbCategory.DisplayMember = "Level";
                    cmbCategory.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load dropdown data.\n\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void LoadVehicleDetails()
        {
            if (!_vehicleId.HasValue) return;

            try
            {
                using (var context = new AppDbContext())
                {
                    var vehicle = context.Vehicles
                        .AsNoTracking()
                        .Include(v => v.Branch)
                        .Include(v => v.Category)
                        .FirstOrDefault(v => v.Id == _vehicleId.Value);

                    if (vehicle == null)
                    {
                        MessageBox.Show("Selected vehicle could not be found.", "Vehicle Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                        return;
                    }

                    txtFirstName.Text = vehicle.Model;
                    txtSsn.Text = vehicle.Year.ToString();
                    txtEmail.Text = vehicle.PlateNum;
                    textBox1.Text = vehicle.Color;
                    dtpPickup.Value = vehicle.PurchaseDate != default ? vehicle.PurchaseDate : DateTime.Today;

                    for (int i = 0; i < comboBox1.Items.Count; i++)
                        if (comboBox1.Items[i] is Branch b && b.Id == vehicle.BranchId)
                        { comboBox1.SelectedIndex = i; break; }

                    for (int i = 0; i < cmbCategory.Items.Count; i++)
                        if (cmbCategory.Items[i] is VehicleCategory c && c.Id == vehicle.CategoryId)
                        { cmbCategory.SelectedIndex = i; break; }

                    comboBox2.SelectedItem = vehicle.Status;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load vehicle details.\n\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            if (!ValidateFields()) return;

            if (_vehicleId.HasValue)
                UpdateVehicle();
            else
                CreateVehicle();
        }

        private void CreateVehicle()
        {
            try
            {
                var vehicle = new Vehicle
                {
                    Model = txtFirstName.Text.Trim(),
                    Year = int.Parse(txtSsn.Text.Trim()),
                    PlateNum = txtEmail.Text.Trim(),
                    Color = textBox1.Text.Trim(),
                    PurchaseDate = dtpPickup.Value.Date,
                    Status = (VehicleStatus)comboBox2.SelectedItem,
                    BranchId = ((Branch)comboBox1.SelectedItem).Id,
                    CategoryId = ((VehicleCategory)cmbCategory.SelectedItem).Id,
                    ImagePath = ""
                };

                using (var context = new AppDbContext())
                {
                    context.Vehicles.Add(vehicle);
                    context.SaveChanges();
                }

                MessageBox.Show("Vehicle created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not create vehicle.\n\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateVehicle()
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var vehicle = context.Vehicles.FirstOrDefault(v => v.Id == _vehicleId.Value);

                    if (vehicle == null)
                    {
                        MessageBox.Show("Vehicle no longer exists in the database.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Close();
                        return;
                    }

                    // Only update the editable fields
                    vehicle.PlateNum = txtEmail.Text.Trim();
                    vehicle.Color = textBox1.Text.Trim();
                    vehicle.Status = (VehicleStatus)comboBox2.SelectedItem;
                    vehicle.BranchId = ((Branch)comboBox1.SelectedItem).Id;
                    vehicle.CategoryId = ((VehicleCategory)cmbCategory.SelectedItem).Id;

                    context.SaveChanges();
                }

                MessageBox.Show("Vehicle updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not update vehicle.\n\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            // Model & Year only validated on create (locked on manage)
            if (!_vehicleId.HasValue)
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                { MessageBox.Show("Model is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

                if (!int.TryParse(txtSsn.Text.Trim(), out int year) || year < 1900 || year > DateTime.Now.Year + 1)
                { MessageBox.Show("Please enter a valid year.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            { MessageBox.Show("Plate number is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            { MessageBox.Show("Color is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            if (comboBox1.SelectedItem == null)
            { MessageBox.Show("Please select a branch.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            if (cmbCategory.SelectedItem == null)
            { MessageBox.Show("Please select a category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            if (comboBox2.SelectedItem == null)
            { MessageBox.Show("Please select a status.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning); return false; }

            return true;
        }

        private void SetFieldsReadOnly(bool readOnly)
        {
            txtFirstName.ReadOnly = readOnly;
            txtSsn.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            textBox1.ReadOnly = readOnly;
            comboBox1.Enabled = !readOnly;
            comboBox2.Enabled = !readOnly;
            cmbCategory.Enabled = !readOnly;
            dtpPickup.Enabled = !readOnly;
        }

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtSsn.Clear();
            txtEmail.Clear();
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            dtpPickup.Value = DateTime.Today;

            lblFirstNameTitle.Text = "Model";
            lblSsnTitle.Text = "Year";
            lblEmailTitle.Text = "Plate Number";
            lblPhoneTitle.Text = "Branch";
            lblLastNameTitle.Text = "Category";
            lblUsernameTitle.Text = "Status";
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { this.Close(); }
    }
}