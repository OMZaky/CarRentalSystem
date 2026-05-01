using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalSystem.Models
{
    public class Rental
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Tier { get; set; } // Standard or Premium contract tier

        [Required]
        public DateTime PlannedStart { get; set; }

        [Required]
        public DateTime PlannedReturn { get; set; }

        public DateTime? ActualReturnDate { get; set; }

        [Required]
        [MaxLength(20)]
        public PaymentStatus PaymentStatus { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal BaseCost { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ExtraFees { get; set; }

        [NotMapped]
        public decimal TotalCost => BaseCost + ExtraFees;

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; }

        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        public virtual ICollection<Inspection> Inspections { get; set; }


        public RentalStatus Status { get; set; }
    }
}