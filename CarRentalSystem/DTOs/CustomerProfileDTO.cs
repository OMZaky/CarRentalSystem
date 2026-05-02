namespace CarRentalSystem.DTOs
{
    public class CustomerProfileDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Ssn { get; set; }
        public string Username { get; set; }
        public string LicenseNum { get; set; }
        public DateTime ExpirationDate { get; set; }

        // Stats calculated safely by the backend
        public int TotalRentals { get; set; }
        public int ActiveReservations { get; set; }
        public int CurrentlyRenting { get; set; }
    }
}