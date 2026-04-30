using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalSystem.Models
{
    public class VehicleCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string VehicleType { get; set; }

        [Required]
        [MaxLength(50)]
        public string Level { get; set; }

        [Required]
        [MaxLength(30)]
        public string FuelType { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DailyRate { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}