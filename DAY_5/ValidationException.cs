using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_5
{
     public class ValidationException : Exception
    {
        public ValidationException()
        : base("Validation failed. Please check the input values.")
        {
        }

    }
}
