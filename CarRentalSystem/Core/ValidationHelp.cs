using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentalSystem.Core
{
    public static class ValidationHelp
    {
        // this class contains all the regex one could want in life. 
        public const string EmailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        public const string PassRegex = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$";

        public const string SSNRegex = @"^\d{3}-\d{2}-\d{4}$";
        public const string DriverLicenseRegex = @"^[A-Za-z0-9]{5,15}$";
        public const string NameRegex = @"^[a-zA-Z\s'-]{2,50}$";
        public const string PhoneRegex = @"^\+?\d{10,15}$";

    }
}
