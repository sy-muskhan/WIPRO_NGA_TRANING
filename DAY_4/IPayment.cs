using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_4
{
    public interface IPayment
    {
        void MakePayment(decimal amount);
    }
}
