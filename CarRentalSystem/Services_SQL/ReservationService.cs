using System;
using Microsoft.Data.SqlClient;
using CarRentalSystem.Data;
using CarRentalSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Services_SQL
{
    public class ReservationService
    {
        // Helper method to grab the connection string from your existing configuration
        private string GetConnectionString()
        {
            using (var context = new AppDbContext())
            {
                return context.Database.GetDbConnection().ConnectionString;
            }
        }

        public bool CreateReservation(int customerId, int vehicleId, DateTime fromDate, DateTime toDate)
        {
            try
            {
                int totalDays = (toDate.Date - fromDate.Date).Days;
                if (totalDays <= 0) totalDays = 1;

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();

                    // Pure SQL INSERT statement
                    string query = @"
                        INSERT INTO Reservations 
                        (VehicleId, CustomerId, ReservationDate, Duration, Status) 
                        VALUES 
                        (@vehicleId, @customerId, @reservationDate, @duration, @status)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@vehicleId", vehicleId);
                        cmd.Parameters.AddWithValue("@customerId", customerId);
                        cmd.Parameters.AddWithValue("@reservationDate", fromDate);
                        cmd.Parameters.AddWithValue("@duration", totalDays);

                        // We must cast the C# Enum to an integer so SQL Server can store it properly!
                        cmd.Parameters.AddWithValue("@status", (int)ReservationStatus.Reserved);

                        // ExecuteNonQuery returns the number of rows successfully inserted
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}