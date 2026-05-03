using CarRentalSystem.Data;
using CarRentalSystem.DTOs;
using CarRentalSystem.Models;
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
                        FullName = emp.FirstName + " " + emp.LastName,
                        Branch = emp.Branch != null ? emp.Branch.City : "Main Branch",
                        Role = emp.Role,
                        Email = emp.Email,
                        HireDate = emp.HireDate

                    })
                    .ToList();
            }
        }

        public List<Branch> GetBranches()
        {
            using (var context = new AppDbContext())
            {
                return context.Branches.ToList();
            }
        }

        public Employee AddNewEmployee(Employee emp)
        {
            using (var context = new AppDbContext())
            {
                context.Employees.Add(emp);
                context.SaveChanges();

                return emp;
            }
        }

        public void DeleteEmployee(int id)
        {
            using (var context = new AppDbContext())
            {
                var emp = context.Employees.Find(id);
                if (emp != null)
                {
                    context.Employees.Remove(emp);
                    context.SaveChanges();
                }
            }
        }

    }
}
