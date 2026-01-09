// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine() ?? "";

        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            char ch = char.ToLower(input[i]);

            if (ch == 'a' || ch == 'e' || ch == 'i' ||
                ch == 'o' || ch == 'u')
            {
                count++;
            }
        }

        Console.WriteLine("Number of vowels: " + count);
    }
}