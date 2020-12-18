using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_App
{
    public partial class Form1 : Form
    {
        public static string info;

        Library myLibrary = new Library("Maartens Library");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BookType bookType;
            if (rbtnDatabase.Checked)
            {
                bookType = BookType.DATABASE;
            }
            else if (rbtnMiscellaneous.Checked)
            {
                bookType = BookType.MISCELLANEOUS;
            }
            else
            {
                bookType = BookType.PROGRAMMING;
            }
            Book newbook = new Book(tbTitle.Text, tbAuthor.Text, bookType);
            myLibrary.AddBook(newbook);
            UpdateListBox();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void btnShowBooksThatAre_Click(object sender, EventArgs e)
        {
            if (rbtnAvailable.Checked)
            {
                lbLibrary.Items.Clear();
               foreach(Book book in myLibrary.GetAvailableBooks())
               {
                    lbLibrary.Items.Add(book.GetInfo());
               }
            }
            else if (rbtnBorrowed.Checked)
            {
                lbLibrary.Items.Clear();
                foreach (Book book in myLibrary.GetBorrowedBooks())
                {
                    lbLibrary.Items.Add(book.GetInfo());
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (myLibrary.RemoveBook(Convert.ToInt32(tbId.Text)))
            {
                UpdateListBox();
                return;
            }
            MessageBox.Show("Sorry, no book with the specified ID");
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Book currentBook = myLibrary.GetBookById(Convert.ToInt32(tbId.Text));
            if (currentBook == null)
            {
                MessageBox.Show("Sorry, no book with specified ID");
                return; 
            }
            currentBook.Borrowed = false;
            currentBook.BorrowerInfo = "";
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Book currentBook = myLibrary.GetBookById(Convert.ToInt32(tbId.Text));
            if (currentBook == null)
            {
                MessageBox.Show("Sorry, no book with specified ID");
                return;
            }

            if (currentBook.Borrowed == true)
            {
                MessageBox.Show("This book is already being borrowed");
                return;
            }
            else
            {
                string bookInfo = currentBook.GetInfo();
                BorrowForm borrowForm = new BorrowForm(this, bookInfo);
                borrowForm.Show();
            }
        }

        private void UpdateListBox()
        {
            lbLibrary.Items.Clear();
            foreach (Book book in myLibrary.GetAllBooks())
            {
                lbLibrary.Items.Add(book.GetInfo());
            }
        }

        public void SetBorrowInfo(string borrower)
        {
            Book book = myLibrary.GetBookById(Convert.ToInt32(tbId.Text));
            book.Borrowed = true;
            book.BorrowerInfo = borrower;
        }
    }
}
