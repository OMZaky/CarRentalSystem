using CarRentalSystem.DTOs;

namespace CarRentalSystem.Core
{
    public static class UserSession
    {
        public static UserDTO CurrentUser { get; private set; }

        public static bool IsLoggedIn => CurrentUser != null;

        public static void Login(UserDTO user)
        {
            CurrentUser = user;
        }

        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}