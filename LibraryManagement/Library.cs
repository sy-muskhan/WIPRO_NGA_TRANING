using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LibraryManagement
{
    public class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Borrower> Borrowers { get; set; } = new List<Borrower>();

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        public void BorrowBook(string isbn, string libraryCardNumber)
        {
            Book book = Books.First(b => b.ISBN == isbn && !b.IsBorrowed);
            Borrower borrower = Borrowers.First(b => b.LibraryCardNumber == libraryCardNumber);

            borrower.BorrowBook(book);
        }

        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            Borrower borrower = Borrowers.First(b => b.LibraryCardNumber == libraryCardNumber);
            Book book = borrower.BorrowedBooks.First(b => b.ISBN == isbn);

            borrower.ReturnBook(book);
        }

        public List<Book> ViewBooks()
        {
            return Books;
        }

        public List<Borrower> ViewBorrowers()
        {
            return Borrowers;
        }
    }
}
