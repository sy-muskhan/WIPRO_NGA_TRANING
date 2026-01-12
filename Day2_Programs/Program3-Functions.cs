using System;
using System.Collections.Generic;
using System.Text;

namespace Day2_Programs
{
    internal class Program3_Functions
    {
         // Function is a block of code that performs a specific task. It is a reusable piece of code that can be called multiple times throughout a program.
            // Functions help in breaking down complex problems into smaller, manageable parts, making the code more organized and easier to understand.
            // Functions can take input parameters, perform operations, and return output values.
            // Example of a simple function that adds two numbers
            

            int calculateTotal(int marks1, int marks2, int marks3)
            {
                int total = marks1 + marks2 + marks3;
                return total;
            }

            double calculateAverage(int totalMarks, int numberOfSubjects)
            {
                double average = (double)totalMarks / numberOfSubjects;
                return average;
            }

        // function to check result
        string checkResult(double averageMarks)
        {
            if (averageMarks >= 40)
            {
                return "Pass";
            }
            else
            {
                return "Fail";
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Implementing Functions in C#");
            Program3_Functions program = new Program3_Functions();
            int totalMarks = program.calculateTotal(85, 90, 78);
            Console.WriteLine("Total Marks: " + totalMarks);
            double averageMarks = program.calculateAverage(totalMarks, 3);
            Console.WriteLine("Average Marks: " + averageMarks);
            string result = program.checkResult(averageMarks);
            Console.WriteLine("Result: " + result);
        }


    }
    }

  
