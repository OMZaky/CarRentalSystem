using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration; // Critical for appsettings
using CarRentalSystem.Models; // Replace with your actual Models namespace if different

namespace CarRentalSystem.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<VehicleCategory> VehicleCategories { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Reserves> Reservations { get; set; }
        public DbSet<Inspection> Inspections { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // This ensures the tool looks in the actual project directory
                var basePath = AppContext.BaseDirectory;

                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(basePath)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                string connectionString = configuration.GetConnectionString("AzureDbConnection");

                // Safety check to give you a clear error message if the string is missing
                if (string.IsNullOrEmpty(connectionString))
                {
                    throw new Exception("Could not find 'AzureDbConnection' in appsettings.json. Check the file name and 'Copy to Output' property.");
                }

                optionsBuilder.UseSqlServer(connectionString, sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5, // It will try 5 times before failing completely
                        maxRetryDelay: TimeSpan.FromSeconds(30), // It will wait up to 30 seconds between tries
                        errorNumbersToAdd: null);
                });
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Globally disable Cascade Delete for all relationships
            // This prevents the "multiple cascade paths" error and protects your data
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}