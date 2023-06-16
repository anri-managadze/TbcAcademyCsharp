
using LibrarySystem;

Library library = new Library();
library.setBookArray = 10;

Book book = new Book { Title="A",Author="ab",Year =1, Description = "a1"};
Book book1 = new Book { Title="B",Author="cd",Year =2, Description = "b2"};
Book book2 = new Book { Title="C",Author="ef",Year =3, Description = "c3"};
Book book3 = new Book { Title="D",Author="gh",Year =4, Description = "d4"};



library.AddBook(book);
library.AddBook(book1);
library.AddBook(book2);
library.AddBook(book3);

library.RemoveBook("B");


library.FindBook("A");
library.booksInlibrary();

