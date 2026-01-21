using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class SalesReport : BaseReport
    {
        public override string GetReportType()
        {
            return "Sales Report";
        }
    }
}
