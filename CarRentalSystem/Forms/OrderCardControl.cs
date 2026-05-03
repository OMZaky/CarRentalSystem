using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CarRentalSystem.DTOs;

namespace CarRentalSystem.Forms
{
    public partial class OrderCardControl : UserControl
    {
        public int OrderId { get; private set; }

        public OrderCardControl(OrderDTO order)
        {
            InitializeComponent();
            UpdateData(order);
        }

        // Added the memory cache dictionary for instant image loading
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

        public void UpdateData(OrderDTO order)
        {
            OrderId = order.OrderId;

            // Map standard strings
            CarNameLabel.Text = order.CarModel;
            TierLabel.Text = order.CarCategory;
            BranchLabel.Text = "Branch: " + order.BranchName;

            // Map Dates
            StartDate.Text = order.StartDate.ToString("MMM dd, yyyy");
            EndDate.Text = order.EndDate.ToString("MMM dd, yyyy");

            // Map Financials
            BaseCostLabel.Text = $"{order.BaseCost:N2} EGP";
            ExtraFeesLabel.Text = $"{order.ExtraFees:N2} EGP";
            TotalCostLabel.Text = $"{order.TotalCost:N2} EGP";

            // Set Payment Status Text
            PaymentStatus.Text = order.PaymentStatus;

            // ==========================================
            // PAYMENT STATUS COLORS
            // ==========================================
            if (order.PaymentStatus.Contains("Pending") || order.PaymentStatus.Contains("Refunded"))
            {
                PaymentStatus.ForeColor = Color.DodgerBlue;
            }
            else if (order.PaymentStatus.Contains("Paid"))
            {
                PaymentStatus.ForeColor = Color.MediumSeaGreen;
            }
            else if (order.PaymentStatus.Contains("Voided"))
            {
                PaymentStatus.ForeColor = Color.Red;
            }
            else
            {
                PaymentStatus.ForeColor = Color.Gray; // Fallback
            }

            // ==========================================
            // RENTAL/RESERVATION STATUS TEXT FORMATTING
            // ==========================================
            string finalStatus = order.DisplayStatus;

            // If the database accidentally passes the raw integer '0' instead of the Enum string
            if (finalStatus == "Reservation: 0" || finalStatus == "Reservation: ")
            {
                finalStatus = "Reservation: Reserved";
            }

            // Shorten the appended text so it doesn't stretch past the edge of the card
            if (finalStatus.Contains("(Ready for Pickup)"))
            {
                finalStatus = finalStatus.Replace("(Ready for Pickup)", "(Ready)");
            }

            RentalOrReservationStatus.Text = finalStatus;

            // ==========================================
            // RENTAL/RESERVATION STATUS COLORS
            // ==========================================

            // Bad/Warning States (Red)
            if (finalStatus.Contains("Overdue") || finalStatus.Contains("Cancelled") || finalStatus.Contains("NoShow"))
            {
                RentalOrReservationStatus.ForeColor = Color.Red;
            }
            // Good/Active/Finished States (Green)
            else if (finalStatus.Contains("Active") || finalStatus.Contains("Completed") || finalStatus.Contains("Fulfilled"))
            {
                RentalOrReservationStatus.ForeColor = Color.MediumSeaGreen;
            }
            // Pending/Future States (Blue)
            else if (finalStatus.Contains("Reserved"))
            {
                RentalOrReservationStatus.ForeColor = Color.DodgerBlue;
            }
            // Fallback
            else
            {
                RentalOrReservationStatus.ForeColor = Color.Gray;
            }

            // Safely trigger the image load!
            LoadImageSafely(order.ImagePath);

        }

        // Empty event handlers so the designer doesn't crash
        private void OrderCardControl_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
    }
}