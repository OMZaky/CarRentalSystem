using CarRentalSystem.Models;

namespace CarRentalSystem
{
    public static class UserSession
    {
        public static Employee CurrentUser { get; set; }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}