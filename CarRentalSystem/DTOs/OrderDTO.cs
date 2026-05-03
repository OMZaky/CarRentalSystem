using System;

namespace CarRentalSystem.DTOs
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public bool IsRental { get; set; } // True if Rental, False if Reservation

        public string CarModel { get; set; }
        public string CarCategory { get; set; }
        public string BranchName { get; set; }
        public string ImagePath { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public decimal BaseCost { get; set; }
        public decimal ExtraFees { get; set; }
        public decimal TotalCost => BaseCost + ExtraFees;

        public string PaymentStatus { get; set; }

        // This handles your custom logic requirement!
        public string DisplayStatus { get; set; }
    }
}