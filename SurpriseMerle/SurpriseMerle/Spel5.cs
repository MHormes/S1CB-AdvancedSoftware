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
    public partial class Spel5 : Form
    {
        string pass = "veel plezier";
        string pass2 = "veelplezier";
        public Spel5()
        {
            InitializeComponent();
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            if (tbxCode.Text.ToLower() == pass || tbxCode.Text.ToLower() == pass2)
            {
                Eind newForm = new Eind();
                this.Hide();
                newForm.ShowDialog();
                this.Close();

            }
            else
            {
                lblMess.Text = "De code is niet correct. Probeer het opnieuw";
            }
        }
    }
}
