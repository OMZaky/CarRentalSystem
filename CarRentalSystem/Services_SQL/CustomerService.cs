using System;
using Microsoft.Data.SqlClient;
using CarRentalSystem.Data;
using CarRentalSystem.DTOs;
using CarRentalSystem.Core;
using Microsoft.EntityFrameworkCore;

namespace CarRentalSystem.Services_SQL
{
    public class CustomerService
    {
        private string GetConnectionString()
        {
            using (var context = new AppDbContext())
            {
                return context.Database.GetDbConnection().ConnectionString;
            }
        }

        

        public CustomerProfileDTO GetProfile(int customerId)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();

                    // We use SQL Subqueries to count the rentals and reservations instantly 
                    string query = @"
                        SELECT 
                            c.Id, c.FirstName, c.LastName, c.Email, c.PhoneNumber, 
                            c.Ssn, c.Username, c.LicenseNum, c.ExpirationDate,
                            (SELECT COUNT(*) FROM Rentals WHERE CustomerId = c.Id) AS TotalRentals,
                            (SELECT COUNT(*) FROM Reservations WHERE CustomerId = c.Id) AS ActiveReservations,
                            (SELECT COUNT(*) FROM Rentals WHERE CustomerId = c.Id AND ActualReturnDate IS NULL) AS CurrentlyRenting
                        FROM Customers c
                        WHERE c.Id = @customerId";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customerId", customerId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new CustomerProfileDTO
                                {
                                    Id = Convert.ToInt32(reader["Id"]),
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    PhoneNumber = reader["PhoneNumber"].ToString(),
                                    Ssn = reader["Ssn"].ToString(),
                                    Username = reader["Username"].ToString(),
                                    LicenseNum = reader["LicenseNum"].ToString(),
                                    ExpirationDate = Convert.ToDateTime(reader["ExpirationDate"]),
                                    TotalRentals = Convert.ToInt32(reader["TotalRentals"]),
                                    ActiveReservations = Convert.ToInt32(reader["ActiveReservations"]),
                                    CurrentlyRenting = Convert.ToInt32(reader["CurrentlyRenting"])
                                };
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool UpdateContactInfo(int customerId, string first, string last, string email, string phone)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = @"
                        UPDATE Customers 
                        SET FirstName = @first, LastName = @last, Email = @email, PhoneNumber = @phone 
                        WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first", first);
                        cmd.Parameters.AddWithValue("@last", last);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@id", customerId);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdatePassword(int customerId, string newPasswordHash)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = "UPDATE Customers SET PasswordHash = @hash WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@hash", newPasswordHash);
                        cmd.Parameters.AddWithValue("@id", customerId);

                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

       

        public bool IsUsernameTaken(string username)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    // Using LOWER() in SQL to ensure case-insensitive matching
                    string query = "SELECT 1 FROM Customers WHERE LOWER(Username) = LOWER(@username)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);

                        var result = cmd.ExecuteScalar();
                        return result != null;
                    }
                }
            }
            catch (Exception)
            {
                return true;
            }
        }

        public bool IsEmailTaken(string email)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT 1 FROM Customers WHERE LOWER(Email) = LOWER(@email)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        var result = cmd.ExecuteScalar();
                        return result != null;
                    }
                }
            }
            catch (Exception)
            {
                return true;
            }
        }

        public bool RegisterCustomer(RegistrationDTO baseData, string phone, string ssn, string licenseNum, DateTime expiryDate)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    string query = @"
                        INSERT INTO Customers 
                        (FirstName, LastName, Username, Email, PasswordHash, PhoneNumber, Ssn, LicenseNum, ExpirationDate) 
                        VALUES 
                        (@first, @last, @username, @email, @hash, @phone, @ssn, @license, @expiry)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first", baseData.FirstName);
                        cmd.Parameters.AddWithValue("@last", baseData.LastName);
                        cmd.Parameters.AddWithValue("@username", baseData.Username);
                        cmd.Parameters.AddWithValue("@email", baseData.Email);
                        cmd.Parameters.AddWithValue("@hash", PasswordHasher.HashPassword(baseData.Password));
                        cmd.Parameters.AddWithValue("@phone", phone);
                        cmd.Parameters.AddWithValue("@ssn", ssn);
                        cmd.Parameters.AddWithValue("@license", licenseNum);
                        cmd.Parameters.AddWithValue("@expiry", expiryDate);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}