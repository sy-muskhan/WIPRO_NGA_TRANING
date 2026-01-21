using System;
using System.Collections.Generic;
using System.Text;

namespace SecureUserManagement
{
    public static class Logger
    {
        private static readonly string logFile = "app.log";

        public static void Log(string message)
        {
            string log = DateTime.Now + " : " + message;
            File.AppendAllText(logFile, log + Environment.NewLine);
        }
    }
}
