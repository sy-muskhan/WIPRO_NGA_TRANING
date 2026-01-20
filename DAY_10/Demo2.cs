using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace DAY_10
{
    class Demo2
    {
        private 
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
            //Random Key Generation Example
            byte[] key = RandomNumberGenerator.GetBytes(16);

            string secureKey = Convert.ToBase64String(key);
            Console.WriteLine("Randomly Generated Key: " + secureKey);



        }
    }
}
