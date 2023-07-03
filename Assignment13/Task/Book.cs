using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Book
    {
        public int BookNumber {get;set;}
        public string Title { get;set;}
        public string Author { get;set;}

        public Book(int bookNumber, string title, string author)
        {
            BookNumber = bookNumber;
            if (bookNumber <= 0)
            {
                throw new ArgumentNullException("Book number is not greater than 0");
            }
            if (title == "")
            {
                throw new ArgumentNullException("Book title is not entered");
            }
            if (author == "")
            {
                throw new ArgumentNullException("Book author is not entered");
            }

            BookNumber = bookNumber;
            Title = title;
            Author = author;
        }
    }
}
