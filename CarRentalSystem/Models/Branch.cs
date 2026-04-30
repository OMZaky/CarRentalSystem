using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalSystem.Models
{
    public class Branch
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string OperatingHours { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(100)]
        public string StreetName { get; set; }

        // Navigation Properties
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}