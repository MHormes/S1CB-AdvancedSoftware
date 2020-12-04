using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerTest
{
    public partial class Form1 : Form
    {
        bool isOnOrNot = true;
        int timePassed = 0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timePassed += 1;
            lblTimer.Text = Convert.ToString(timePassed);
        }

        private void btnStopStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = isOnOrNot;
            isOnOrNot = !isOnOrNot;
        }
    }
}
