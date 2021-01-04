using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week14_MagazineApp
{
    public class Magazine
    {
        private string name;
        List<NewsItem> newsList;

        public Magazine(string name)
        {
            this.name = name;
            newsList = new List<NewsItem>();
        }

        public void AddNewsItem(string title, string author, NewsType type)
        {
            NewsItem newItem = new NewsItem(title, author, type);
            newsList.Add(newItem);
        }

        public void AddNewsItem(string title, string author, NewsType type, string content)
        {
            NewsItem newItem = new NewsItem(title, author, type, content);
            newsList.Add(newItem);
        }

        public bool EditNewsItem(int id)
        {
            foreach (NewsItem nI in newsList)
            {
                if (nI.Id == id)
                {
                    return true;
                }
            }
            return false;
        }

        public bool RemoveNewsItem(int id)
        {
            foreach (NewsItem nI in newsList)
            {
                if (nI.Id == id)
                {
                    newsList.Remove(nI);
                    return true;
                }
            }
            return false;
        }

        public List<NewsItem> GetNewsItems()
        {
            return this.newsList;
        }

        public string GetRandomNewsItem()
        {
            Random rnd = new Random();
            return newsList[rnd.Next(newsList.Count)].Content;  
        }
    }
}
