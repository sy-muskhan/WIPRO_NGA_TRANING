using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class ExportableReport: IExportableReport
    {
        public void Export()
        {
            Console.WriteLine("Exporting report.");
        }
    }
}
