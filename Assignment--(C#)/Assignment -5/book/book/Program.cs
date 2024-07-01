using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book
{
    // Define the Books class
    class Books
    {
        // Properties
        public string BookName { get; set; }
        public string AuthorName { get; set; }

        // Constructor
        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }

        // Method to display book details
        public void Display()
        {
            Console.WriteLine("Book Name: {0}", BookName);
            Console.WriteLine("Author Name: {0}", AuthorName);
            Console.WriteLine();
        }
    }

    // Define the BookShelf class
    class BookShelf
    {
        private Books[] books; // Array to store Books objects

        // Constructor
        public BookShelf()
        {
            // Initialize the array to store 5 Books objects
            books = new Books[5];
        }

        // Indexer for Books objects
        public Books this[int index]
        {
            get { return books[index]; }
            set { books[index] = value; }
        }

        // Method to display all books in the BookShelf
        public void DisplayAllBooks()
        {
            Console.WriteLine("Books on the Bookshelf:");
            foreach (var book in books)
            {
                if (book != null)
                {
                    book.Display();
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Create an instance of BookShelf
            BookShelf shelf = new BookShelf();

            // Assign values to the Books objects using indexer
            shelf[0] = new Books("Book1", "Author1");
            shelf[1] = new Books("Book2", "Author2");
            shelf[2] = new Books("Book3", "Author3");
            shelf[3] = new Books("Book4", "Author4");
            shelf[4] = new Books("Book5", "Author5");

            // Display all books on the BookShelf
            shelf.DisplayAllBooks();


            Console.ReadKey();
        }
    }
}
