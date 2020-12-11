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
    public partial class Spel3 : Form
    {
        public Spel3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblError.Text = "Dat is het goede antwoord!";
            pictureBox1.BackColor = Color.Green;
            MessageBox.Show("Lees het volgende gedichtje. Ben je klaar? Klik dan op OK");

            Spel5 newform = new Spel5();
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblError.Text = "Dat was niet het goede antwoord";
            pictureBox2.BackColor = Color.Red;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblError.Text = "Dat was niet het goede antwoord";
            pictureBox3.BackColor = Color.Red;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            lblError.Text = "Dat was niet het goede antwoord";
            pictureBox4.BackColor = Color.Red;
        }
    }
}
