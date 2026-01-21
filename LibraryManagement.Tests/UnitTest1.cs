using NUnit.Framework;
using LibraryManagement.ConsoleApp;

namespace LibraryManagement.Tests
{
    public class Tests
    {
        private Library library;

        [SetUp]
        public void Setup()
        {
            library = new Library();
        }

        [Test]
        public void AddBookTest()
        {
            Book book = new Book
            {
                Title = "Test",
                Author = "Author",
                ISBN = "1"
            };

            library.AddBook(book);

            Assert.That(library.Books.Count.Equals(1), Is.True);
        }

        [Test]
        public void RegisterBorrowerTest()
        {
            Borrower borrower = new Borrower
            {
                Name = "User",
                LibraryCardNumber = "L1"
            };

            library.RegisterBorrower(borrower);

            Assert.That(library.Borrowers.Count.Equals(1), Is.True);
        }

        [Test]
        public void BorrowBookTest()
        {
            Book book = new Book
            {
                Title = "Test",
                Author = "Author",
                ISBN = "1"
            };

            Borrower borrower = new Borrower
            {
                Name = "User",
                LibraryCardNumber = "L1"
            };

            library.AddBook(book);
            library.RegisterBorrower(borrower);
            library.BorrowBook("1", "L1");

            Assert.That(book.IsBorrowed.Equals(true), Is.True);
        }

        [Test]
        public void ReturnBookTest()
        {
            Book book = new Book
            {
                Title = "Test",
                Author = "Author",
                ISBN = "1"
            };

            Borrower borrower = new Borrower
            {
                Name = "User",
                LibraryCardNumber = "L1"
            };

            library.AddBook(book);
            library.RegisterBorrower(borrower);
            library.BorrowBook("1", "L1");
            library.ReturnBook("1", "L1");

            Assert.That(book.IsBorrowed.Equals(false), Is.True);
        }
    }
}

