using System;
using BankAccountManagementSystem;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Bank account management Sysytem");

// Create a SavingAccount instance
DAY_3.SavingAccount savingAcc = new DAY_3.SavingAccount("SA123", "1234", 5.0m, "BR001");
savingAcc.Deposit(1000);
decimal interest = savingAcc.CalculateInterest();
Console.WriteLine($"Interest for Saving Account: {interest}");
//same assembly hence protected member interestRate is accessible here

// Create a CorporateAccount instance from another assembly
BankAccountManagementSystem-DAAY3.BankAudit.CorporateAccount corpAcc = new BankAccountManagementSystem-DAY3.BankAudit.CorporateAccount("CA123", "5678", 7.0m, "BR002");
corpAcc.Deposit(5000);
corpAcc.ApplyCorporateInterest();
Console.WriteLine("Corporate Account interest applied successfully.");
//protected internal member interestRate is accessible here as CorporateAccount is derived from BankAccount


//Requirements:
//Account PIN must be private-Hidden from Everywhere
//Account number must be private-Accessible Everywhere
//Interest Calculation for derived Account must be protected-Accessible within the class and derived classes
//Bank Audit logical methods must be internal-Accessible within the same assembly
//Extension by partner banks & internal collaboration must be protected internal-Accessible within the same assembly and derived classes outside the assembly


//Step 1: Create a base class 'BankAccount' with the appropriate access modifiers.(Core Banking Assembly)
//Step 2: Derive classes like 'SavingsAccount' and 'CurrentAccount' from 'BankAccount' to demonstrate protected access modifier.
//Step 3: Create another assembly/project for 'Bank Audit'