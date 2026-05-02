using System.Linq;
using CarRentalSystem.Data;
using CarRentalSystem.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Services
{
    public class CustomerService
    {
        public CustomerProfileDTO GetProfile(int customerId)
        {
            using (var context = new AppDbContext())
            {
                var customer = context.Customers
                    .Include(c => c.Rentals)
                    .Include(c => c.Reservations)
                    .FirstOrDefault(c => c.Id == customerId);

                if (customer == null) return null;

                return new CustomerProfileDTO
                {
                    Id = customer.Id,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Email = customer.Email,
                    PhoneNumber = customer.PhoneNumber,
                    Ssn = customer.Ssn,
                    Username = customer.Username,
                    LicenseNum = customer.LicenseNum,
                    ExpirationDate = customer.ExpirationDate,
                    TotalRentals = customer.Rentals?.Count ?? 0,
                    ActiveReservations = customer.Reservations?.Count ?? 0,

                    // If the actual return date is null, they still have the car!
                    CurrentlyRenting = customer.Rentals?.Count(r => r.ActualReturnDate == null) ?? 0
                };
            }
        }

        public bool UpdateContactInfo(int customerId, string first, string last, string email, string phone)
        {
            using (var context = new AppDbContext())
            {
                var customer = context.Customers.Find(customerId);
                if (customer == null) return false;

                customer.FirstName = first;
                customer.LastName = last;
                customer.Email = email;
                customer.PhoneNumber = phone;

                context.SaveChanges();
                return true;
            }
        }

        public bool UpdatePassword(int customerId, string newPasswordHash)
        {
            using (var context = new AppDbContext())
            {
                var customer = context.Customers.Find(customerId);
                if (customer == null) return false;

                customer.PasswordHash = newPasswordHash;
                context.SaveChanges();
                return true;
            }
        }
    }
}