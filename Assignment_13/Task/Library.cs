using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Library
    {
        private List<Book> _book;
        public int Capacity { get; set; }
        public Library(int capacity)
        {
            _book = new List<Book>();
            Capacity = capacity;
        }
        public void AddBook (Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException("Book is Mandatory");
            }else if (_book.Count > Capacity)
            {
                throw new IndexOutOfRangeException("The number of books is more than the capacity!");
            }
            else
            {
                _book.Add(book);
                Console.WriteLine($"The book with the author: {book.Author} has been successfully added!");
            }
        }
        public Book GetBook (int id)
        {
            foreach (Book book in _book)
            {
                if ( book.Id == id)
                {
                    
                    Console.WriteLine("Book is: " + book.Author);
                    return book;
                }
            }
            throw new BookNotFoundException(id);
        }
    }
}
