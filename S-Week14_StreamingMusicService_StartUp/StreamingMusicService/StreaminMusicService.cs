using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicService
{
    public class StreamingMusicService
    {
        private int songIdSeeder;
        private string name;
        private List<Song> songs;
        private List<User> userList;

        public StreamingMusicService(string name)
        {
            this.songIdSeeder = 1;
            this.name = name;
            this.songs = new List<Song>();
            this.userList = new List<User>();
        }

        public void AddSong(string artist, string title, int durationInSeconds)
        {
            this.songs.Add(new Song(this.songIdSeeder, artist, title, durationInSeconds));
            this.songIdSeeder++;
        }

        public Song GetSong(int id)
        {
            foreach (Song s in this.songs)
            {
                if (id == s.GetId())
                { return s; }
            }
            return null;
        }

        public Song[] GetSongs()
        {
            return this.songs.ToArray();
        }

        public Song[] GetSongs(string artist)
        {
            List<Song> foundSongs = new List<Song>();
            foreach (Song s in this.songs)
            {
                if(artist == s.GetArtist())
                { foundSongs.Add(s); }
            }
            return foundSongs.ToArray();
        }

        public void AddUser(string name, string email, string address)
        {
            User newUser = new User(name, email, address);
            userList.Add(newUser);
        }

        public string GetInfo()
        {
            return $"Streaming Music service: {this.name} ({this.songs.Count} songs & {this.userList.Count} users)";
        }

        public User GetUser(string name)
        {
            foreach(User user in userList)
            {
                if(user.GetName() == name)
                {
                    return user;
                }
            }
            return null;
        }

        public User[] GetUsers()
        {
            return this.userList.ToArray();
        }
    }
}
