using System;
using System.Collections.Generic;
using System.Text;
using System.IO;    

namespace DAY_5
{
    public class BusinessCriticalException : Exception
    {
        public BusinessCriticalException()
        : base("Business-critical failure occurred. Immediate attention required.")
        {
        }

    }
}
