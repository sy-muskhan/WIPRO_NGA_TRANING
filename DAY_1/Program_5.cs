//Program to know the default values of different data types in C#
using System;
namespace DAY_1
{
    public class Program_5
    {
        //A Program to know the default values of different data types in C#
        public static void Main(string[] args)
        {
            Console.WriteLine("Default value of int: " + default(int));
            Console.WriteLine("Default value of float: " + default(float));
            Console.WriteLine("Default value of double: " + default(double));
            Console.WriteLine("Default value of char: '" + default(char) + "'");
            Console.WriteLine("Default value of bool: " + default(bool));
            Console.WriteLine("Default value of string: " + (default(string) == null ? "null" : default(string)));
        }
    }
}
