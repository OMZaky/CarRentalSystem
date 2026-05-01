using System;
using System.Security.Cryptography;

namespace CarRentalSystem.Core
{
    public static class PasswordHasher
    {
        // Security parameters: 100,000 iterations is the modern standard for PBKDF2
        private const int Iterations = 100000;
        private const int SaltSize = 16; // 128-bit salt
        private const int HashSize = 32; // 256-bit hash

        /// <summary>
        /// Converts a plain-text password into a secure, salted hash for the database.
        /// Use this on the Register Page.
        /// </summary>
        public static string HashPassword(string password)
        {
            // 1. Generate a random "Salt" (random bytes added to the password)
            byte[] salt = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            // 2. Hash the password combined with the salt
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations, HashAlgorithmName.SHA256))
            {
                byte[] hash = pbkdf2.GetBytes(HashSize);

                // 3. Combine the Salt and the Hash into one single array
                byte[] hashBytes = new byte[SaltSize + HashSize];
                Array.Copy(salt, 0, hashBytes, 0, SaltSize);
                Array.Copy(hash, 0, hashBytes, SaltSize, HashSize);

                // 4. Convert to a string so it can be saved in your SQL database
                return Convert.ToBase64String(hashBytes);
            }
        }

        /// <summary>
        /// Checks if an entered password matches the stored hash.
        /// Use this on the Login Page.
        /// </summary>
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            try
            {
                // 1. Convert the database string back into bytes
                byte[] hashBytes = Convert.FromBase64String(storedHash);

                // 2. Extract the original Salt from the beginning of the array
                byte[] salt = new byte[SaltSize];
                Array.Copy(hashBytes, 0, salt, 0, SaltSize);

                // 3. Extract the actual Hash from the rest of the array
                byte[] actualHash = new byte[HashSize];
                Array.Copy(hashBytes, SaltSize, actualHash, 0, HashSize);

                // 4. Hash the password the user just typed using that exact same Salt
                using (var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, Iterations, HashAlgorithmName.SHA256))
                {
                    byte[] expectedHash = pbkdf2.GetBytes(HashSize);

                    // 5. Compare the two hashes byte-by-byte
                    for (int i = 0; i < HashSize; i++)
                    {
                        if (actualHash[i] != expectedHash[i])
                        {
                            return false; // Passwords don't match
                        }
                    }
                    return true; // Passwords match perfectly
                }
            }
            catch
            {
                // If the stored hash is malformed (like if it's still a plain-text password)
                return false;
            }
        }
    }
}