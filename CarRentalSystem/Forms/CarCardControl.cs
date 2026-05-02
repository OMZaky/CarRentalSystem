using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CarRentalSystem.DTOs;

namespace CarRentalSystem.Forms
{
    public partial class CarCardControl : UserControl
    {
        public int VehicleId { get; private set; } // Store the ID so the "Rent Now" button knows what to book

        public event EventHandler<int> RentButtonClicked;

        public CarCardControl(CarSearchDTO car, int totalDays)
        {
            InitializeComponent();

            VehicleId = car.Id;

            // Just relying on Model and Year (e.g., "Camry 2023")
            lblName.Text = $"{car.Model} {car.Year}";

            lblType.Text = car.Category;
            lblBranch.Text = "Branch: " + car.BranchName;

            lblPrice.Text = $"{car.DailyPrice:N0} EGP/day";
            lblTotal.Text = $"{(car.DailyPrice * totalDays):N0} EGP total";


            LoadImageSafely(car.ImagePath);
        }

        private void LoadImageSafely(string imagePath)
        {
            // 2. Activated Placeholder Logic!
            // If the DB string is empty OR the file doesn't exist locally, use the default picture
            if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(Path.Combine(Application.StartupPath, imagePath)))
            {
                // NOTE: Ensure your team adds an image named "PlaceholderCar" to Properties.Resources!
                picCar.Image = Properties.Resources.PlaceholderCar;
                picCar.SizeMode = PictureBoxSizeMode.Zoom;
                return;
            }

            // 3. Safe Loading via FileStream (Prevents WinForms from locking the file)
            string fullPath = Path.Combine(Application.StartupPath, imagePath);
            using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
            {
                picCar.Image = Image.FromStream(stream);
            }
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnRentNow_Click(object sender, EventArgs e)
        {
            // 3. YELL TO THE PARENT!
            // The ? checks if the parent is actually listening. 
            // If they are, it passes the specific VehicleId up to them.
            RentButtonClicked?.Invoke(this, VehicleId);
        }
    }
}