using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Day2_Programs
{
    internal class Program1
    {
        public static void Main(string[] args)
        {



            //When we should use arrays in C#?
            //1. Fixed Size Requirement: When the number of elements is known and does not change frequently.
            //2. Performance: Arrays provide fast access to elements using indices, making them suitable for performance-critical applications.
            //3. Homogeneous Data: When all elements are of the same type, arrays provide a simple and efficient way to store and manipulate data.
            //4. Multi-Dimensional Data: When dealing with grid-like data structures, such as matrices or tables.

            //some common use cases of arrays in C#:
            //1. Storing a list of items, such as product names or IDs.
            //2. Implementing mathematical matrices for calculations.
            //3. Managing collections of data, such as student grades or employee records.
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 90;
            numbers[2] = 30;
            numbers[3] = 9;
            numbers[4] = 50;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element at index " + i + ": " +numbers[i]);
            }

            Console.WriteLine("sorted order is: {Array.Sort(numbers)}");
            Array.Sort(numbers);
            Console.WriteLine(numbers);
            Console.WriteLine("Reversed array is: {Array.Reverse(numbers)}");
            Console.WriteLine("Index of 30 is: {Array.IndexOf(numbers, 30)}");

            string[] names = new string[3];
            names[0] = "Alice";
            names[1] = "Bob";
            names[2] = "Charlie";

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine("Name at index " + i + ": " + names[i]);
            }

            Console.WriteLine($" count is {names.Count()}");

            //Getting started with 2D Arrays in C#
            //Step 1: Declare a 2D array of type int syntax : dataType[,] arrayName = new dataType[rows, columns];
            //Step 2: Initialize the 2D array with values
            int[,] matrixxx = new int[3, 3] //3 rows and 3 columns
            {
    {1, 2, 3}, //Row 0
    {4, 5, 6}, //Row 1
    {7, 8, 9}  //Row 2
            };


            Console.WriteLine("Here is a multidimensional Array");
            int[,] matrix = new int[3, 3];
                matrix[0, 0] = 1;
                matrix[0, 1] = 2;
                matrix[0, 2] = 3;
                matrix[1, 0] = 4;
                matrix[1, 1] = 5;
                matrix[1, 2] = 6;
                matrix[2, 0] = 7;
                matrix[2, 1] = 8;
                matrix[2, 2] = 9;

               for(int i = 0; i < 3; i++)
               {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
               }

            Console.WriteLine(matrix.Length);


            //jagged Arrays in C# : where each element is an array itself ex
            //Arrays  of arrays , specific rows can have different number of columns
            //Biggest benefit : memory efficiency when dealing with non-uniform data ex
            // a table where each row represents a different entity with varying attributes in case of e commerce products
            //Step 1: Declare a jagged array
            //Step 2: Initialize each row with different sizes
            //Step 3: Print the values of the jagged array using nested for loops
            //hence we use jagged arrays when we have non uniform data to save memory over a 2D array,
            //where all rows must have same number of columns

            Console.WriteLine("Here is Jagged Array");
            int[][] ja = new int[3][];
            ja[0] = new int[] { 1, 2 };
            ja[1] = new int[] { 3, 4, 5 };
            ja[2] = new int[] { 6, 7, 8, 9 };
             
            for (int i = 0; i < ja.Length; i++)
            {
                for (int j = 0; j < ja[i].Length; j++)
                {
                    Console.Write(ja[i][j] + " ");
                }
                Console.WriteLine();
            }

            //Case study : Using Arrays to Manage Student Grades
            //if i want to store marks of students in different subjects: "Subject wise marks for each student"
            //Step 1: Declare a 2D array to store marks of 3 students in 4 subjects
            //Step 2: Initialize the array with sample marks
            //Step 3: Calculate and print the average marks for each student
            //Step 4: Calculate and print the average marks for each subject
            //Step 5: Find and print the highest and lowest marks in the class
            // Syntax for declaraing  2D array as per above  sceanrio is 
            // dataType[,] arrayName = new dataType[rows, columns];

            int[,] studentMarks = new int[3, 43];
            studentMarks[0, 0] = 85; // Student 1 - Subject 1
            studentMarks[0, 1] = 78; // Student 1 - Subject 2
            studentMarks[0, 2] = 92; // Student 1 - Subject 3
            studentMarks[1, 0] = 88; // Student 2 - Subject 1
            studentMarks[1, 1] = 76; // Student 2 - Subject 2
            studentMarks[1, 2] = 95; // Student 2 - Subject 3
            studentMarks[2, 0]  = 89; // Student 3 - Subject 1
            studentMarks[2, 1] = 84; // Student 3 - Subject 2
            studentMarks[2, 2] = 91; // Student 3 - Subject 3

            
        }
    }
}
