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
    public partial class Spel1 : Form
    {
        public Spel1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lblFoutWorm.Text = "Dat is het goede antwoord!";
            pbWorm.BackColor = Color.Green;

            MessageBox.Show("Lees het volgende gedichtje. Ben je klaar? Klik dan op OK");

            Spel2 newform = new Spel2();
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblFoutWorm.Text = "Dat was niet het goede antwoord. Probeer het nog een keer!";
            pbWorm.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblFoutWorm.Text = "Dat was niet het goede antwoord. Probeer het nog een keer!";
            pbWorm.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lblFoutWorm.Text = "Dat was niet het goede antwoord. Probeer het nog een keer!";
            pbWorm.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lblFoutWorm.Text = "Dat was niet het goede antwoord. Probeer het nog een keer!";
            pbWorm.BackColor = Color.Red;
        }
    }
}
