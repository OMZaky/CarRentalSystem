using System;
using System.Linq;
using CarRentalSystem.Data;
using CarRentalSystem.Models;
using CarRentalSystem.Core;
using CarRentalSystem.DTOs; // Added to access UserDTO
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Services
{
    public class AuthService
    {
        /// <summary>
        /// Validates a user's credentials against the Azure database.
        /// Returns a unified UserDTO if successful, or null if it fails.
        /// </summary>
        public UserDTO Login(string username, string password)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var employee = context.Employees
                                          .Include(emp => emp.Branch)
                                          .FirstOrDefault(emp => emp.Username == username);

                    if (employee != null && PasswordHasher.VerifyPassword(password, employee.PasswordHash))
                    {
                        return new UserDTO
                        {
                            Id = employee.Id,
                            Username = employee.Username,
                            FullName = $"{employee.FirstName} {employee.LastName}",
                            // Because the names match exactly, you can just cast it:
                            Role = (UserRole)employee.Role,
                            BranchCity = employee.Branch?.City ?? "Main"
                        };
                    }

                    var customer = context.Customers
                                          .FirstOrDefault(c => c.Username == username);

                    if (customer != null && PasswordHasher.VerifyPassword(password, customer.PasswordHash))
                    {
                        return new UserDTO
                        {
                            Id = customer.Id,
                            Username = customer.Username,
                            FullName = $"{customer.FirstName} {customer.LastName}",
                            Role = UserRole.Customer,
                            BranchCity = null
                        };
                    }

                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}