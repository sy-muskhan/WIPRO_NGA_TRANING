using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace DAY_5
{
    public class DailyLimitExceededException : Exception
    {
        public DailyLimitExceededException(string message) : base(message)
        {
        }
    }

    #region Business Logic Class
    class BankAccount
    {
        private decimal dailyLimit = 1000;
        private decimal totalTransactionsToday = 0;

        public void MakeTransaction(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Transaction amount must be greater than zero.");
            }

            if (totalTransactionsToday + amount > dailyLimit)
            {
                throw new DailyLimitExceededException("Daily transaction limit exceeded.");
            }

            totalTransactionsToday += amount;
            Console.WriteLine($"Transaction of {amount} completed successfully.");
        }
    }
    #endregion

    class Program
    {
        static void Main()
        {
            Console.WriteLine("====== EXCEPTION HANDLING DEMO IN C#.NET ======\n");

            // -------------------------------
            // 1. USER INPUT VALIDATION
            // -------------------------------
            try
            {
                Console.Write("Enter a number to divide 100 by: ");
                int number = Convert.ToInt32(Console.ReadLine());
                int result = 100 / number;
                Console.WriteLine("Result : " + result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("ERROR: Cannot divide by zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("ERROR: Invalid input format.");
            }

            Console.WriteLine();

            // -------------------------------
            // 2. FILE I/O EXCEPTION HANDLING
            // -------------------------------
            try
            {
                using (StreamWriter writer = new StreamWriter("log.txt"))
                {
                    writer.WriteLine("Exception Handling Log File");
                    writer.WriteLine("File written successfully.");
                }

                using (StreamReader reader = new StreamReader("log.txt"))
                {
                    Console.WriteLine("File Content:");
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("File I/O Error: " + ex.Message);
            }

            Console.WriteLine();

            // -------------------------------
            // 3. CUSTOM EXCEPTION (BUSINESS LOGIC)
            // -------------------------------
            BankAccount account = new BankAccount();

            try
            {
                account.MakeTransaction(400);
                account.MakeTransaction(500);
                account.MakeTransaction(300); // Exceeds daily limit
            }
            catch (DailyLimitExceededException ex)
            {
                Console.WriteLine("BUSINESS ERROR: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("GENERAL ERROR: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Transaction process completed.");
            }

            Console.WriteLine("\n====== PROGRAM EXECUTION COMPLETED ======");
        }

    }
}
