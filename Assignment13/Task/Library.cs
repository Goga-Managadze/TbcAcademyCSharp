using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Task
{
    public class Library
    {
        private List<Book> _books;
        public int Capacity { get; set; }

        public Library(int capacity)
        {
            _books = new List<Book>();
            Capacity = capacity;
        }
       
        public void AddBook(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException("Book object is null.");
            }

            if (_books.Count > Capacity)
            {
                throw new IndexOutOfRangeException("Books count is greater then capacity");
            }
            _books.Add(book);
            Console.WriteLine($"Added book: Number: {book.BookNumber}, Title: {book.Title}, Author: {book.Author}");
        }

        public Book GetBook(int bookNumber) {
            foreach (Book book in _books)
            {
                if (book.BookNumber == bookNumber)
                {
                    Console.WriteLine($"Book found. Book Number: {book.BookNumber}, Title: {book.Title}, Author: {book.Author}");

                    return book;
                }
            }
            throw new BookNotFoundException(bookNumber);
        }
    }
}
