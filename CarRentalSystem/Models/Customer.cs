using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalSystem.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(14)]
        public string Ssn { get; set; }

        [Required]
        [MaxLength(20)]
        public string LicenseNum { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
        public virtual ICollection<Reserves> Reservations { get; set; }
    }
}