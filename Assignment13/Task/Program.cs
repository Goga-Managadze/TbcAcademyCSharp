// See https://aka.ms/new-console-template for more information

using Task;

try
{
    Book book = new Book(1, "Title1", "Author1");
    Book book2 = new Book(2, "Title2", "Author2");
    Book book3 = new Book(3, "Title3", "Author3");
    Book book4 = new Book(4, "Title4", "Author4");
    Console.WriteLine($"Book number: {book.BookNumber}, Title: {book.Title}, Author: {book.Author}");
    Console.WriteLine($"Book number: {book2.BookNumber}, Title: {book2.Title}, Author: {book2.Author}");
    Console.WriteLine($"Book number: {book3.BookNumber}, Title: {book3.Title}, Author: {book3.Author}");
    Console.WriteLine($"Book number: {book4.BookNumber}, Title: {book4.Title}, Author: {book4.Author}");

    Library library = new Library(2);
    library.AddBook(book);
    library.AddBook(book2);
    library.AddBook(book3);
    library.GetBook(8);
}
catch (ArgumentNullException exc)
{
    Console.WriteLine("Error: " + exc.Message);
}
catch (IndexOutOfRangeException exc)
{
    Console.WriteLine("Error: " + exc.Message);
}
catch (ApplicationException exc)
{
    Console.WriteLine("Error: " + exc.Message);
}
finally
{
    Console.WriteLine("The code has been executed");
}
