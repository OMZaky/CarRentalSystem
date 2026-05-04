using System;
using System.Collections.Generic;
using System.Linq;
using CarRentalSystem.Core; // Required for the PasswordHasher
using CarRentalSystem.Models;

namespace CarRentalSystem.Data
{
    public static class DatabaseSeeder
    {
        public static void SeedData(AppDbContext context)
        {
            if (context.Branches.Any()) return;

            Console.WriteLine("Seeding business-level database with secure hashes...");

            // 1. Seed Branches 
            var branches = new List<Branch>
            {
                new Branch { Name = "Cairo International Airport", City = "Cairo", StreetName = "Terminal 3 Arrivals", PhoneNumber = "01011112222", OperatingHours = "24/7" },
                new Branch { Name = "New Cairo HQ", City = "Cairo", StreetName = "90th Street, 5th Settlement", PhoneNumber = "01033334444", OperatingHours = "09:00 AM - 10:00 PM" },
                new Branch { Name = "Alexandria Sporting", City = "Alexandria", StreetName = "Abu Qir St", PhoneNumber = "01255556666", OperatingHours = "08:00 AM - 11:00 PM" }
            };
            context.Branches.AddRange(branches);
            context.SaveChanges();

            // 2. Seed Vehicle Categories
            var categories = new List<VehicleCategory>
            {
                new VehicleCategory { VehicleType = "Sedan", Level = "Economy", FuelType = "Gasoline", DailyRate = 450.00m },
                new VehicleCategory { VehicleType = "Sedan", Level = "Standard", FuelType = "Gasoline", DailyRate = 700.00m },
                new VehicleCategory { VehicleType = "SUV", Level = "Premium", FuelType = "Hybrid", DailyRate = 1200.00m },
                new VehicleCategory { VehicleType = "Luxury", Level = "VIP", FuelType = "Gasoline", DailyRate = 2500.00m }
            };
            context.VehicleCategories.AddRange(categories);
            context.SaveChanges();

            // 3. Seed Employees 
            var employees = new List<Employee>
            {
                new Employee { FirstName = "Zaky", LastName = "Admin", Ssn = "29912345678901", Email = "zaky@tripzyrentals.com", Role = EmployeeRole.SystemAdmin, Salary = 15000m, HireDate = DateTime.Now.AddYears(-2), Username = "admin_zaky", PasswordHash = PasswordHasher.HashPassword("AdminPass123!"), BranchId = branches[1].Id },
                new Employee { FirstName = "Esraa", LastName = "Mahmoud", Ssn = "29898765432109", Email = "esraa@tripzyrentals.com", Role = EmployeeRole.BranchManager, Salary = 12000m, HireDate = DateTime.Now.AddYears(-1), Username = "mgr_esraa", PasswordHash = PasswordHasher.HashPassword("ManagerPass123!"), BranchId = branches[0].Id },
                new Employee { FirstName = "Omar", LastName = "Tariq", Ssn = "30011223344556", Email = "omar@tripzyrentals.com", Role = EmployeeRole.RentalAgent, Salary = 7000m, HireDate = DateTime.Now.AddMonths(-6), Username = "agent_omar", PasswordHash = PasswordHasher.HashPassword("AgentPass123!"), BranchId = branches[0].Id },
                new Employee { FirstName = "Shahd", LastName = "Ali", Ssn = "29955443322110", Email = "shahd@tripzyrentals.com", Role = EmployeeRole.RentalAgent, Salary = 7000m, HireDate = DateTime.Now.AddMonths(-3), Username = "agent_shahd", PasswordHash = PasswordHasher.HashPassword("AgentPass123!"), BranchId = branches[2].Id }
            };
            context.Employees.AddRange(employees);
            context.SaveChanges();

            // 4. Seed Vehicles 
            var vehicles = new List<Vehicle>
            {
                new Vehicle { Model = "Toyota Corolla", Year = 2024, Color = "Silver", PlateNum = "ABC-123", Status = VehicleStatus.Available, PurchaseDate = DateTime.Now.AddMonths(-10), BranchId = branches[0].Id, CategoryId = categories[1].Id },
                new Vehicle { Model = "Nissan Sunny", Year = 2023, Color = "White", PlateNum = "XYZ-987", Status = VehicleStatus.Rented, PurchaseDate = DateTime.Now.AddMonths(-15), BranchId = branches[0].Id, CategoryId = categories[0].Id },
                new Vehicle { Model = "Kia Sportage", Year = 2024, Color = "Black", PlateNum = "KSA-555", Status = VehicleStatus.Available, PurchaseDate = DateTime.Now.AddMonths(-5), BranchId = branches[1].Id, CategoryId = categories[2].Id },
                new Vehicle { Model = "Mercedes C180", Year = 2025, Color = "Navy Blue", PlateNum = "VIP-1", Status = VehicleStatus.Available, PurchaseDate = DateTime.Now.AddMonths(-1), BranchId = branches[0].Id, CategoryId = categories[3].Id },
                new Vehicle { Model = "Hyundai Elantra", Year = 2023, Color = "Red", PlateNum = "LMN-456", Status = VehicleStatus.Maintenance, PurchaseDate = DateTime.Now.AddMonths(-20), BranchId = branches[2].Id, CategoryId = categories[1].Id },
                new Vehicle { Model = "MG 5", Year = 2024, Color = "White", PlateNum = "DEF-789", Status = VehicleStatus.Available, PurchaseDate = DateTime.Now.AddMonths(-8), BranchId = branches[2].Id, CategoryId = categories[0].Id },
                new Vehicle { Model = "Jeep Grand Cherokee", Year = 2023, Color = "Black", PlateNum = "JEP-007", Status = VehicleStatus.Rented, PurchaseDate = DateTime.Now.AddMonths(-18), BranchId = branches[1].Id, CategoryId = categories[2].Id },
                new Vehicle { Model = "Skoda Octavia", Year = 2024, Color = "Grey", PlateNum = "SKD-321", Status = VehicleStatus.Maintenance, PurchaseDate = DateTime.Now.AddMonths(-6), BranchId = branches[1].Id, CategoryId = categories[1].Id },
                new Vehicle { Model = "BMW 520i", Year = 2024, Color = "White", PlateNum = "BMW-999", Status = VehicleStatus.Rented, PurchaseDate = DateTime.Now.AddMonths(-4), BranchId = branches[0].Id, CategoryId = categories[3].Id },
                new Vehicle { Model = "Renault Logan", Year = 2022, Color = "Blue", PlateNum = "RNT-111", Status = VehicleStatus.Available, PurchaseDate = DateTime.Now.AddMonths(-30), BranchId = branches[2].Id, CategoryId = categories[0].Id }
            };
            context.Vehicles.AddRange(vehicles);
            context.SaveChanges();

            // 5. Seed Customers 
            var customers = new List<Customer>
            {
                new Customer { FirstName = "Karim", LastName = "Hassan", Email = "karim.h@gmail.com", PhoneNumber = "01099998888", Ssn = "29501011234567", LicenseNum = "LIC-1001", ExpirationDate = DateTime.Now.AddYears(3), Username = "karim_h", PasswordHash = PasswordHasher.HashPassword("CustPass123!") },
                new Customer { FirstName = "Nour", LastName = "Ibrahim", Email = "nour.ib@yahoo.com", PhoneNumber = "01122223333", Ssn = "29705057654321", LicenseNum = "LIC-1002", ExpirationDate = DateTime.Now.AddYears(1), Username = "nouribrahim", PasswordHash = PasswordHasher.HashPassword("CustPass123!") },
                new Customer { FirstName = "Youssef", LastName = "Kamal", Email = "ykamal@outlook.com", PhoneNumber = "01244445555", Ssn = "29012129876543", LicenseNum = "LIC-1003", ExpirationDate = DateTime.Now.AddYears(5), Username = "youssef_k", PasswordHash = PasswordHasher.HashPassword("CustPass123!") }
            };
            context.Customers.AddRange(customers);
            context.SaveChanges();

            // 6. Seed Active & Completed Rentals
            var rentals = new List<Rental>
            {
                new Rental { Tier = "Standard", PlannedStart = DateTime.Now.AddDays(-10), PlannedReturn = DateTime.Now.AddDays(-7), ActualReturnDate = DateTime.Now.AddDays(-7), PaymentStatus = PaymentStatus.Paid, BaseCost = 1350.00m, ExtraFees = 0.00m, CustomerId = customers[0].Id, VehicleId = vehicles[0].Id, BranchId = branches[0].Id },
                new Rental { Tier = "Premium", PlannedStart = DateTime.Now.AddDays(-2), PlannedReturn = DateTime.Now.AddDays(3), ActualReturnDate = null, PaymentStatus = PaymentStatus.Pending, BaseCost = 6000.00m, ExtraFees = 0.00m, CustomerId = customers[1].Id, VehicleId = vehicles[6].Id, BranchId = branches[1].Id },
                new Rental { Tier = "VIP", PlannedStart = DateTime.Now.AddDays(-1), PlannedReturn = DateTime.Now.AddDays(1), ActualReturnDate = null, PaymentStatus = PaymentStatus.Refunded, BaseCost = 5000.00m, ExtraFees = 0.00m, CustomerId = customers[2].Id, VehicleId = vehicles[8].Id, BranchId = branches[0].Id }
            };
            context.Rentals.AddRange(rentals);
            context.SaveChanges();
        }
    }
}