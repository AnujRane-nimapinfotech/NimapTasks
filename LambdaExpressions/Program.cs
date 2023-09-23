using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class Book
    {
        public string Title { get; set; }
        public int Price { get; set; }
    }

    class BookCollection
    {
        public List<Book> GetBook()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price=5},
                new Book() {Title = "Title 2", Price=7},
                new Book() {Title = "Title 3", Price=17},
            };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Basic Example 
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));

            var books = new BookCollection().GetBook();

            var cheapBooks = books.FindAll(book => book.Price < 10);

            foreach(var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
    }
}
