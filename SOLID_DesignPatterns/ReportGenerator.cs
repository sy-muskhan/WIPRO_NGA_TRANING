using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class ReportGenerator
    {
        public Report GenerateReport()
        {
            Report report = new Report();
            report.Title = "Sales Report";
            report.Content = "Sales data for the month";
            return report;
        }
    }
}
