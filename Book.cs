using System;
using System.Collections.Generic;
using System.Text;

namespace Home_Library
{
    class Book
    {
        public Book(string name, string author, int countPages, int year)
        {
            Name = name;
            Author = author;
            CountPages = countPages;
            Year = year;
        }

        public string Name { get; set; }
        public string Author { get; set; }
        public int CountPages { get; set; }
        public int Year { get; set; }

        public override string ToString()
        {
            return $"The Book name is {Name}, author is {Author}";
        }
    }
}
