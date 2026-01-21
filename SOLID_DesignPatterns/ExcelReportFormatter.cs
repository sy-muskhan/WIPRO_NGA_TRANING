using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class ExcelReportFormatter : IReportFormatter
    {
        public string Format(Report report)
        {
            // Simple Excel formatting simulation
            return "EXCEL FORMAT\n" + report.Title + "\n" + report.Content;
        }
    }
}
