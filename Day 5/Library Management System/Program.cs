using LibrarySystem.Books;
using LibrarySystem.Members;
using LibrarySystem.Transactions;
using System.Transactions;

namespace LibrarySystem
{
    public class Library
    {
        static void Main(string[] args)
        {
            // BOOK 
            new Book();
            new Magazine();
            new Journal();

            // Member
            new Member();
            new Librarian();

            // Transaction
            new BorrowTransaction();
            new ReturnTransaction();

            Console.WriteLine("Hello World");
        }
    }
}
