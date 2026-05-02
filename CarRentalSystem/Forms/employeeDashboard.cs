using CarRentalSystem.Models;

namespace car_rental_system
{
    public partial class employeeDashboard : Form
    {
        private Employee emp;
        public employeeDashboard(Employee user)
        {
            InitializeComponent();
            this.emp = user;
            loadempdashboard();
        }
        private void loadempdashboard()
        {
            label3.Text = $"{emp.FirstName} {emp.LastName}";
            label4.Text = emp.Role.ToString();
            label6.Text = $"{emp.FirstName} {emp.LastName}!";
            label7.Text = DateTime.Now.ToString();
            label9.Text = emp.Branch.City;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
    }
}
