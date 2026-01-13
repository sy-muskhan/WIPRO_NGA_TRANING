using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DAY_5
{
    class Logger
    {
        public static void Log(Exception ex)
        {
            string logMessage =
                $"{DateTime.Now} | {ex.GetType().Name} | {ex.Message}";

            File.AppendAllText("systemlog.txt", logMessage + Environment.NewLine);
        }

    }
}
