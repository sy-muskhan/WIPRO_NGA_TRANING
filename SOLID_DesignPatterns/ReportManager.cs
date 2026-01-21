using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class ReportManager
    {
        private readonly ReportGenerator generator;
        private readonly ReportSaver saver;

        public ReportManager()
        {
            generator = new ReportGenerator();
            saver = new ReportSaver();
        }

        public void ProcessReport()
        {
            Report report = generator.GenerateReport();
            saver.SaveReport(report);
        }
    }
}
