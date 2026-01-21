using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_DesignPatterns
{
    public class PrintableReport:IPrintableReport
    {
        public void Print()
        {
            Console.WriteLine("Printing report.");
        }
    }
}
