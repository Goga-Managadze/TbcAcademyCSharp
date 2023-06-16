// See https://aka.ms/new-console-template for more information

using LibrarySystem;

Library library = new Library();
library.setBooks = 15;

Book Book = new Book() { Title = "Book", Author = "Author", Year = 2010, Genre = "Genre" };
Book Book2 = new Book() { Title = "Book2", Author = "Author2", Year = 2010, Genre = "Genre2" };
Book Book3 = new Book() { Title = "Book3", Author = "Author3", Year = 2010, Genre = "Genre3" };


library.AddBook(Book);
library.AddBook(Book2);
library.RemoveBook("Book3");
library.CountOfBooks();

