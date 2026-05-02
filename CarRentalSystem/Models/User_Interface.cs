using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Models
{
    public interface IUser
    {
        public int Id { get; set; }
        string Username { get; set; }
        string PasswordHash { get; set; }
    }
}
