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
            if (!_vehicleId.HasValue)
                return;

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

                    // Populate and select Branch
                    comboBox1.Items.Clear();
                    if (vehicle.Branch != null)
                    {
                        comboBox1.Items.Add(vehicle.Branch.City);
                        comboBox1.SelectedIndex = 0;
                    }

                    // Populate and select Status
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add(vehicle.Status.ToString());
                    comboBox2.SelectedIndex = 0;

                    // Populate and select Category
                    cmbCategory.Items.Clear();
                    if (vehicle.Category != null)
                    {
                        cmbCategory.Items.Add(vehicle.Category.Level);
                        cmbCategory.SelectedIndex = 0;
                    }

                    // Purchase date
                    if (vehicle.PurchaseDate != default)
                        dtpPickup.Value = vehicle.PurchaseDate;

                    // Fix label text to match what is actually displayed
                    lblFirstNameTitle.Text = "Model";
                    lblSsnTitle.Text = "Year";
                    lblEmailTitle.Text = "Plate Number";
                    lblPhoneTitle.Text = "Branch";
                    lblLastNameTitle.Text = "Category";
                    lblUsernameTitle.Text = "Status";
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

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}