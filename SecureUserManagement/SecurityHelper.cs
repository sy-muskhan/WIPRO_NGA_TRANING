using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace SecureUserManagement
{
    public static class SecurityHelper
    {
        private static readonly byte[] Key =
            Encoding.UTF8.GetBytes("1234567890123456");

        private static readonly byte[] IV =
            Encoding.UTF8.GetBytes("6543210987654321");

        public static string HashPassword(string password)
        {
            using SHA256 sha = SHA256.Create();
            byte[] hashBytes = sha.ComputeHash(
                Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hashBytes);
        }

        public static string Encrypt(string data)
        {
            using Aes aes = Aes.Create();
            aes.Key = Key;
            aes.IV = IV;

            using MemoryStream ms = new MemoryStream();
            using CryptoStream cs =
                new CryptoStream(ms, aes.CreateEncryptor(),
                                 CryptoStreamMode.Write);
            using StreamWriter sw = new StreamWriter(cs);

            sw.Write(data);
            sw.Close();

            return Convert.ToBase64String(ms.ToArray());
        }

        public static string Decrypt(string encryptedData)
        {
            using Aes aes = Aes.Create();
            aes.Key = Key;
            aes.IV = IV;

            byte[] buffer = Convert.FromBase64String(encryptedData);

            using MemoryStream ms = new MemoryStream(buffer);
            using CryptoStream cs =
                new CryptoStream(ms, aes.CreateDecryptor(),
                                 CryptoStreamMode.Read);
            using StreamReader sr = new StreamReader(cs);

            return sr.ReadToEnd();
        }
    }
}
