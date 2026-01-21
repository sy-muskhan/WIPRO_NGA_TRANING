using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class PdfReportFormatter : IReportFormatter
    {
        public string Format(Report report)
        {
            // Simple PDF formatting simulation
            return "PDF FORMAT\n" + report.Title + "\n" + report.Content;
        }
    }
}
