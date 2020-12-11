using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNGTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n;
            string randomStr = "";
            for (int i = 0; i < 10; i++)
            {
                int decideCharType = rnd.Next(3);

                if (decideCharType == 0) // Generate capital letter
                { n = rnd.Next(65, 91); }
                else if (decideCharType == 1)// Generate lowercase letter
                { n = rnd.Next(97, 123); }
                else // Generate a number
                { n = rnd.Next(48, 58); }
                // Convert integer to character
                randomStr += (char)n;
            }
            // Create and open the PopUpForm
            label1.Text = randomStr;
        }
    }
}
