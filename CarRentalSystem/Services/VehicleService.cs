using System;
using System.Collections.Generic;
using System.Linq;
using CarRentalSystem.Data;
using CarRentalSystem.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Services
{
    public class VehicleService
    {
        public List<CarSearchDTO> SearchAvailableCars(DateTime fromDate, DateTime toDate)
        {
            using (var context = new AppDbContext())
            {
                // 1. Find all Rentals that overlap with the requested dates
                var conflictingRentals = context.Rentals
                    .AsNoTracking()
                    .Where(r => (r.Status == RentalStatus.Active || r.Status == RentalStatus.Overdue) &&
                                r.PlannedStart <= toDate &&
                                r.PlannedReturn >= fromDate)
                    .Select(r => r.VehicleId);

                // 2. Find all Reservations that overlap with the requested dates
                var conflictingReservations = context.Reservations
                    .AsNoTracking()
                    .Where(r => r.Status == ReservationStatus.Reserved &&
                                r.ReservationDate <= toDate &&
                                r.ReservationDate.AddDays(r.Duration) >= fromDate)
                    .Select(r => r.VehicleId);

                // 3. Combine them into a master list of "Busy" car IDs
                var busyVehicleIds = conflictingRentals.Concat(conflictingReservations).Distinct().ToList();

                // 4. Return all physical cars that are Available AND NOT in the busy list!
                return context.Vehicles
                    .AsNoTracking()
                    .Where(v => v.Status == VehicleStatus.Available && !busyVehicleIds.Contains(v.Id))
                    .Include(v => v.Branch)
                    .Include(v => v.Category)
                    .Select(v => new CarSearchDTO
                    {
                        Id = v.Id,
                        Model = v.Model,
                        Year = v.Year,
                        ImagePath = v.ImagePath,
                        BranchName = v.Branch != null ? v.Branch.City : "Main Branch",
                        Category = v.Category != null ? v.Category.VehicleType : "Uncategorized",
                        Level = v.Category != null ? v.Category.Level : "Standard",
                        DailyPrice = v.Category != null ? v.Category.DailyRate : 0,
                        PlateNum = v.PlateNum ?? "Unknown"
                    })
                    .ToList();
            }
        }
    }
}