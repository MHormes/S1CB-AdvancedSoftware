using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicService
{
    public class User
    {
        public static List<Song> FavoList = new List<Song>();
        private string name;
        private string email;
        private string address;

        public User(string name, string email)
        {
            this.name = name;
            this.email = email;
        }

        public User(string name, string email , string address)
        {
            this.name = name;
            this.email = email;
            this.address = address;
        }

        public void AddSongsToFavourates(Song s)
        {
            if (FavoList.Contains(s))
            {
                return;
            }
            FavoList.Add(s);
        }

        public void RemoveFromFavourates(Song s)
        {
            if (FavoList.Contains(s))
            {
                FavoList.Remove(s);
            }
        }

        public string GetFavoriteSongs()
        {
           string favorites = $"Favorite songs of {name}: \r\n";
           foreach(Song s in FavoList)
            {
                favorites +=  $"{s.GetInfo()} \r\n";
            }
            return $"{name} has no favorite songs";
        }

        public string GetInfo()
        {
            return $"{this.name} - {this.email} - {this.address}";
        }

        public string GetEmail()
        {
            return this.email;
        }
    }
}
