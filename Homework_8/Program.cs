using System.Text;

namespace Homework_8
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string ReleaseDate { get; set; }
        public int Pages { get; set; }

        public void DisplayInfo()
        {
            
            Console.WriteLine(
                $"\nName: {Name}, \nAuthor: {Author}, \nRelease date: {ReleaseDate}, \nNumber of pages: {Pages},");
        }

        public void IsThick()
        {
            Console.WriteLine(Pages >= 500 ? "This book is thick" : "This book is thin");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            Book book1 = new Book();
            book1.Name = "Dune";
            book1.Author = "Frank Herbert";
            book1.ReleaseDate = "1965";
            book1.Pages = 896;
            book1.DisplayInfo();
            book1.IsThick();
            
            Book book2 = new Book();
            book2.Name = "Dune Messiah";
            book2.Author = "Frank Herbert";
            book2.ReleaseDate = "1969";
            book2.Pages = 256;
            book2.DisplayInfo();
            book2.IsThick();
            */
            
            Book book = new Book();
            Console.Write("Enter book name: ");
            book.Name = Console.ReadLine();
            Console.Write("Enter book author: ");
            book.Author = Console.ReadLine();
            Console.Write("Enter book release date: ");
            book.ReleaseDate = Console.ReadLine();
            
            while (book.Pages == 0)
            {
                Console.Write("Enter book number of pages: ");
                if (int.TryParse(Console.ReadLine(), out int pages))
                {
                    book.Pages = pages;
                    book.DisplayInfo();
                    book.IsThick();
                }
                else
                    Console.WriteLine("Invalid number of pages!");
            }
        }
    }
}