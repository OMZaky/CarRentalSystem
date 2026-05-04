using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using CarRentalSystem.Data;
using CarRentalSystem.DTOs;
using CarRentalSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Services_SQL
{
    public class OrderService
    {
        private string GetConnectionString()
        {
            using (var context = new AppDbContext())
            {
                return context.Database.GetDbConnection().ConnectionString;
            }
        }

        // 1. FOR CUSTOMERS (Only gets their specific orders)
        public List<OrderDTO> GetCustomerOrders(int customerId)
        {
            var reserves = new List<OrderDTO>();
            var rentals = new List<OrderDTO>();

            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();

                
                string resQuery = @"
                    SELECT 
                        r.Id, v.Model, c.VehicleType, b.City AS BranchCity, v.ImagePath, 
                        r.ReservationDate, r.Duration, c.DailyRate, r.Status
                    FROM Reservations r
                    LEFT JOIN Vehicles v ON r.VehicleId = v.Id
                    LEFT JOIN VehicleCategories c ON v.CategoryId = c.Id
                    LEFT JOIN Branches b ON v.BranchId = b.Id
                    WHERE r.CustomerId = @customerId";

                using (SqlCommand cmd = new SqlCommand(resQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime resDate = Convert.ToDateTime(reader["ReservationDate"]);
                            int duration = Convert.ToInt32(reader["Duration"]);
                            decimal dailyRate = Convert.ToDecimal(reader["DailyRate"]);

                            var statusEnum = (ReservationStatus)Convert.ToInt32(reader["Status"]);

                            reserves.Add(new OrderDTO
                            {
                                OrderId = Convert.ToInt32(reader["Id"]),
                                IsRental = false,
                                CarModel = reader["Model"].ToString(),
                                CarCategory = reader["VehicleType"].ToString(),
                                BranchName = reader["BranchCity"].ToString(),
                                ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : null,
                                StartDate = resDate,
                                EndDate = resDate.AddDays(duration),
                                BaseCost = dailyRate * duration,
                                ExtraFees = 0,
                                PaymentStatus = "Pending",
                                DisplayStatus = (statusEnum == ReservationStatus.Reserved && DateTime.Now.Date >= resDate.Date)
                                        ? "Reservation: Active (Ready for Pickup)"
                                        : "Reservation: " + statusEnum.ToString()
                            });
                        }
                    }
                }

                string rentQuery = @"
                    SELECT 
                        r.Id, v.Model, c.VehicleType, b.City AS BranchCity, v.ImagePath, 
                        r.PlannedStart, r.PlannedReturn, r.BaseCost, r.ExtraFees, r.PaymentStatus, r.Status
                    FROM Rentals r
                    LEFT JOIN Vehicles v ON r.VehicleId = v.Id
                    LEFT JOIN VehicleCategories c ON v.CategoryId = c.Id
                    LEFT JOIN Branches b ON r.BranchId = b.Id
                    WHERE r.CustomerId = @customerId";

                using (SqlCommand cmd = new SqlCommand(rentQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var payStatusEnum = (PaymentStatus)Convert.ToInt32(reader["PaymentStatus"]);
                            var rentStatusEnum = (RentalStatus)Convert.ToInt32(reader["Status"]);

                            rentals.Add(new OrderDTO
                            {
                                OrderId = Convert.ToInt32(reader["Id"]),
                                IsRental = true,
                                CarModel = reader["Model"].ToString(),
                                CarCategory = reader["VehicleType"].ToString(),
                                BranchName = reader["BranchCity"].ToString(),
                                ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : null,
                                StartDate = Convert.ToDateTime(reader["PlannedStart"]),
                                EndDate = Convert.ToDateTime(reader["PlannedReturn"]),
                                BaseCost = Convert.ToDecimal(reader["BaseCost"]),
                                ExtraFees = Convert.ToDecimal(reader["ExtraFees"]),
                                PaymentStatus = payStatusEnum.ToString(),
                                DisplayStatus = "Rental: " + rentStatusEnum.ToString()
                            });
                        }
                    }
                }
            }

            return reserves.Concat(rentals).OrderByDescending(o => o.StartDate).ToList();
        }

        public List<OrderDTO> GetAllGlobalOrders()
        {
            var reserves = new List<OrderDTO>();
            var rentals = new List<OrderDTO>();

            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();

                string resQuery = @"
                    SELECT TOP 50
                        r.Id, v.Model, c.VehicleType, b.City AS BranchCity, v.ImagePath, 
                        r.ReservationDate, r.Duration, c.DailyRate, r.Status
                    FROM Reservations r
                    LEFT JOIN Vehicles v ON r.VehicleId = v.Id
                    LEFT JOIN VehicleCategories c ON v.CategoryId = c.Id
                    LEFT JOIN Branches b ON v.BranchId = b.Id
                    ORDER BY r.ReservationDate DESC";

                using (SqlCommand cmd = new SqlCommand(resQuery, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime resDate = Convert.ToDateTime(reader["ReservationDate"]);
                            int duration = Convert.ToInt32(reader["Duration"]);
                            decimal dailyRate = Convert.ToDecimal(reader["DailyRate"]);
                            var statusEnum = (ReservationStatus)Convert.ToInt32(reader["Status"]);

                            reserves.Add(new OrderDTO
                            {
                                OrderId = Convert.ToInt32(reader["Id"]),
                                IsRental = false,
                                CarModel = reader["Model"].ToString(),
                                CarCategory = reader["VehicleType"].ToString(),
                                BranchName = reader["BranchCity"].ToString(),
                                ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : null,
                                StartDate = resDate,
                                EndDate = resDate.AddDays(duration),
                                BaseCost = dailyRate * duration,
                                ExtraFees = 0,
                                PaymentStatus = "Pending",
                                DisplayStatus = (statusEnum == ReservationStatus.Reserved && DateTime.Now.Date >= resDate.Date)
                                    ? "Reservation: Active (Ready for Pickup)"
                                    : "Reservation: " + statusEnum.ToString()
                            });
                        }
                    }
                }

                // top 50 keeps the memory footprint tiny and the app extremely fast
                string rentQuery = @"
                    SELECT TOP 50
                        r.Id, v.Model, c.VehicleType, b.City AS BranchCity, v.ImagePath, 
                        r.PlannedStart, r.PlannedReturn, r.BaseCost, r.ExtraFees, r.PaymentStatus, r.Status
                    FROM Rentals r
                    LEFT JOIN Vehicles v ON r.VehicleId = v.Id
                    LEFT JOIN VehicleCategories c ON v.CategoryId = c.Id
                    LEFT JOIN Branches b ON r.BranchId = b.Id
                    ORDER BY r.PlannedStart DESC";

                using (SqlCommand cmd = new SqlCommand(rentQuery, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var payStatusEnum = (PaymentStatus)Convert.ToInt32(reader["PaymentStatus"]);
                            var rentStatusEnum = (RentalStatus)Convert.ToInt32(reader["Status"]);

                            rentals.Add(new OrderDTO
                            {
                                OrderId = Convert.ToInt32(reader["Id"]),
                                IsRental = true,
                                CarModel = reader["Model"].ToString(),
                                CarCategory = reader["VehicleType"].ToString(),
                                BranchName = reader["BranchCity"].ToString(),
                                ImagePath = reader["ImagePath"] != DBNull.Value ? reader["ImagePath"].ToString() : null,
                                StartDate = Convert.ToDateTime(reader["PlannedStart"]),
                                EndDate = Convert.ToDateTime(reader["PlannedReturn"]),
                                BaseCost = Convert.ToDecimal(reader["BaseCost"]),
                                ExtraFees = Convert.ToDecimal(reader["ExtraFees"]),
                                PaymentStatus = payStatusEnum.ToString(),
                                DisplayStatus = "Rental: " + rentStatusEnum.ToString()
                            });
                        }
                    }
                }
            }

            // We combine the top 50 from both, sort them, and then Take 50 to get the absolute newest records
            return reserves.Concat(rentals)
                           .OrderByDescending(o => o.StartDate)
                           .Take(50)
                           .ToList();
        }
    }
}