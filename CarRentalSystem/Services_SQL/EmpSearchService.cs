using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CarRentalSystem.Data;
using CarRentalSystem.DTOs;
using CarRentalSystem.Models;
using Microsoft.EntityFrameworkCore;
using CarRentalSystem.Core;

namespace CarRentalSystem.Services_SQL
{
    internal class EmpSearchService
    {
        private string GetConnectionString()
        {
            using (var context = new AppDbContext())
            {
                return context.Database.GetDbConnection().ConnectionString;
            }
        }

        public List<employeeDTO> SearchEmployees()
        {
            var employees = new List<employeeDTO>();

            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();

                // SQL LEFT JOIN to explicitly map the Branch City to the Employee
                string query = @"
                    SELECT 
                        e.Id, e.FirstName, e.LastName, e.Role, e.Email, e.HireDate, 
                        b.City AS BranchCity
                    FROM Employees e
                    LEFT JOIN Branches b ON e.BranchId = b.Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // reader.Read() loops through every row returned
                        while (reader.Read())
                        {
                            employees.Add(new employeeDTO
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                FullName = $"{reader["FirstName"]} {reader["LastName"]}",
                                Branch = reader["BranchCity"] != DBNull.Value ? reader["BranchCity"].ToString() : "Main Branch",
                                Role = (EmployeeRole)Convert.ToInt32(reader["Role"]),
                                Email = reader["Email"].ToString(),
                                HireDate = Convert.ToDateTime(reader["HireDate"])
                            });
                        }
                    }
                }
            }

            return employees;
        }

        public List<Branch> GetBranches()
        {
            var branches = new List<Branch>();

            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();
                string query = "SELECT Id, City FROM Branches";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            branches.Add(new Branch
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                City = reader["City"].ToString()
                            });
                        }
                    }
                }
            }

            return branches;
        }

        public Employee AddNewEmployee(Employee emp)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();

                string query = @"
                    INSERT INTO Employees 
                    (FirstName, LastName, Username, Email, PasswordHash, PhoneNumber, Ssn, Role, HireDate, BranchId)
                    OUTPUT INSERTED.Id
                    VALUES 
                    (@first, @last, @username, @email, @hash, @phone, @ssn, @role, @hireDate, @branchId)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@first", emp.FirstName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@last", emp.LastName ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@username", emp.Username ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@email", emp.Email ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@hash", emp.PasswordHash ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@ssn", emp.Ssn ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@role", (int)emp.Role);
                    cmd.Parameters.AddWithValue("@hireDate", emp.HireDate);
                    cmd.Parameters.AddWithValue("@branchId", emp.BranchId);

                    // ExecuteScalar grabs that OUTPUT INSERTED.Id so we can attach it to the object
                    int newId = (int)cmd.ExecuteScalar();
                    emp.Id = newId;
                }
            }

            return emp;
        }

        public void DeleteEmployee(int id)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectionString()))
            {
                conn.Open();

                string query = "DELETE FROM Employees WHERE Id = @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}