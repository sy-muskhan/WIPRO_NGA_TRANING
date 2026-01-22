using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_1
{
    public class Program_3
    {
        //Program to check if a number is prime or not.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it is prime:");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (number <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine(number + " is a prime number.");
            }
            else
            {
                Console.WriteLine(number + " is not a prime number.");
            }
        }
    }
}
