using System;
using System.Collections.Generic;
using System.Linq;
using CarRentalSystem.Data;
using CarRentalSystem.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Services
{
    public class OrderService
    {
        // 1. FOR CUSTOMERS (Only gets their specific orders)
        public List<OrderDTO> GetCustomerOrders(int customerId)
        {
            using (var context = new AppDbContext())
            {
                var reserves = context.Reservations
                    .AsNoTracking()
                    .Include(r => r.Vehicle).ThenInclude(v => v.Category)
                    .Include(r => r.Vehicle).ThenInclude(v => v.Branch)
                    .Where(r => r.CustomerId == customerId)
                    .Select(r => new OrderDTO
                    {
                        OrderId = r.Id,
                        IsRental = false,
                        CarModel = r.Vehicle.Model,
                        CarCategory = r.Vehicle.Category.VehicleType,
                        BranchName = r.Vehicle.Branch.City,
                        ImagePath = r.Vehicle.ImagePath,
                        StartDate = r.ReservationDate,
                        EndDate = r.ReservationDate.AddDays(r.Duration),
                        BaseCost = r.Vehicle.Category.DailyRate * r.Duration,
                        ExtraFees = 0,
                        PaymentStatus = "Pending",
                        DisplayStatus = (r.Status == ReservationStatus.Reserved && DateTime.Now.Date >= r.ReservationDate.Date)
                                ? "Reservation: Active (Ready for Pickup)"
                                : "Reservation: " + r.Status.ToString()
                    }).ToList();

                var rentals = context.Rentals
                    .AsNoTracking()
                    .Include(r => r.Vehicle).ThenInclude(v => v.Category)
                    .Include(r => r.Branch)
                    .Where(r => r.CustomerId == customerId)
                    .Select(r => new OrderDTO
                    {
                        OrderId = r.Id,
                        IsRental = true,
                        CarModel = r.Vehicle.Model,
                        CarCategory = r.Vehicle.Category.VehicleType,
                        BranchName = r.Branch.City,
                        ImagePath = r.Vehicle.ImagePath,
                        StartDate = r.PlannedStart,
                        EndDate = r.PlannedReturn,
                        BaseCost = r.BaseCost,
                        ExtraFees = r.ExtraFees,
                        PaymentStatus = r.PaymentStatus.ToString(),
                        DisplayStatus = "Rental: " + r.Status.ToString()
                    }).ToList();

                return reserves.Concat(rentals).OrderByDescending(o => o.StartDate).ToList();
            }
        }

        // 2. FOR EMPLOYEES/ADMINS (Gets the 50 most recent orders across the whole system)
        public List<OrderDTO> GetAllGlobalOrders()
        {
            using (var context = new AppDbContext())
            {
                var reserves = context.Reservations
                    .AsNoTracking()
                    .Include(r => r.Vehicle).ThenInclude(v => v.Category)
                    .Include(r => r.Vehicle).ThenInclude(v => v.Branch)
                    .Select(r => new OrderDTO
                    {
                        OrderId = r.Id,
                        IsRental = false,
                        CarModel = r.Vehicle.Model,
                        CarCategory = r.Vehicle.Category.VehicleType,
                        BranchName = r.Vehicle.Branch.City,
                        ImagePath = r.Vehicle.ImagePath,
                        StartDate = r.ReservationDate,
                        EndDate = r.ReservationDate.AddDays(r.Duration),
                        BaseCost = r.Vehicle.Category.DailyRate * r.Duration,
                        ExtraFees = 0,
                        PaymentStatus = "Pending",
                        DisplayStatus = (r.Status == ReservationStatus.Reserved && DateTime.Now.Date >= r.ReservationDate.Date)
                            ? "Reservation: Active (Ready for Pickup)"
                            : "Reservation: " + r.Status.ToString()
                    }).ToList();

                var rentals = context.Rentals
                    .AsNoTracking()
                    .Include(r => r.Vehicle).ThenInclude(v => v.Category)
                    .Include(r => r.Branch)
                    .Select(r => new OrderDTO
                    {
                        OrderId = r.Id,
                        IsRental = true,
                        CarModel = r.Vehicle.Model,
                        CarCategory = r.Vehicle.Category.VehicleType,
                        BranchName = r.Branch.City,
                        ImagePath = r.Vehicle.ImagePath,
                        StartDate = r.PlannedStart,
                        EndDate = r.PlannedReturn,
                        BaseCost = r.BaseCost,
                        ExtraFees = r.ExtraFees,
                        PaymentStatus = r.PaymentStatus.ToString(),
                        DisplayStatus = "Rental: " + r.Status.ToString()
                    }).ToList();

                return reserves.Concat(rentals)
                               .OrderByDescending(o => o.StartDate)
                               .Take(50)
                               .ToList();
            }
        }
    }
}