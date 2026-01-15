using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_7
{
    class Sorting_Techniques
    {

        // As a data processing engineer, i want to sort large datasets efficiently without using comparison-based algorithms so that i can improve performance for specific types of data.

        //Student Marks: 78, 95, 89, 67, 88, 92, 76, 81, 85, 90
        // Registration Numbers: 102345, 102346, 102347, 102348, 102349, 102350, 102351, 102352, 102353, 102354

        //Step 1: Identify data constraints
        //Marks: Integer values ranging from 0 to 100
        //Id-> 6 digit integers 

        //Step 2: Choose Sorting Technique
        //Marks -> Counting Sort
        //Id -> Radix Sort
        //note: Algorithm choice depends on data characteristics

        //Step 3: Implement the algorithm in c#

        static void CountingSort(int[] arr, int maxVal)
        {
            int[] count = new int[maxVal + 1];

            //Step 1: Count occurrences
            foreach (int num in arr)
            {
                count[num]++;
            }

            //Step 2 : Rebuilding Array
            int index = 0;

            for (int i = 0; i <= maxVal; i++)
            {
                while (count[i] > 0)
                {
                    arr[index++] = i;
                    count[i]--;
                }
            }
        }

        // Radix Sort Implementation
        static void RadixSort(int[] arr)
        {
            int max = GetMax(arr);
            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountingSortByDigit(arr, exp);//This count the digit
            }
        }

        static int GetMax(int[] arr)
        {
            int max = arr[0];
            foreach (int num in arr)
            {
                if (num > max)
                    max = num;
            }

            return max;

        }



        static void CountingSortByDigit(int[] arr, int exp)
        {
            int n = arr.Length;
            int[] output = new int[n];
            int[] count = new int[10];

            // Step 1: Count digits
            for (int i = 0; i < n; i++)
            {
                int digit = (arr[i] / exp) % 10;
                count[digit]++;
            }

            // Step 2: Cumulative count (ONLY 0–9)
            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            // Step 3: Build output array (RIGHT to LEFT)
            for (int i = n - 1; i >= 0; i--)
            {
                int digit = (arr[i] / exp) % 10;
                output[count[digit] - 1] = arr[i];
                count[digit]--;
            }

            // Step 4: Copy back
            for (int i = 0; i < n; i++)
            {
                arr[i] = output[i];
            }
        }

        static void Main(string[] args)
        {
            //Student Marks
            int[] marks = { 78, 95, 89, 67, 88, 92, 76, 81 };
            Console.WriteLine("Original Marks:");

            PrintArray(marks);

            CountingSort(marks, 100);
            Console.WriteLine("Sorted Marks(Counting Sort)");
            PrintArray(marks);

            //Registration Numbers
            int[] regNumbers = { 102345, 102346, 102347, 102348, 102349, 102350, 102351, 102353 };
            Console.WriteLine("Original Registration Numbers:");
            PrintArray(regNumbers);
            RadixSort(regNumbers);
            Console.WriteLine("Sorted Registration Numbers(Radix Sort):");
            Console.WriteLine(regNumbers);

            PrintArray(regNumbers);

            //Utility method to print array

            static void PrintArray(int[] arr)
            {
                foreach (int num in arr)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
