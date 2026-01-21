using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class ReportSaver
    {
        public void SaveReport(Report report)
        {
            File.WriteAllText("report.txt", report.Title + "\n" + report.Content);
        }
    }
}
