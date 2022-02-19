using System;
using System.Collections.Generic;

namespace Home_Library
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int length = 9;

            List<Book> books = FillList(length);

            HomeLibrary library = new HomeLibrary(books);
            library.Add(new Book("Metro 2033", "Dima", 356, 2010));

            Console.WriteLine("Please enter the book name: ");
            string requestedBook = Console.ReadLine();
            Console.WriteLine($"The book was found: {library.Find(requestedBook)}");

            library.Print();

            Console.WriteLine();
            library.Sort();

            library.Print();
        }

        private static List<Book> FillList(int length)
        {
            List<Book> books = new List<Book>();

            for (int i = 0; i < length; i++)
            {
                books.Add(new Book($"Player {i}", $"Author {i}", i * 75, i * 500));
            }

            return books;
        }
    }
}
