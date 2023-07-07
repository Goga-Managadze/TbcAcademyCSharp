using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Book
    {
        private string _title;
        private string _author;
        private string _genre;

        public void createBookInfo(string title, string author, string genre)
        {
            _title = title;
            _author = author;
            _genre = genre;
            Console.WriteLine($"Title: {_title}, Author: {_author}, Genre: {_genre}");
        }

        public void enterPublishYear(int year)
        {
            Console.WriteLine($"Book published in {year}");
        }
    }
}
