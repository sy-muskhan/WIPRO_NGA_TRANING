using System;
using System.Collections.Generic;
using System.Linq;

//Step 1: Creating a .Net Application that needs to be tested.
//Step 2: Creating a Unit Test Project to test the .Net Application using NUnit framework.
//another project in same solution and connect it to the main project.

//Step 3: Writing Unit Test to test the .Net Application.
//Step 4: Understanding the Project structure of Unit Test Project.
//Step 5: Create a test Class and write test methods.
//Step 6: Write test method using AAA pattern.
//Step 7: 


namespace UnitTesting_CalculatorApp
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public double Divide(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Denominator cannot be zero.");
            return (double)a / b;
        }
    }
}


