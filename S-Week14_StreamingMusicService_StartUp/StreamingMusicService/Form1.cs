using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamingMusicService
{
    public partial class Form1 : Form
    {
        private StreamingMusicService musicSvc;

        public Form1()
        {
            InitializeComponent();
            // Initialize required object
            this.musicSvc = new StreamingMusicService("YoMusicfy");
            // Populate with some songs
            this.musicSvc.AddSong("Queen", "Bohemian Rhapsode", 354);
            this.musicSvc.AddSong("Tjesto", "Red Lights", 262);
            this.musicSvc.AddSong("Lady Gaga", "Shallow", 216);
            this.musicSvc.AddSong("Queen", "Don't Stop Me Now", 218);
            this.musicSvc.AddSong("Hugh Jackman, Keala Settly, NY Orchestram, The Greatest Showman Esemble, Zac Efron, Zendaya", "The Greatest Show", 302);
            //change title of the form
            this.Text = this.musicSvc.GetInfo();

        }

        private void UpdateTitleAndSongs()
        {
            lbxAllSongs.Items.Clear();
            lbxSongChoise.Items.Clear();
            for (int i = 0; i < musicSvc.GetSongs().Length; i++)
            {
                lbxAllSongs.Items.Add(musicSvc.GetSongs()[i].GetInfo());
                lbxSongChoise.Items.Add(musicSvc.GetSongs()[i].GetInfo());
            }

            lbxAllUsers.Items.Clear();
            for(int i = 0; i < musicSvc.GetUsers().Length; i++)
            {
                lbxAllUsers.Items.Add(musicSvc.GetUsers()[i].GetInfo());
            }

            this.Text = this.musicSvc.GetInfo();
        }

        private void btnShowAllSongs_Click(object sender, EventArgs e)
        {
            UpdateTitleAndSongs();
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            this.musicSvc.AddSong(tbxArtistToAdd.Text, tbxSongToAdd.Text, Convert.ToInt32(nudSecondsToAdd.Value));
            UpdateTitleAndSongs();
        }

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            UpdateTitleAndSongs();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            musicSvc.AddUser(tbxUserToAdd.Text, tbxEmailToAdd.Text, tbxAdressToAdd.Text);
            UpdateTitleAndSongs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateTitleAndSongs();
        }

        private void btnAddFavorite_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < musicSvc.GetSongs().Length; i++)
            {
                
                if(musicSvc.GetSongs()[i].GetId() == lbxSongChoise.SelectedIndex +1)
                {
                    int id = musicSvc.GetSongs()[i].GetId();
                    musicSvc.GetUser(tbxUserToAddFavo.Text).AddSongsToFavourates(musicSvc.GetSong(id));
                    lbxFavorites.Items.Add(musicSvc.GetSongs()[i].GetInfo());
                }
            }
            lbxFavorites.Items.Clear();
            lbxFavorites.Items.Add(musicSvc.GetUser(tbxUserToAddFavo.Text).GetFavoriteSongs());
        }

        private void btnShowFavorites_Click(object sender, EventArgs e)
        {
            lbxFavorites.Items.Clear();
            lbxFavorites.Items.Add(musicSvc.GetUser(tbxUserToAddFavo.Text).GetFavoriteSongs());
        }
    }
}
