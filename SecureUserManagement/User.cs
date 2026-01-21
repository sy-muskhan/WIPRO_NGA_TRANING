using System;
using System.Collections.Generic;
using System.Text;


namespace SecureUserManagement
{
    public class User
    {
        public string HashedPassword { get; private set; }

        public void Register(string password)
        {
            try
            {
                HashedPassword = SecurityHelper.HashPassword(password);
                Logger.Log("User registered successfully");
            }
            catch (Exception ex)
            {
                Logger.Log("Registration failed: " + ex.Message);
                throw;
            }
        }

        public bool Authenticate(string password)
        {
            try
            {
                string hash = SecurityHelper.HashPassword(password);
                return hash.Equals(HashedPassword);
            }
            catch (Exception ex)
            {
                Logger.Log("Authentication error: " + ex.Message);
                return false;
            }
        }
    }
}
