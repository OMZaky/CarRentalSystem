using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalSystem.Models
{
    public class Inspection
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(0, 100)]
        public int FuelLevel { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [MaxLength(500)]
        public string Notes { get; set; }

        [Required]
        public int Mileage { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        [MaxLength(20)]
        public string Type { get; set; } // E.g., "Pre-Rental", "Post-Rental"

        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey("Rental")]
        public int RentalId { get; set; }
        public virtual Rental Rental { get; set; }
    }
}