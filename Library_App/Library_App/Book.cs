using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_App
{
    public class Book
    {
        private static int Seederid = 100; //unique book id

        private int id;
        private string title;
        private string author;
        private BookType bookType;
        private string borrowerInfo;
        private bool borrowed;
        
        public Book(string title, string author, BookType bookType)
        {
            this.title = title;
            this.author = author;
            this.bookType = bookType;
            Borrowed = false;
            id = Seederid;
            Seederid++;
        }

        public int Id
        {
            get { return this.id; }
        }

        public bool Borrowed
        {
            set{ borrowed = value; }
            get { return borrowed; }
        }

        public string BorrowerInfo
        {
            set
            {
                if (Borrowed)
                {
                    borrowerInfo = value;
                }
                else
                {
                    borrowerInfo = "No info";
                }
            }
            get { return borrowerInfo; }
        }

        public string GetInfo()
        {
            if (Borrowed)
            {
                return $"ID:{id}, Title:{title}, Author:{author}, BookType:{bookType}, Borrowed by:{borrowerInfo}";
            }
            else
            {
                return $"ID:{id}, Title:{title}, Author:{author}, BookType:{bookType}";
            }
        }


    }
}
