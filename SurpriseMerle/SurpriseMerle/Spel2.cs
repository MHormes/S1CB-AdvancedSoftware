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
    public partial class Spel2 : Form
    {
        public Spel2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Spel3 newForm = new Spel3();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.Green;
            label5.Text = "Dat is het juiste spel!";
            MessageBox.Show("Lees het volgende gedichtje. Ben je klaar? Klik dan op OK");

            Spel3 newform = new Spel3();
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label3.BackColor = Color.Red;
            label5.Text = "Een party spel is het zeker, maar niet het spel dat we zoeken.";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label4.BackColor = Color.Red;
            label5.Text = "Een party spel is het zeker, maar niet het spel dat we zoeken.";
        }
    }
}
