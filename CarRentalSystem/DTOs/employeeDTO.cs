using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.DTOs
{
    internal class employeeDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Hire { get; set; }
        public EmployeeRole Role { get; set; }
        public string Branch { get; set; }
        public DateTime HireDate { get; set; }
        
    }
}
