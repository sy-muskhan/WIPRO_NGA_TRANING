using System;
namespace DAY_8
{
    using System;

    class Employee
    {
        private int[] attendance = new int[3];

        public int EmployeeId { get; set; }
        public string Name { get; set; }

        public int this[int index]
        {
            get { return attendance[index]; }
            set { attendance[index] = value; }
        }
    }

    class Product
    {
        private int[] ratings = new int[3];

        public string ProductName { get; set; }
        public double Price { get; set; }

        public int this[int index]
        {
            get { return ratings[index]; }
            set { ratings[index] = value; }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== PROPERTIES VS INDEXERS DEMONSTRATION ===\n");

            Employee emp = new Employee();
            emp.EmployeeId = 101;
            emp.Name = "Ravi";

            emp[0] = 1;
            emp[1] = 0;
            emp[2] = 1;

            Console.WriteLine("Employee Management System");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Accessing PROPERTIES (single values):");
            Console.WriteLine("Employee ID: " + emp.EmployeeId);
            Console.WriteLine("Employee Name: " + emp.Name);

            Console.WriteLine("\nAccessing INDEXERS (collection values):");
            Console.WriteLine("Day 1 Attendance: " + emp[0]);
            Console.WriteLine("Day 2 Attendance: " + emp[1]);
            Console.WriteLine("Day 3 Attendance: " + emp[2]);

            Console.WriteLine("\n---------------------------------------\n");

            Product p = new Product();
            p.ProductName = "Laptop";
            p.Price = 55000;

            p[0] = 5;
            p[1] = 4;
            p[2] = 5;

            Console.WriteLine("E-Commerce System");
            Console.WriteLine("------------------");

            Console.WriteLine("Accessing PROPERTIES (single values):");
            Console.WriteLine("Product Name: " + p.ProductName);
            Console.WriteLine("Product Price: " + p.Price);

            Console.WriteLine("\nAccessing INDEXERS (collection values):");
            Console.WriteLine("Customer 1 Rating: " + p[0]);
            Console.WriteLine("Customer 2 Rating: " + p[1]);
            Console.WriteLine("Customer 3 Rating: " + p[2]);

        }
    }

}

