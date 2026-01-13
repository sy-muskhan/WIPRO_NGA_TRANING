//// See https://aka.ms/new-console-template for more information
//using System;

//// Custom exception
//class DailyLimitExceededException : Exception
//{
//    public DailyLimitExceededException(string message) : base(message)
//    {
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        // -------------------------------
//        // PART 1: Divide by zero example
//        // -------------------------------
//        try
//        {
//            Console.Write("Enter a number to divide 100 by: ");
//            int number = int.Parse(Console.ReadLine());

//            int result = 100 / number;
//            Console.WriteLine("Result : " + result);
//        }
//        catch (DivideByZeroException)
//        {
//            Console.WriteLine("Error: Cannot divide by zero!");
//            Console.WriteLine("Please enter a non-zero number.");
//        }

//        Console.WriteLine();
//        Console.WriteLine("=== Bank Account Transaction Example ===");

//        // ---------------------------------
//        // PART 2: Bank transaction example
//        // ---------------------------------
//        double dailyLimit = 1000.00;
//        double remainingLimit = dailyLimit;

//        try
//        {
//            ProcessTransaction(400.00, ref remainingLimit);
//            ProcessTransaction(500.00, ref remainingLimit);
//            ProcessTransaction(300.00, ref remainingLimit); // exceeds limit
//        }
//        catch (DailyLimitExceededException ex)
//        {
//            Console.WriteLine("ERROR: " + ex.Message);
//        }
//    }

//    static void ProcessTransaction(double amount, ref double remainingLimit)
//    {
//        if (amount > remainingLimit)
//        {
//            throw new DailyLimitExceededException("Daily transaction limit exceeded!");
//        }

//        remainingLimit -= amount;
//        Console.WriteLine(
//            $"Transaction of ${amount} completed successfully. Remaining limit: ${remainingLimit}"
//        );
//    }
//}

