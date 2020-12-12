using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SurpriseMerle
{
    public partial class Spel3 : Form
    {
        public Spel3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            label1.Text = "Dat is goed!";
            MessageBox.Show("Lees het volgende gedichtje. Ben je klaar? Klik dan op OK");

            Spel4 newform = new Spel4();
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            label1.Text = "Oh nee, dat was fout. Iemand is boos aan het worden!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            label1.Text = "Oh nee, dat was fout. Iemand is boos aan het worden!";
        }
    }
}
