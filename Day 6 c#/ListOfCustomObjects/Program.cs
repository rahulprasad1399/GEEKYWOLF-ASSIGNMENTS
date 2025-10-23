namespace ListOfCustomObjects
{
    public class MyProgram
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>
            {
                new Book("Harry Potter", "J.K. Rowling", 500),
                new Book("The Hobbit", "J.R.R. Tolkien", 750),
                new Book("Clean Code", "Robert C. Martin", 1200)
            };

            // Finding the book with the highest price 
            Book highestPricedBook = books.OrderByDescending(x => x.Price).First();
            Console.WriteLine("Highest Priced Book is : " + highestPricedBook);

            books.RemoveAll(b => b.Title.Equals("Harry Potter"));

            // Displaying Books with details
            foreach (Book book in books)
            {
                Console.WriteLine(book);
            }

        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }   
        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Title {Title}, Author {Author}, Price {Price}";
        }

    }
}
