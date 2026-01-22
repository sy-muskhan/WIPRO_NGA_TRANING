using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_1
{
    public class Program_1
    {
        //Program to ask the string from user and print it in reverse order.
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse:");
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);
            Console.WriteLine("Reversed string: " + reversedString);
        }
    }
}
