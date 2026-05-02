using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace car_rental_system.Forms
{
    public partial class CarCardControl : UserControl
    {
        public CarCardControl(string name, string type, string seats, string transmission,
                              string branch, int price, int days, string imagePath)
        {
            InitializeComponent();

            lblName.Text = name;
            lblType.Text = type;
            lblSeats.Text = seats;
            lblTransmission.Text = transmission;
            lblBranch.Text = "Branch: " + branch;
            lblPrice.Text = price + " EGP/day";
            lblTotal.Text = (price * days) + " EGP total";

            // Load image safely
            string fullPath = Path.Combine(Application.StartupPath, imagePath);

            if (File.Exists(fullPath))
            {
                picCar.Image = Image.FromFile(fullPath);
                picCar.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                MessageBox.Show("Image not found: " + fullPath);
            }
        }

        public CarCardControl()
        {
            InitializeComponent();
        }
    }
}