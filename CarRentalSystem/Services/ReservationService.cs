using System;
using CarRentalSystem.Data;
using CarRentalSystem.Models;

namespace CarRentalSystem.Services
{
    public class ReservationService
    {
        public bool CreateReservation(int customerId, int vehicleId, DateTime fromDate, DateTime toDate)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    int totalDays = (toDate - fromDate).Days;

                    var newReservation = new Reserves
                    {
                        VehicleId = vehicleId,
                        CustomerId = customerId,
                        ReservationDate = fromDate,
                        Duration = totalDays,
                        Status = ReservationStatus.Reserved
                    };

                    context.Reservations.Add(newReservation);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                // TODO: Log the database error
                return false;
            }
        }
    }
}