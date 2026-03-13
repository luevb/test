using BlaBlaTest.Dates;
using BlaBlaTest.Model;

namespace BlaBlaTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            using(var db = new AppDbContext())
            {
                db.Database.EnsureCreated();
                Console.WriteLine("add book");
                Book newBook = new Book("War and Peace", "Lev Tolstoy", 1869);
                db.Books.Add(newBook);
                db.SaveChanges();
                Console.WriteLine("complete add book");
                Console.WriteLine("list book in library: ");
                var allBooks = db.Books.ToList();
                foreach (var book in allBooks) 
                {
                    Console.WriteLine($"- {book.Title}, {book.Author}, {book.Year} year");
                }
            }
        }
    }
}
