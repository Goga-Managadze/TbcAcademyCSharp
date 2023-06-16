using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Library
    {
        private Book[] _books;
        private int count = 0;

        public Book this[int i]
        {
            get
            {
                return _books[i];
            }
            set {
                _books[i] = value;
            }
        }

        public int setBooks
        {
            set{
                _books = new Book[value];
            }
            
        }
        public void AddBook(Book Book)
        {
            if (count < _books.Length)
            {
                _books[count] = Book;
                count++;
            }
            Console.WriteLine($"Added Book Title: {Book.Title}, Author: {Book.Author}, Year: {Book.Year}, Genre: {Book.Genre}");
        }
        public void RemoveBook(string title)
        {
            for (int i = 0; i < count; i++)
            {
                if (_books[i].Title == title)
                {
                    _books[i] = null;
                    count--;
                    Console.WriteLine("Book removed successfully.");
                    break;
                }
            }
        }
        public Book this[string i]
        {
            get
            {
                for (int j = 0; j < _books.Length; j++)
                {
                    if (i == _books[j].Title)
                    {
                        Console.WriteLine("The book titled " + "'" + i + "'" + " has been found in the array");
                        return _books[j];
                    }
                }
                return null;
            }
            set { 
            }
        }

        public void CountOfBooks()
        {
            Console.WriteLine("Count of books: " + count);
        }
    }
}
