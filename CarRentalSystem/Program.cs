using CarRentalSystem.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Windows.Forms;

namespace CarRentalSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Trigger the Database Seeder
            using (var context = new AppDbContext())
            {

                context.Database.Migrate();
                // This will safely check if data exists, and if not, inject all our dummy data
                DatabaseSeeder.SeedData(context);
            }

            // Launch the Login Page
            Application.Run(new Login_Page());
        }
    }
}