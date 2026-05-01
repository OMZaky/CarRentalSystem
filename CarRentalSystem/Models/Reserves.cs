using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalSystem.Models
{
    public class Reserves
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime ReservationDate { get; set; }

        [Required]
        public int Duration { get; set; }

        [Required]
        [MaxLength(20)]
        public ReservationStatus Status { get; set; } // E.g., "Active", "Cancelled", "Completed"

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}