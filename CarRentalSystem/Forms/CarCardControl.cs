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
            // 1. FAST CACHE CHECK FOR PLACEHOLDER
            if (string.IsNullOrWhiteSpace(imagePath))
            {
                if (!_imageCache.ContainsKey("PLACEHOLDER"))
                    _imageCache["PLACEHOLDER"] = Properties.Resources.PlaceholderCar; // Load once!

                picCar.Image = _imageCache["PLACEHOLDER"];
                picCar.SizeMode = PictureBoxSizeMode.Zoom;
                return;
            }

            string fullPath = System.IO.Path.Combine(Application.StartupPath, imagePath);

            // 2. CHECK RAM FIRST (Bypasses the slow hard-drive check completely!)
            if (_imageCache.ContainsKey(fullPath))
            {
                picCar.Image = _imageCache[fullPath];
                picCar.SizeMode = PictureBoxSizeMode.Zoom;
                return;
            }

            // 3. ONLY CHECK HARD DRIVE IF IT IS NOT IN RAM YET
            if (!System.IO.File.Exists(fullPath))
            {
                if (!_imageCache.ContainsKey("PLACEHOLDER"))
                    _imageCache["PLACEHOLDER"] = Properties.Resources.PlaceholderCar;

                picCar.Image = _imageCache["PLACEHOLDER"];
                picCar.SizeMode = PictureBoxSizeMode.Zoom;
                return;
            }

            // 4. LOAD AND CACHE THE REAL IMAGE
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

            // Because we added the static Dictionary cache earlier, 
            // swapping the image here takes 0.001 seconds!
            LoadImageSafely(car.ImagePath);
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