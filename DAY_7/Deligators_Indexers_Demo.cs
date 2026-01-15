using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_7
{
    
    class Deligators_Indexers_Demo
    {
        //Indexers: An indexer allows an object to be indexed like an array.
        //Attributes: It is used for adding metadata - to code element as
        //Classes
        //Methods
        //Properties
        //Parameters

        //This metadata is used at run time using reflection

        //Why Attributes are used?
        //Declarative programming
        //Seperation of concerns
        // Configuration without code changes


        [Obsolete("use new method instead")]
        static void OldMethodforDisplayingData()
        {
            Console.WriteLine("This is old method for displaying data");
        }
        static void Main(string[] args)
        {
            StudentMarks mystudents = new StudentMarks();
            mystudents[0] = 85;
            mystudents[1] = 90;
            mystudents[2] = 78;
            mystudents[3] = 92;

            Console.WriteLine("Student Marks Are: ");
            Console.WriteLine(mystudents[0]);
            Console.WriteLine(mystudents[1]);
            Console.WriteLine(mystudents[2]);
            Console.WriteLine(mystudents[3]);


        }

    }

    class StudentMarks
    {
        private int[] marks = new int[5];
        // Indexer to access marks
        public int this[int index]
        {
            get { return marks[index];
            
        }

            set { marks[index] = value; }
        }
    }
}
