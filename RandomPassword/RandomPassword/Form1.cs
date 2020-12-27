using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPassword
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            lbxPasswords.Items.Clear();
            foreach(string s in PasswordGenerator.GeneratePasword(Convert.ToInt32(nudLength.Value), Convert.ToInt32(nudAmountPasswords.Value), checkBox1.Checked))
            {
                lbxPasswords.Items.Add(s);
            }
            
        }
    }
}
