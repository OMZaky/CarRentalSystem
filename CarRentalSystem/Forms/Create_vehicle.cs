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
            {
                return;
            }

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
                    txtLastName.Text = vehicle.Year.ToString();
                    txtEmail.Text = vehicle.PlateNum;
                    txtPhone.Text = vehicle.Branch != null ? vehicle.Branch.City : "";
                    txtSsn.Text = vehicle.Color;
                    txtUsername.Text = vehicle.Status.ToString();
                    lblLastNameTitle.Text = "Year";
                    lblEmailTitle.Text = "Plate Number";
                    lblPhoneTitle.Text = "Branch";
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
            txtLastName.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            txtPhone.ReadOnly = readOnly;
            txtSsn.ReadOnly = readOnly;
            txtUsername.ReadOnly = readOnly;
        }

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtSsn.Clear();
            txtUsername.Clear();
            lblLastNameTitle.Text = "Year";
            lblEmailTitle.Text = "Plate Number";
            lblPhoneTitle.Text = "Branch";
        }
    }
}
