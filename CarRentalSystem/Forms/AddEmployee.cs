using System;
using System.Windows.Forms;
using CarRentalSystem.Models;
using CarRentalSystem.Services;
using CarRentalSystem.DTOs;
using CarRentalSystem.Core;

namespace CarRentalSystem.Forms
{
    public partial class AddEmployee : Form
    {
        internal employeeDTO NewEmployeeData { get; private set; }
        private EmpSearchService _empService;

        public AddEmployee()
        {
            InitializeComponent();
            _empService = new EmpSearchService();

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            this.Load += AddEmployee_Load;
            btnAdd.Click += btnAdd_Click;
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // 1. Auto-fill the Role Dropdown from your EmployeeRole Enum
            comboBoxRole.DataSource = Enum.GetValues(typeof(EmployeeRole));

            // 2. Auto-fill the Branch Dropdown directly from the Database!
            var branches = _empService.GetBranches();
            comboBoxBranch.DataSource = branches;
            comboBoxBranch.DisplayMember = "City";
            comboBoxBranch.ValueMember = "Id";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtSSN.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    MessageBox.Show("Please fill out all required fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txtSalary.Text, out decimal salary))
                {
                    MessageBox.Show("Please enter a valid number for Salary.", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newEmp = new Employee
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Ssn = txtSSN.Text.Trim(),
                    HireDate = DateTime.Today,
                    Email = txtEmail.Text.Trim(),
                    Salary = salary,
                    Role = (EmployeeRole)comboBoxRole.SelectedItem,
                    Username = txtUsername.Text.Trim(),
                    PasswordHash = PasswordHasher.HashPassword(txtPassword.Text),
                    BranchId = (int)comboBoxBranch.SelectedValue
                };

                var savedEmp = _empService.AddNewEmployee(newEmp);

                NewEmployeeData = new employeeDTO
                {
                    Id = savedEmp.Id,
                    FullName = $"{savedEmp.FirstName} {savedEmp.LastName}",
                    Email = savedEmp.Email,
                    HireDate = savedEmp.HireDate,
                    Role = savedEmp.Role,
                    Branch = savedEmp.Branch.City
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalary_TextChanged(object sender, EventArgs e)
        {

        }
    }
}