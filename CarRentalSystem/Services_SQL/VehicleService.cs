using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CarRentalSystem.Data;
using CarRentalSystem.DTOs;
using CarRentalSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Services_SQL
{
    public class VehicleService
    {
        private string GetConnectionString()
        {
            using (var context = new AppDbContext())
            {
                return context.Database.GetDbConnection().ConnectionString;
            }
        }

        public List<CarSearchDTO> SearchAvailableCars(DateTime fromDate, DateTime toDate)
        {
            var availableCars = new List<CarSearchDTO>();

            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();

                // this selects car info and makes sure its avalable and not alreaddy rented or reserved in that time  
                string query = @"
                    SELECT 
                        v.Id, v.Model, v.Year, v.ImagePath, v.PlateNum,
                        b.City AS BranchCity, 
                        c.VehicleType, c.Level, c.DailyRate
                    FROM Vehicles v
                    LEFT JOIN Branches b ON v.BranchId = b.Id
                    LEFT JOIN VehicleCategories c ON v.CategoryId = c.Id
                    WHERE v.Status = @availableStatus
                    AND v.Id NOT IN (
                        
                    
                        SELECT r.VehicleId 
                        FROM Rentals r
                        WHERE (r.Status = @rentalActive OR r.Status = @rentalOverdue)
                        AND r.PlannedStart <= @toDate 
                        AND r.PlannedReturn >= @fromDate
                        
                        UNION
                        
                        
                        SELECT res.VehicleId 
                        FROM Reservations res
                        WHERE res.Status = @resReserved
                        AND res.ReservationDate <= @toDate 
                        AND DATEADD(day, res.Duration, res.ReservationDate) >= @fromDate
                    )";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fromDate", fromDate);
                    cmd.Parameters.AddWithValue("@toDate", toDate);

                    // Cast all C# Enums to integers for SQL mapping
                    cmd.Parameters.AddWithValue("@availableStatus", (int)VehicleStatus.Available);
                    cmd.Parameters.AddWithValue("@rentalActive", (int)RentalStatus.Active);
                    cmd.Parameters.AddWithValue("@rentalOverdue", (int)RentalStatus.Overdue);
                    cmd.Parameters.AddWithValue("@resReserved", (int)ReservationStatus.Reserved);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            availableCars.Add(new CarSearchDTO
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Model = reader["Model"].ToString(),
                                Year = Convert.ToInt32(reader["Year"]),
                                ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : null,
                                BranchName = reader["BranchCity"] != DBNull.Value ? reader["BranchCity"].ToString() : "Main Branch",
                                Category = reader["VehicleType"] != DBNull.Value ? reader["VehicleType"].ToString() : "Uncategorized",
                                Level = reader["Level"] != DBNull.Value ? reader["Level"].ToString() : "Standard",
                                DailyPrice = reader["DailyRate"] != DBNull.Value ? Convert.ToDecimal(reader["DailyRate"]) : 0,
                                PlateNum = reader["PlateNum"] != DBNull.Value ? reader["PlateNum"].ToString() : "Unknown"
                            });
                        }
                    }
                }
            }

            return availableCars;
        }

        public void DeleteVehicle(int vehicleId)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();

                string query = "DELETE FROM Vehicles WHERE Id = @vehicleId";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@vehicleId", vehicleId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}