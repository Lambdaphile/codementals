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
using System.Linq;

namespace Program
{
    public class Library
    {
        private string name = null;
        private List<Book> books = new List<Book>();

        public string Name { get => name; }
        public List<Book> Books { get => books; }

        public Library()
            : this(null) { }

        public Library(string name)
        {
            this.name = name;
        }

        public void AddBook(string title, string author, string publisher, string realeseDate, string isbnNumber)
        {
            books.Add(new Book() { Title = title, Author = author, Publisher = publisher, RealeseDate = realeseDate, IsbnNumber = isbnNumber });
        }

        public void SearchBook(string author)
        {
            if (books.Exists(x => x.Author == author))
                Console.WriteLine(books.Find(x => x.Author.Contains(author)));
            else
                Console.WriteLine($"\nNo books from the given author: \"{author}\"");
        }

        public void DisplayInfo(string title)
        {
            if (books.Exists(x => x.Title == title))
                Console.WriteLine(books.Find(x => x.Title.Contains(title)));
            else
                Console.WriteLine($"\nNo books with title: {title}");
        }

        public void DeleteBook(string title)
        {
            books.Remove(new Book() { Title = title });
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
            return (this.Title.Equals(other.Title));
        }
    }
}