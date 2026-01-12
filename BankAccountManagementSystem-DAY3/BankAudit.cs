using System;
using DAY_3;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

using System.Text;

namespace BankAccountManagementSystem
{
    public class BankAudit {
        public class CorporateAccount : BankAccount
        {
            public CorporateAccount(string accNumber, string pin, decimal interest, string branchCode)
                : base(accNumber, pin, interest, branchCode)
            {
                // Constructor calling base class constructor
                // Accessing protected internal member from base class
                //hence this will work as CorporateAccount is derived from BankAccount- Core banking assembly

            }

            public override decimal CalculateInterest()// Method to apply interest for corporate account
            {
                return interestRate + 2;
            }

            //pincode is private in base class hence not accessible here
            //branchCode is internal in base class hence not accessible here
        }
    }
}
