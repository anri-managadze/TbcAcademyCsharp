using Task;

try
{
    Book book = new Book(1," Knightriders", "Stephen Edwin King");
    Book book1 = new Book(2, "Meyers ","Ernest Miller Hemingway");
    Book book2 = new Book(3, "Actual Size ","Steve Jenkins ");

    Library library = new Library(1);
    library.AddBook(book);
    library.AddBook(book1);
    library.AddBook(book2);
    library.GetBook(4);
}
catch (ArgumentException a)
{
    Console.WriteLine("Exception: " + a.Message);
}
catch (IndexOutOfRangeException a)
{
    Console.WriteLine("Exception: " + a.Message);
}
catch (BookNotFoundException a)
{
    Console.WriteLine("Exception: " + a.Message);
}
