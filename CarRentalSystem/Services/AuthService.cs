using System;
using System.Linq;
using CarRentalSystem.Data;
using CarRentalSystem.Models;
using CarRentalSystem.Core;

namespace CarRentalSystem.Services
{
    public class AuthService
    {
        /// <summary>
        /// Validates a user's credentials against the Azure database.
        /// Returns the Employee object if successful, or null if it fails.
        /// </summary>
        public Employee? Login(string username, string password)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    // 1. Find the user by Username
                    var user = context.Employees
                                      .FirstOrDefault(emp => emp.Username == username);

                    // 2. Verify the password hash
                    if (user != null && PasswordHasher.VerifyPassword(password, user.PasswordHash))
                    {
                        return user; // Success!
                    }

                    return null; // Invalid password
                }
            }
            catch (Exception)
            {
                // In a real app, you might log the exact error here before returning null
                return null;
            }
        }
    }
}