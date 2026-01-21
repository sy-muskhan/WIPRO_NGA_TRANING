using System;
using System.Collections.Generic;
using System.IO;
using SecureUserManagement;
using NUnit.Framework;

namespace SecureUserManagement.Tests
{
    public class LoggerTests
    {
        [Test]
        public void LogFileCreationTest()
        {
            string file = "app.log";

            if (File.Exists(file))
                File.Delete(file);

            SecureUserManagement.Logger.Log("Test");

            Assert.That(File.Exists(file), Is.True);
        }
    }
}
