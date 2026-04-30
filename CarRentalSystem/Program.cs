using System;
using System.Windows.Forms;
using CarRentalSystem.Data;

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
                // This will safely check if data exists, and if not, inject all our dummy data
                DatabaseSeeder.SeedData(context);
            }

            // Launch the Login Page
            Application.Run(new Login_Page());
        }
    }
}