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

            this.Text = this.musicSvc.GetInfo();
        }

        private void UpdateTitleAndSongs()
        {
            for (int i = 0; i < musicSvc.GetSongs().Length; i++)
            {
                lbxAllSongs.Items.Add(musicSvc.GetSongs()[i].GetInfo());
            }

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


    }
}
