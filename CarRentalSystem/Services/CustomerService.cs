using System;
using System.Linq;
using CarRentalSystem.Data;
using CarRentalSystem.DTOs;
using CarRentalSystem.Models; // Required to recognize the 'Customer' table
using Microsoft.EntityFrameworkCore;
using CarRentalSystem.Core; // Added to access PasswordHasher

namespace CarRentalSystem.Services
{
    public class CustomerService
    {
        // ==========================================
        // PROFILE & ACCOUNT MANAGEMENT
        // ==========================================

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

        // ==========================================
        // REGISTRATION METHODS
        // ==========================================

        public bool IsUsernameTaken(string username)
        {
            using (var context = new AppDbContext())
            {
                return context.Customers.Any(c => c.Username.ToLower() == username.ToLower());
            }
        }

        public bool IsEmailTaken(string email)
        {
            using (var context = new AppDbContext())
            {
                return context.Customers.Any(c => c.Email.ToLower() == email.ToLower());
            }
        }

        public bool RegisterCustomer(RegistrationDTO baseData, string phone, string ssn, string licenseNum, DateTime expiryDate)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var newCustomer = new Customer
                    {
                        FirstName = baseData.FirstName,
                        LastName = baseData.LastName,
                        Username = baseData.Username,
                        Email = baseData.Email,

                        PasswordHash = PasswordHasher.HashPassword(baseData.Password),

                        PhoneNumber = phone,
                        Ssn = ssn,
                        LicenseNum = licenseNum,
                        ExpirationDate = expiryDate
                    };

                    context.Customers.Add(newCustomer);
                    context.SaveChanges();

                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}