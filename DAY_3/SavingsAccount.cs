using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_3
{
    
        // Derived class 'SavingAccount' from base class 'BankAccount'
        //so that it can access protected members, protected internal members, and public members of base class

        public class SavingAccount : BankAccount // derived class from BankAccount
        {
            public SavingAccount(string accNumber, string pin, decimal interest, string branchCode)
                : base(accNumber, pin, interest, branchCode)
            {
            }
            // Method to calculate interest for saving account
            public decimal GetInterest()
            {
                return interestRate * 1;
            }

        }
  
}
