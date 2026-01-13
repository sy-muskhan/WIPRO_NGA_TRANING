using System;
using System.Collections.Generic;
using System.Text;


/*
 In C#.NET, static members belong to the class itself rather than objects.
 Static constructors initialize static data and execute only once.
 Static classes cannot be instantiated and can contain only static members.
*/

// -------------------------------
// STATIC CLASS
// -------------------------------

namespace DAY_4
{
    static class ApplicationInfo
    {
        // Static variables
        public static string ApplicationName;
        public static string Version;

        // Static constructor
        static ApplicationInfo()
        {
            ApplicationName = "College Management System";
            Version = "1.0.0";
            Console.WriteLine("Static constructor of ApplicationInfo executed.");
        }

        // Static method
        public static void DisplayInfo()
        {
            Console.WriteLine("Application Name : " + ApplicationName);
            Console.WriteLine("Version          : " + Version);
        }
    }

    // -------------------------------
    // NORMAL CLASS WITH STATIC MEMBERS
    // -------------------------------
    class College
    {
        // Static variable (shared by all objects)
        public static string CollegeName;
        public static int TotalDepartments;

        // Static constructor
        static College()
        {
            CollegeName = "Sri Venkateswara College of Engineering and Technology";
            TotalDepartments = 0;
            Console.WriteLine("Static constructor of College executed.");
        }

        // Instance variables
        public string DepartmentName;

        // Instance constructor
        public College(string deptName)
        {
            DepartmentName = deptName;
            TotalDepartments++;
        }

        // Static method
        public static void DisplayCollegeDetails()
        {
            Console.WriteLine("College Name      : " + CollegeName);
            Console.WriteLine("Total Departments : " + TotalDepartments);
        }

        // Instance method
        public void DisplayDepartment()
        {
            Console.WriteLine("Department Name   : " + DepartmentName);
        }
    }

    // -------------------------------
    // STUDENT CLASS
    // -------------------------------
    class Student
    {
        // Static variable
        public static int TotalStudents;

        // Instance variables
        public int RollNo;
        public string Name;
        public string Department;

        // Static constructor
        static Student()
        {
            TotalStudents = 0;
            Console.WriteLine("Static constructor of Student executed.");
        }

        // Instance constructor
        public Student(int rollNo, string name, string department)
        {
            RollNo = rollNo;
            Name = name;
            Department = department;
            TotalStudents++;
        }

        // Static method
        public static void DisplayStudentCount()
        {
            Console.WriteLine("Total Students    : " + TotalStudents);
        }

        // Instance method
        public void DisplayStudent()
        {
            Console.WriteLine("Roll No : " + RollNo);
            Console.WriteLine("Name    : " + Name);
            Console.WriteLine("Dept    : " + Department);
            Console.WriteLine("---------------------------");
        }
    }

    // -------------------------------
    // MAIN CLASS
    // -------------------------------
    class Program
    {
        static void Main()
        {
            Console.WriteLine("====== PROGRAM STARTED ======\n");

            // Calling static class method
            ApplicationInfo.DisplayInfo();

            Console.WriteLine("\n-----------------------------");

            // Creating College objects
            College c1 = new College("Computer Science Engineering");
            College c2 = new College("Electronics and Communication");

            // Calling instance methods
            c1.DisplayDepartment();
            c2.DisplayDepartment();

            Console.WriteLine();

            // Calling static method
            College.DisplayCollegeDetails();

            Console.WriteLine("\n-----------------------------");

            // Creating Student objects
            Student s1 = new Student(101, "Muskhan", "CSE");
            Student s2 = new Student(102, "Ayesha", "CSE");
            Student s3 = new Student(103, "Rahul", "ECE");

            // Display student details
            s1.DisplayStudent();
            s2.DisplayStudent();
            s3.DisplayStudent();

            // Calling static method
            Student.DisplayStudentCount();

            Console.WriteLine("\n====== PROGRAM ENDED ======");
        }


    }
}
