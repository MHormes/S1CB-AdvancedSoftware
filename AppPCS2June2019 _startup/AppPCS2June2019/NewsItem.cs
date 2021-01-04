using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_MagazineApp
{
    public class NewsItem
    {
        public static int counter = 100;

        private string title;
        private string author;
        private NewsType type;
        private string content;
        private int id;

        public int Id
        { 
            get { return this.id; }
            set { this.id = value; }
        }

        public string Content
        {
            get { return this.content; }
            set { this.content = value; }
        }

        public string Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public string Author
        {
            get { return this.author; }
            set { this.author = value; }
        }

        public NewsType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public NewsItem(string title, string author, NewsType type)
        {
            this.title = title;
            this.author = author;
            this.type = type;
            this.id = counter;
            counter++;
        }

        public NewsItem(string title, string author, NewsType type, string content)
        {
            this.title = title;
            this.author = author;
            this.type = type;
            this.content = content;
            this.id = counter;
            counter++;
        }

        public string GetContent()
        {
            return this.content;
        }

        public string GetGeneralInfo()
        {
            return $"{this.title} written by {this.author}. ID: {this.id} & number of line:";
        }
    }
}
