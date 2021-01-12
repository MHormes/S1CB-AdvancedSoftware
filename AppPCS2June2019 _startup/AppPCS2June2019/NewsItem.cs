using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCS2June2019
{
   public class NewsItem
    {
        public static int IdSeeder = 101;

        private int id;
        private String title;
        private String author;
        private NewsType type;

        private List<String> lines;

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public String Title
        {
            get { return this.title; }
            set { this.title = value; }
        }

        public String Author
        {
            get { return this.author; }
            set { this.author = value;}
        }

        public NewsItem(string title, string author, NewsType t)
        {
            Title = title;
            this.author = author;
            this.type = t;
            lines = new List<string>();
            Id = IdSeeder;
            IdSeeder++;
        }

        public NewsItem(string title, string author, string firstLine, NewsType t)
        {
            Title = title;
            this.author = author;
            this.type = t;
            lines = new List<string>();
            lines.Add(firstLine);
            Id = IdSeeder;
            IdSeeder++;
        }

        public void AddLine(string aLine)
        {
            this.lines.Add(aLine);
        }

        public bool InsertLineAtIndex(int index, string aLine)
        {
            if (index < lines.Count)
            {
                this.lines.Insert(index, aLine);
                return true;
            }
            return false;
        }

        public List<string> GetAllLines()
        {
            return this.lines;
        }

        public string GetGeneralInfo()
        {
            return $"Id: {Id}, {Title}; by author {this.author}, {lines.Count} lines.";
        }
    }
}
