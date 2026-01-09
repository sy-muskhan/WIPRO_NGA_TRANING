using Day_2_Demo2_OMS_Colelctions_IN_C_Sharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Day2_Programs
{
    internal class Program2_Collections
    {
        public static void Main1(string[] args)
        {
            // Collections in C# are data structures that allow you to store, manage, and manipulate groups of related objects. 
            // They provide more flexibility and functionality compared to arrays, making them suitable for various scenarios where dynamic sizing and advanced operations are required.
            // Commonly used collections in C# include:
            // List<T>: A dynamic array that can grow and shrink in size. It provides methods for adding, removing, and searching for elements.

            //here is the implementation of Non Generic Collection as per order management system
            //Step 1: Create a class to represent an Order


            Console.WriteLine("Non Generic Collection Implementation");
            ArrayList orderCollection = new ArrayList();
            Console.WriteLine("Right now the memory of collection is: " + orderCollection.Capacity);
            orderCollection.Add("laptop");
            orderCollection.Add(1001);
            orderCollection.Add(99.99);
            orderCollection.Add(new DateTime(2024, 6, 1));
            Console.WriteLine("Right now the memory of collection is: " + orderCollection.Capacity);


            Console.WriteLine("Items int the Order Collection");
            foreach (var item in orderCollection)
            {
                Console.WriteLine(item);
            }

            //For displayinh the type of each item in the collection
            Console.WriteLine("Items int the Order Collection with their type");
            foreach (var item in orderCollection)
            {
                Console.WriteLine($"{item} is of type {item.GetType()}");
            }

            //Above collection can be made more type safe by using Generic Collection
            Console.WriteLine("Generic Collection Implementation");
            List<string> list = new List<string>();
            list.Add("Laptop");
            list.Add("Mobile");
            list.Add("Tablet");
            list.Add(12345.ToString()); // Converting int to string to avoid compile-time error

            Console.WriteLine("Total no of elements in the list are:");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }


            //Above collection is of generic type and only string type of data can be added to it.

            //In case of order management system we can create a class Order and use List<Order> to store multiple orders.
            //Step 1: Create a class to represent an Order

            //Step 2: Create a generic collection to store Order objects


            List<Order> orderList = new List<Order>();

            //Adding some sample orders to the collection
            orderList.Add(new Order { OrderId = 1, ProductName = "Laptop", Quantity = 2, Price = 1500.00 });
            orderList.Add(new Order { OrderId = 2, ProductName = "Mobile", Quantity = 5, Price = 800.00 });

            //displaying the orders in the collection
            Console.WriteLine("Orders in the Order Collection:");
            foreach (var order in orderList)
            {
                Console.WriteLine(order);
            }



        }
    }
}
