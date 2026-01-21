using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class ReportService : IReportService
    {
        private readonly IReportFormatter formatter;

        public ReportService(IReportFormatter formatter)
        {
            this.formatter = formatter;
        }

        public void ProcessReport()
        {
            Report report = new Report
            {
                Title = "Monthly Report",
                Content = "Revenue details"
            };

            string result = formatter.Format(report);
            Console.WriteLine(result);
        }
    }
}
