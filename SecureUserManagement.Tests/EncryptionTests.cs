using System;
using System.Collections.Generic;
using System.Text;
using SecureUserManagement;
using NUnit.Framework;

namespace SecureUserManagement.Tests
{
    public class EncryptionTests
    {
        [Test]
        public void EncryptDecryptTest()
        {
            string data = "Hello";
            string encrypted = SecurityHelper.Encrypt(data);
            string decrypted = SecurityHelper.Decrypt(encrypted);
            Assert.That(decrypted.Equals(data), Is.True);
        }
    }
}
