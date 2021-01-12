using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPCS2June2019
{
    public class Magazine
    {
        private string name;

        private List<NewsItem> itemList;
        private List<NewsItem> madeByAuthor;

        public Magazine(string name)
        {
            this.name = name;
            itemList = new List<NewsItem>();
        }

        public NewsItem GetNewsItem(int id)
        {
            foreach(NewsItem nI in itemList)
            {
                if(nI.Id == id)
                {
                    return nI;
                }
            }
            return null;
        }

        public void AddNewsItem(string title, string author, NewsType t)
        {
            NewsItem newItem = new NewsItem(title, author, t);
            itemList.Add(newItem);
        }

        public void AddNewsItem(string title, string author, string firstLine, NewsType t)
        {
            NewsItem newITem = new NewsItem(title, author, firstLine, t);
            itemList.Add(newITem);
        }

        public bool RemoveNewsItem(int id)
        {
            for(int i = 0; i < itemList.Count(); i++)
            {
                if(itemList[i].Id == id)
                {
                    itemList.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }

        public bool AddLineToNewsItem(int id, string aLine)
        {
            foreach(NewsItem nI in itemList)
            {
                if(nI.Id == id)
                {
                    nI.AddLine(aLine);
                    return true;
                }
            }
            return false;
        }

        public bool InsertLineToNewsItem(int id, int index, string aLine)
        {
            foreach(NewsItem nI in itemList)
            {
                if(nI.Id == id)
                {
                    if(nI.InsertLineAtIndex(index, aLine))
                    {
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        public List<NewsItem> GetAllNewsItems()
        {
            return this.itemList;
        }

        public List<NewsItem> GetAllNewsItems(string author)
        {
            madeByAuthor = new List<NewsItem>();
            foreach(NewsItem nI in itemList)
            {
                if(nI.Author.Contains(author))
                {
                    madeByAuthor.Add(nI);
                }
            }

            return madeByAuthor;
        }
    }
}
