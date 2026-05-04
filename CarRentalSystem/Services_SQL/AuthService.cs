using System;
using Microsoft.Data.SqlClient;
using CarRentalSystem.Core;
using CarRentalSystem.DTOs;
using CarRentalSystem.Data;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Services_SQL
{
    public class AuthService
    {
       
        public UserDTO Login(string username, string password)
        {
            try
            {
                string connectionString;
                using (var context = new AppDbContext())
                {
                    connectionString = context.Database.GetDbConnection().ConnectionString;
                }

                // 2. Open a direct pipe to the SQL Server
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    
                    string empQuery = @"
                        SELECT e.Id, e.Username, e.FirstName, e.LastName, e.Role, e.PasswordHash, b.City AS BranchCity
                        FROM Employees e
                        LEFT JOIN Branches b ON e.BranchId = b.Id
                        WHERE e.Username = @username";

                    using (SqlCommand cmd = new SqlCommand(empQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // If reader.Read() is true, it found a matching row
                            if (reader.Read())
                            {
                                string hash = reader["PasswordHash"].ToString();

                                if (PasswordHasher.VerifyPassword(password, hash))
                                {
                                    return new UserDTO
                                    {
                                        Id = Convert.ToInt32(reader["Id"]),
                                        Username = reader["Username"].ToString(),
                                        FullName = $"{reader["FirstName"]} {reader["LastName"]}",
                                        Role = (UserRole)Convert.ToInt32(reader["Role"]),
                                        // Handle null branches gracefully
                                        BranchCity = reader["BranchCity"] != DBNull.Value ? reader["BranchCity"].ToString() : "Main"
                                    };
                                }
                            }
                        }
                    }

                    // 2. CUSTOMER CHECK WITH PURE SQL
                    string custQuery = @"
                        SELECT Id, Username, FirstName, LastName, PasswordHash
                        FROM Customers
                        WHERE Username = @username";

                    using (SqlCommand cmd = new SqlCommand(custQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hash = reader["PasswordHash"].ToString();

                                if (PasswordHasher.VerifyPassword(password, hash))
                                {
                                    return new UserDTO
                                    {
                                        Id = Convert.ToInt32(reader["Id"]),
                                        Username = reader["Username"].ToString(),
                                        FullName = $"{reader["FirstName"]} {reader["LastName"]}",
                                        Role = UserRole.Customer,
                                        BranchCity = null
                                    };
                                }
                            }
                        }
                    }
                }

                // If no employee or customer was found, return null
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}