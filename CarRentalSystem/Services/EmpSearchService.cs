using CarRentalSystem.Data;
using CarRentalSystem.DTOs;
using Microsoft.EntityFrameworkCore;


namespace CarRentalSystem.Services
{
    internal class EmpSearchService
    {
    public List<employeeDTO> SearchEmployees()
        {
            using (var context = new AppDbContext())
            {
                return context.Employees
                    .Include(emp => emp.Branch)
                    .Select(emp => new employeeDTO
                    {
                        Id = emp.Id,
                        FullName = $"{emp.FirstName} {emp.LastName}",
                        Branch = emp.Branch != null ? emp.Branch.City : "Main Branch",
                        Role = emp.Role,
                        Email = emp.Email,
                        HireDate = emp.HireDate

                    })
                    .ToList();
            }
        }

    }
}
