// See https://aka.ms/new-console-template for more information
using System;
using DAY_3;

namespace BankAccountManagementSystem
{
    class Program
    {
        static void Main()
        {
            SavingAccount sa = new SavingAccount("SA101", "1111", 5.5m, "BR01");

            BankAudit.CorporateAccount ca = new BankAudit.CorporateAccount("CA201", "9999", 7.5m, "BR02");

            Console.WriteLine(sa.GetInterest());
            Console.WriteLine(ca.CalculateInterest());
        }
    }
}
