using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalSystem.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        [MaxLength(30)]
        public string Color { get; set; }

        [Required]
        [MaxLength(20)]
        public VehicleStatus Status { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; }

        [Required]
        [MaxLength(20)]
        public string PlateNum { get; set; }


        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual VehicleCategory Category { get; set; }

        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
        public virtual ICollection<Reserves> Reservations { get; set; }
        public virtual ICollection<Inspection> Inspections { get; set; }
    }
}