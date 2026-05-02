namespace CarRentalSystem.DTOs
{
    // The strict Enum for role-based access
    public enum UserRole
    {
        SystemAdmin,
        BranchManager,
        RentalAgent,
        Customer
    }

    public class UserDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }

        public string BranchCity {  get; set; }
        public UserRole Role { get; set; }

    }
}