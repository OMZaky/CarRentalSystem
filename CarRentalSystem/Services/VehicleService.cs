using System.Collections.Generic;
using System.Linq;
using CarRentalSystem.Data;
using CarRentalSystem.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Services
{
    public class VehicleService
    {
        public List<CarSearchDTO> SearchAvailableCars()
        {
            using (var context = new AppDbContext())
            {
                return context.Vehicles
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
                        DailyPrice = v.Category != null ? v.Category.DailyRate : 0

                        // Make, Seats, and Transmission have been completely removed!
                    })
                    .ToList();
            }
        }
    }
}