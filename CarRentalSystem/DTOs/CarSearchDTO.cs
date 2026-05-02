namespace CarRentalSystem.DTOs
{
    public class CarSearchDTO
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Category { get; set; }
        public decimal DailyPrice { get; set; }
        public string Level { get; set; }
        public string BranchName { get; set; }
        public string ImagePath { get; set; }
        public string PlateNum { get; set; }
    }
}