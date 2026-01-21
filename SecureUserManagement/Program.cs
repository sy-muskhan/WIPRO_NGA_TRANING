using System;

namespace SecureUserManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Register("password123");

            bool result = user.Authenticate("password123");
            Console.WriteLine(result);

            string data = "SensitiveData";
            string encrypted = SecurityHelper.Encrypt(data);
            string decrypted = SecurityHelper.Decrypt(encrypted);

            Console.WriteLine(encrypted);
            Console.WriteLine(decrypted);
        }
    }
}

