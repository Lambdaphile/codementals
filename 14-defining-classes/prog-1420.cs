/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 20:
|
|     There is a book library. Define classes respectively
|     for a book and a library. The library must contain
|     a name and a list of books. The books must contain
|     the title, author, publisher, release date and ISBN-number.
|     In the class, which describes the library, create methods
|     to add a book to the library, to search for a book by
|     a predefined author, to display information about a book
|     and to delete a book from the library.
|
| Solutions and Guidelines:
|
|     Define classes Book and Library. For a list of books
|     use List<Book>
|
*/

using System;
using System.Collections.Generic;

namespace Program
{
    public class Library
    {
        private string name = null;
        private List<Book> bookshelf = new List<Book>();

        public string Name { get => name; }
        public List<Book> Bookshelf { get => bookshelf; set => bookshelf = value; }

        public Library()
            : this(null) { }

        public Library(string name)
        {
            this.name = name;
        }

        public void AddBook(string title, string author, string publisher, string realeseDate, string isbnNumber)
        {
            bookshelf.Add(new Book() { Title = title, Author = author, Publisher = publisher, RealeseDate = realeseDate, IsbnNumber = isbnNumber });
        }

        public void DeleteBook(string author)
        {
            bookshelf.Remove(new Book() { Author = author});
        }

        public void DisplayBookInfo(string title)
        {
            if (bookshelf.Exists(x => x.Title.Contains(title)))
                Console.WriteLine(bookshelf.Find(x => x.Title.Contains(title)));
            else
                Console.WriteLine($"\nSorry, couldn't find the book {title} in our library.");
        }

        public void DisplayBooksBy(string author)
        {
            List<Book> authorsBooks;
            if (Bookshelf.Exists(x => x.Author == author))
            {
                authorsBooks = Bookshelf.FindAll(x => x.Author.Contains(author));
                foreach (Book book in authorsBooks)
                    Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine($"Sorry, couldn't find books from {author}.");
            }
        }
    }

    public class Book
    {
        private string title = null;
        private string author = null;
        private string publisher = null;
        private string realeseDate = null;
        private string isbnNumber = null;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string RealeseDate { get => realeseDate; set => realeseDate = value; }
        public string IsbnNumber { get => isbnNumber; set => isbnNumber = value; }

        public override string ToString()
        {
            return $"\nTitle: {title}\nAuthor: {author}\nPublisher: {publisher}\nRelease Date: {realeseDate}\nISBN-number: {isbnNumber}.\n";
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Book objAsBook = obj as Book;
            if (objAsBook == null) return false;
            else return Equals(objAsBook);
        }
        public bool Equals(Book other)
        {
            if (other == null) return false;
            return (this.Author.Equals(other.Author));
        }
    }
}