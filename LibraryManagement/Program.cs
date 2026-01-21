using System;

namespace LibraryManagement.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book = new Book
            {
                Title = "C# Programming",
                Author = "Microsoft",
                ISBN = "101"
            };

            Borrower borrower = new Borrower
            {
                Name = "Alice",
                LibraryCardNumber = "L1001"
            };

            library.AddBook(book);
            library.RegisterBorrower(borrower);
            library.BorrowBook("101", "L1001");

            Console.WriteLine("Library Management System executed successfully.");
        }
    }
}

