using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    public class Library
    {
        private List<Book> bookList = new List<Book>();
        private string name;

        public Library(string name)
        {
            this.name = name;
        }

        public void AddBook(Book book)
        {
            if (bookList.Contains(book))
            {
                return;
            }
            bookList.Add(book);
        }

        public bool RemoveBook(int id)
        {
            foreach(Book book in bookList)
            {

            }

            /*
            for(int i = 0; i < bookList.Count; i++)
            {
                if(bookList[i].Id == id)
                {
                    bookList.RemoveAt(i);
                    return true;
                }
            }*/
            return false;
        }

        public Book GetBookById(int id)
        {
            foreach(Book book in bookList)
            {
                if(book.Id == id)
                {
                    return book;
                }
            }
            return null;
        }

        public List<Book> GetAllBooks()
        {
            return bookList;
        }

        public List<Book> GetAvailableBooks()
        {
            List<Book> availableBooks = new List<Book>();
            foreach(Book book in bookList)
            {
                if (!book.Borrowed)
                {
                    availableBooks.Add(book);
                }
            }
            return availableBooks;
        }

        public List<Book> GetBorrowedBooks()
        {
            List<Book> borrowedBooks = new List<Book>();
            foreach(Book book in bookList)
            {
                if (book.Borrowed)
                {
                    borrowedBooks.Add(book);
                }
            }
            return borrowedBooks;
        }
    }

    
}
