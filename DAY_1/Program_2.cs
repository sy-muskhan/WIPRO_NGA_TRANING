using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_1
{
    public class Program_2
    {
        //Program to find the factorial of a number.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to find its factorial:");
            int number = int.Parse(Console.ReadLine());
            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Factorial of " + number + " is: " + factorial);
        }
    }
}
