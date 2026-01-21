using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class FinanceReport : BaseReport
    {
        public override string GetReportType()
        {
            return "Finance Report";
        }
    }
}
