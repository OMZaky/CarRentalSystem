🚗 Car Rental Management System

A high-performance, enterprise-grade desktop application designed to streamline vehicle rentals, reservations, and customer management. Built with a focus on database optimization, secure architecture, and clean data separation.

✨ Key Features

Role-Based Access Control (RBAC): Distinct dashboards and permissions for Customers, Employees, and Administrators.

Real-Time Availability Engine: A highly optimized search engine that prevents double-booking by calculating overlapping rental and reservation dates dynamically at the database level.

Secure Authentication: Implementation of industry-standard PBKDF2 password hashing to protect customer and employee credentials.

Unified Order Tracking: Seamlessly integrates future reservations and active rentals into unified timelines for both customers and branch managers.

Data Transfer Objects (DTOs): Strict separation of concerns using DTOs to securely pass data between the database services and the UI, ensuring sensitive information (like SSNs and password hashes) never leaks to the presentation layer.

🛠️ Architecture & Tech Stack

This project utilizes a Hybrid Data Access Architecture to balance rapid development with bare-metal performance:

Frontend: C# Windows Forms (WinForms)

Backend Framework: .NET 10.0

Primary ORM: Entity Framework Core (used for migrations and standard CRUD operations).

Performance Layer: Pure ADO.NET (SqlConnection, SqlDataReader) utilizing parameterized raw SQL queries for complex, high-traffic operations (e.g., availability checks and login validation).

Database: Azure SQL / Microsoft SQL Server.

🚀 Local Development Setup

This project is configured for a streamlined local execution workflow. Follow these steps to get the environment running on your local machine.

Prerequisites

Visual Studio 2022 (Ensure the .NET desktop development workload is installed)

.NET 10.0 SDK

Local SQL Server instance (e.g., SQL Server Express) or an active Azure SQL database.

Installation

Clone the repository:

git clone [https://github.com/yourusername/CarRentalSystem.git](https://github.com/yourusername/CarRentalSystem.git)
cd CarRentalSystem


Open the Solution:
Double-click the CarRentalSystem.sln file to open the project in Visual Studio.

Configure the Database Connection:
Open Data/AppDbContext.cs (or your configuration file) and update the connection string to point to your local development database:

// Example local connection string
"Server=localhost\\SQLEXPRESS;Database=CarRentalDB;Trusted_Connection=True;Encrypt=False;"


Initialize the Database:
Open the Package Manager Console in Visual Studio (Tools > NuGet Package Manager > Package Manager Console) and run the following command to build the schema:

Update-Database


Build and Run:
Ensure your build configuration is set to Debug for active development, and hit F5 (Start Debugging) to launch the application locally.

🧠 Technical Highlights

SQL Offloading: Heavy business logic (such as calculating date overlaps and identifying overdue reservations) is offloaded entirely to the SQL Server using complex UNION and NOT IN subqueries, drastically reducing network payload and memory consumption.

Connected Architecture: High-traffic search grids utilize ADO.NET's Connected Mode (SqlDataReader) for low-overhead, forward-only data streaming.

SQL Injection Prevention: 100% of raw SQL queries utilize strict parameterization (AddWithValue) rather than string concatenation.

👥 Contributing

When contributing to this project, please ensure that all new database services adhere to the existing DTO pattern and that raw SQL commands are fully parameterized.

📄 License

This project is licensed under the MIT License - see the LICENSE file for details.
