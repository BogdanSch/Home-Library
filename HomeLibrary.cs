using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Library
{
    class HomeLibrary
    {
        public HomeLibrary(List<Book> books)
        {
            Books = books;
        }
        List<Book> Books { get; set; }

        public void Add(Book book)
        {
            Books.Add(book);
        }

        public void Remove(int bookNum)
        {
            Books.RemoveAt(bookNum);
        }
        public void Remove(Book book)
        {
            Books.Remove(book);
        }

        public Book Find(int year)
        {
            foreach (var book in Books)
            {
                if (book.Year == year) return book;
            }
            return null;
        }
        public Book Find(string name)
        {
            foreach (var book in Books)
            {
                if (book.Name == name) return book;
            }
            return null;
        }
        public void Sort()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                for (int j = 0; j < Books.Count - 1; j++)
                {
                    if (Books[j].Year > Books[j + 1].Year)
                    {
                        var temp = Books[j + 1];
                        Books[j + 1] = Books[j];
                        Books[j] = temp;
                    }
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine(Books[i]);
            }
        }
    }
}
