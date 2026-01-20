using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using System.Security.Cryptography;

namespace EncryptionDemo
{
    class Program
    {
        //For implementing Encryption in .NET we have following packages
        //1. System.Security.Cryptography - Built-in library for cryptographic operations, like hashing, encryption, and decryption.
        //2. BouncyCastle - A third-party library that provides a wide range of cryptographic algorithms and protocols.
        //3. BCrypt.Net-Next - A library specifically for hashing passwords using the BCrypt algorithm.


        //Steps for implementing Encryption in .NET
        //Step 1: Choose the Encryption Algorithm ex : AES(Advance Encryption System), RSA( Rivest , Sheiman, addleman ), DES etc
        //Step 2: Generate Encryption Keys ex : Symmetric key for AES, Public and Private keys for RSA.
        //Step 3: Implement Encryption and Decryption Logic via code.
        //Step 4: Test the Implementation to ensure data is correctly encrypted and decrypted.

        static void Main(string[] args)
        {
            //Create a new instance of Aes class
            //string message = "Here is a secret message!";
            string password = "StrongPassword123";

            //Convert string into bytes
            byte[] passwordbyte = Encoding.UTF8.GetBytes(password);

            //Creating HSA 256 instance
            using SHA256 sha256 = SHA256.Create();

            //Computing hash
            byte[] key = sha256.ComputeHash(passwordbyte);

            //converting hash into a readable string
            string HashPassword = Convert.ToBase64String(key);

            Console.WriteLine("Hashed Password: " + HashPassword);


        }


    }
}
