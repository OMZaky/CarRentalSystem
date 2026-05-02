using CarRentalSystem.Models;

namespace CarRentalSystem.Core
{
    public static class UserSession
    {
        public static IUser CurrentUser { get; set; }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}