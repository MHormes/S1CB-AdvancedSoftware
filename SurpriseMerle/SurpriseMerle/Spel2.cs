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
    }
}
