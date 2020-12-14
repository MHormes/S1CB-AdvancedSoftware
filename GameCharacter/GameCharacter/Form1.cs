using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCharacter
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        GameCharacter gc;
        GameCharacter gc1;
        public Form1()
        {
            InitializeComponent();
            gc = new GameCharacter("MyMan", random.Next(75, 101));
            gc1 = new GameCharacter("HisMan", random.Next(75, 101));
            lblHealthStatus.Text = gc.GetHealthInfo();
            lblHealthgc1.Text = gc1.GetHealthInfo();
        }

        private void btnDealDmg_Click(object sender, EventArgs e)
        {
            gc.RecievedDamage(Convert.ToInt32(tbxDmgChar1.Text));
            lblHealthStatus.Text = gc.GetHealthInfo();
        }

        private void btnDealDmgChar2_Click(object sender, EventArgs e)
        {
            gc1.RecievedDamage(Convert.ToInt32(tbxDmgChar1.Text));
            lblHealthgc1.Text = gc1.GetHealthInfo();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            MessageBox.Show(GameCharacter.CompareHealth(gc, gc1).Name);
        }
    }
}
