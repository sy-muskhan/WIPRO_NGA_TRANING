using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_3
{
    public class BankAccount
    {  // Account PIN must be hidden
            private string accountPIN;
            // Account number accessible everywhere
            public string accountNumber;
            //accessible within derived classes or same assembly
            protected internal decimal interestRate;
            // accessible within same assembly
            internal string bankBranchCode;
            // accessible within derived classes
            protected decimal balance;

            // Constructor : To initialize bank account memebers with default values
            public BankAccount(string accNumber, string pin, decimal interest, string branchCode)
            {
                accountNumber = accNumber;
                accountPIN = pin;
                interestRate = interest;
                bankBranchCode = branchCode;
            }

            //deposit money method

            public void Deposit(decimal amount)
            {
                balance += amount;// add amount to balance


            }

        public decimal CalculateInterest()
        {
            return interestRate + 1;
        }


    }
}
