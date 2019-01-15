/*
|--------------------------------------------------------------------------
| Chapter 14. Defining Classes
|--------------------------------------------------------------------------
|
| Exercise 21:
|
|     Write a test class, which creates an object of type
|     library, adds several books to it and displays information
|     about each of them. Implement a test functionality, which
|     finds all books authored by Stephen King and deletes them.
|     Finally, display information for each of the remaining books.
|
| Solutions and Guidelines:
|
|     Follow the instructions directly from the requirements
|     of the task.
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
        private List<Book> bookShielf = new List<Book>();

        public string Name { get => name; }
        public List<Book> BookShielf { get => bookShielf; set => bookShielf = value; }

        public Library()
            : this(null) { }

        public Library(string name)
        {
            this.name = name;
        }

        public void AddBook(string title, string author, string publisher, string realeseDate, string isbnNumber)
        {
            bookShielf.Add(new Book() { Title = title, Author = author, Publisher = publisher, RealeseDate = realeseDate, IsbnNumber = isbnNumber });
        }

        public void DeleteBook(string author)
        {
            
                bookShielf.Remove(new Book() { Author = author});
        }

        public void DisplayBookInfo(string title)
        {
            if (bookShielf.Exists(x => x.Title.Contains(title)))
                Console.WriteLine(bookShielf.Find(x => x.Title.Contains(title)));
            else
                Console.WriteLine($"\nSorry, couldn't find the book {title} in our library.");
        }

        public void DisplayBooksBy(string author)
        {
            List<Book> authorsBooks;
            if (BookShielf.Exists(x => x.Author == author))
            {
                authorsBooks = BookShielf.FindAll(x => x.Author.Contains(author));
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

    public class LibraryTest
    {
        public static void DisplayLibraryBooks(Library library)
        {
            foreach (Book book in library.BookShielf)
                Console.WriteLine(book);
        }

        public static List<Book> DeleteBooksByStephenKing(Library library)
        {
            library.BookShielf.RemoveAll(x => x.Author == "Stephen King");
            return library.BookShielf;
        }

        public static void Main(string[] args)
        {
            Library chewbacca = new Library("Chewbacca's Public Library");
            chewbacca.AddBook("Mistborn: The Final Empire", "Brandon Sanderson", "Tor Books", "25/07/2006", "076531178X");
            chewbacca.AddBook("Mistborn: The Well Of Ascension", "Brandon Sanderson", "Tor Books", "21/08/2007", "0765316889");
            chewbacca.AddBook("Mistborn: The Hero Of Ages", "Brandon Sanderson", "Tor Books", "14/10/2008", "0765316897 ");
            chewbacca.AddBook("It", "Stephen King", "New English Library", "1/10/1987", "0450411435");
            chewbacca.AddBook("The Shinning", "Stephen King", "New English Library", "1/07/1980", "0450040186");

            DisplayLibraryBooks(chewbacca);

            chewbacca.BookShielf = DeleteBooksByStephenKing(chewbacca);

            DisplayLibraryBooks(chewbacca);
        }
    }
}