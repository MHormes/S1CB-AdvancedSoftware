using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrazyRounding
{
    public partial class Form1 : Form
    {
        CrazyMath newMath = new CrazyMath();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (rbToWhole.Checked)
            {
                for(int i = 0; i < 10; i++)
                {
                    listBox1.Items.Add(newMath.RoundWholes(Convert.ToDouble(tbxInputNumber.Text)));
                }
            }
            else if (rbToTenth.Checked)
            {
                for (int i = 0; i < 10; i++)
                {
                    listBox1.Items.Add(newMath.RoundTenths(Convert.ToDouble(tbxInputNumber.Text)));
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    listBox1.Items.Add(newMath.RoundHundreths(Convert.ToDouble(tbxInputNumber.Text)));
                }
            }
        }
    }
}
