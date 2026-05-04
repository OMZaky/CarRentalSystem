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

        private static Dictionary<string, Bitmap> _imageCache = new Dictionary<string, Bitmap>();

        private void LoadImageSafely(string imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                if (!_imageCache.ContainsKey("PLACEHOLDER"))
                    _imageCache["PLACEHOLDER"] = Properties.Resources.PlaceholderCar; 

                picCar.Image = _imageCache["PLACEHOLDER"];
                picCar.SizeMode = PictureBoxSizeMode.Zoom;
                return;
            }

            string fullPath = System.IO.Path.Combine(Application.StartupPath, imagePath);

            if (_imageCache.ContainsKey(fullPath))
            {
                picCar.Image = _imageCache[fullPath];
                picCar.SizeMode = PictureBoxSizeMode.Zoom;
                return;
            }

            if (!System.IO.File.Exists(fullPath))
            {
                if (!_imageCache.ContainsKey("PLACEHOLDER"))
                    _imageCache["PLACEHOLDER"] = Properties.Resources.PlaceholderCar;

                picCar.Image = _imageCache["PLACEHOLDER"];
                picCar.SizeMode = PictureBoxSizeMode.Zoom;
                return;
            }

            using (var stream = new System.IO.FileStream(fullPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
            using (var tempImage = Image.FromStream(stream))
            {
                var optimizedBitmap = new Bitmap(tempImage);
                _imageCache[fullPath] = optimizedBitmap;
                picCar.Image = optimizedBitmap;
            }
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public void UpdateData(CarSearchDTO car, int totalDays)
        {
            VehicleId = car.Id;

            lblName.Text = $"{car.Model} {car.Year}";
            lblType.Text = car.Category;
            lblBranch.Text = "Branch: " + car.BranchName;
            lblPrice.Text = $"{car.DailyPrice:N0} EGP/day";
            lblTotal.Text = $"{(car.DailyPrice * totalDays):N0} EGP total";

            LoadImageSafely(car.ImagePath);
        }

        private void btnRentNow_Click(object sender, EventArgs e)
        {
            RentButtonClicked?.Invoke(this, VehicleId);
        }
    }
}