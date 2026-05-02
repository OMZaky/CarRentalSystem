using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CarRentalSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Forms
{
    public partial class Create_vehicle : Form
    {
        private readonly int? _vehicleId;

        public Create_vehicle()
        {
            InitializeComponent();
            SetupCreateMode();
        }

        public Create_vehicle(int vehicleId)
        {
            InitializeComponent();
            _vehicleId = vehicleId;
            SetupManageMode();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SetupCreateMode()
        {
            Text = "Create Vehicle";
            label4.Text = "Create Vehicle";
            btnEditDetails.Text = "Create";
            SetFieldsReadOnly(false);
            ClearFields();
        }

        private void SetupManageMode()
        {
            Text = "Manage Vehicle";
            label4.Text = "Manage Vehicle";
            btnEditDetails.Text = "Edit Details";
            SetFieldsReadOnly(true);
            LoadVehicleDetails();
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

                    // TextBoxes
                    txtFirstName.Text = vehicle.Model;
                    txtSsn.Text = vehicle.Year.ToString();
                    txtEmail.Text = vehicle.PlateNum;
                    textBox1.Text = vehicle.Color;

                    // DatePicker (Added to match your Vehicle.PurchaseDate model)
                    dtpPickup.Value = vehicle.PurchaseDate;

                    // Dropdowns (ComboBoxes)
                    // THE FIX: Use .VehicleType instead of .Name to match VehicleCategory.cs
                    cmbCategory.Text = vehicle.Category != null ? vehicle.Category.VehicleType : "";

                    comboBox1.Text = vehicle.Branch != null ? vehicle.Branch.City : "";
                    comboBox2.Text = vehicle.Status.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Could not load vehicle details.\n\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
        private void SetFieldsReadOnly(bool readOnly)
        {
            txtFirstName.ReadOnly = readOnly;
            txtSsn.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            textBox1.ReadOnly = readOnly;

            cmbCategory.Enabled = !readOnly;
            comboBox1.Enabled = !readOnly;
            comboBox2.Enabled = !readOnly;
            dtpPickup.Enabled = !readOnly;
        }

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtSsn.Clear();
            txtEmail.Clear();
            textBox1.Clear();

            cmbCategory.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            dtpPickup.Value = DateTime.Now;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
