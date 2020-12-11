using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Merle
{
    public partial class Spel2 : Form
    {
        public Spel2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblMonoBoos.Text = "Dat is correct!";
            pictureBox2.Visible = false;
            MessageBox.Show("Lees het volgende gedichtje. Ben je klaar? Klik dan op OK");

            Spel3 newform = new Spel3();
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblMonoBoos.Text = "Oh nee, dat is fout. Iemand wordt boos.";
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblMonoBoos.Text = "Oh nee, dat is fout. Iemand wordt boos.";
            pictureBox2.Visible = true;
        }
    }
}
