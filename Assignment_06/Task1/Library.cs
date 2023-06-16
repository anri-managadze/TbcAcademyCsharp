using LibrarySystem;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

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
            set 
            {
                _books[i] = value;
            }
        }
        public int setBookArray
        {
            set
            {
                _books = new Book[value];
            }
        }

        public void AddBook(Book book)
        {
            if (count < _books.Length)
            {
                _books[count] = book;
                count++;
            }
            Console.WriteLine($"This book added : Title: {book.Title}, Author: {book.Author}, Year: {book.Year},Description: {book.Description}");
        }
        public void RemoveBook(string title)
        {
            for (int i = 0; i < _books.Length; i++)
            {
                if (_books[i].Title == title)
                {
                    _books[i] = null;
                    count--;
                    Console.WriteLine($"{title} This Book removed");
                    break;
                }
            }
        }
        public void FindBook(string i)
        {
            for (int j = 0; j < _books.Length; j++)
            {
                if (i == _books[j].Title)
                {
                    Console.WriteLine("Found: " + i);
                    break;
                }
            }
        }
        public void booksInlibrary()
        {   
                Console.WriteLine("Book List in Library:");
                foreach (Book book in _books)
                {
                if (book != null)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Year: {book.Year},Description: {book.Description}");
                }
                else { continue; }
                }

                Console.WriteLine("Books count in library: " + count); 
        }

    }
}
