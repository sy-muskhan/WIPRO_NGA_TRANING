using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_6
{
    class Stack_Queue
    {
        //Comon usecase of colelction ie   Stack and Queue in  reallife scenario are as below :
        //1. Stack : Undo mechanism in text editors , Browser history etc
        //2. Queue : Print spooling , CPU task scheduling , Call center systems etc
        //3. Priority Queue : Emergency room triage ,Task scheduling in operating systems , Network packet routing etc
        //4. Deque : Browser history navigation , Undo/Redo functionality in applications , Task scheduling with varying priorities etc
        //5. Concurrent Collections : Real-time data processing , Multi-threaded web servers , Parallel computing tasks etc
        //6. list use cases : Data binding in UI frameworks , Implementing stacks and queues , Storing collections of items for processing etc






        //Step1: Define a stack to hold integer values ex.  
        //Step2: Push some values onto the stack
        //Step3: Pop a value from the stack and display it
        //Step4: Peek at the top value of the stack without removing it( All fucntinoality are provided by Stack class in System.Collections.Generic namespace)
        //Step5: Check if the stack contains a specific value( Searching functionality)
        //Step6: Display the current count of items in the stack(Using Count property of Stack class)
        //Step7: Clear the stack of all items(Using Clear method of Stack class)


        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            // Step 2: Push some values onto the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);
            // Step 3: Pop a value from the stack and display it
            int poppedValue = stack.Pop();
            Console.WriteLine("Popped Value: " + poppedValue);
            // Step 4: Peek at the top value of the stack without removing it
            int topValue = stack.Peek();
            Console.WriteLine("Top Value: " + topValue);
            // Step 5: Check if the stack contains a specific value
            bool contains20 = stack.Contains(20);
            Console.WriteLine("Stack contains 20: " + contains20);
            // Step 6: Display the current count of items in the stack
            int count = stack.Count;
            Console.WriteLine("Current Stack Count: " + count);
            // Step 7: Clear the stack of all items
            stack.Clear();
            Console.WriteLine("Stack cleared. Current Count: " + stack.Count);


            Queue<string> queue = new Queue<string>();
            // Enqueue some values onto the queue
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            // Dequeue a value from the queue and display it
            string dequeuedValue = queue.Dequeue();
            Console.WriteLine("Dequeued Value: " + dequeuedValue);

            // Peek at the front value of the queue without removing it
            string frontValue = queue.Peek();
            Console.WriteLine("Front Value: " + frontValue);
            // Check if the queue contains a specific value
            bool containsSecond = queue.Contains("Second");
            Console.WriteLine("Queue contains 'Second': " + containsSecond);
            // Display the current count of items in the queue
            int queueCount = queue.Count;
            Console.WriteLine("Current Queue Count: " + queueCount);
            // Clear the queue of all items
            queue.Clear();
            Console.WriteLine("Queue cleared. Current Count: " + queue.Count);
            queue.Clear();
            Console.WriteLine("Queue cleared. Current Count: " + queue.Count);


            //Implementing stack and queue in non generic way using System.Collections namespace
            System.Collections.Stack nonGenericStack = new System.Collections.Stack();
            nonGenericStack.Push(100);
            nonGenericStack.Push("Hello");
            
            System.Collections.Queue nonGenericQueue = new System.Collections.Queue();
            nonGenericQueue.Enqueue(200);
            nonGenericQueue.Enqueue("World");

            //Peek and Pop for non generic stack

        var nonGenericPoppedValue = nonGenericStack.Pop();
            Console.WriteLine("Non-Generic Popped Value: " + nonGenericPoppedValue);
            var nonGenericTopValue = nonGenericStack.Peek();
            Console.WriteLine("Non-Generic Top Value: " + nonGenericTopValue);
            //Peek and Dequeue for non generic queue
            var nonGenericDequeuedValue = nonGenericQueue.Dequeue();
            Console.WriteLine("Non-Generic Dequeued Value: " + nonGenericDequeuedValue);
            var nonGenericFrontValue = nonGenericQueue.Peek();
            Console.WriteLine("Non-Generic Front Value: " + nonGenericFrontValue);




        }
    }
}
