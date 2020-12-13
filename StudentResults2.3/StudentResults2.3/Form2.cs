using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentResults2._3
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            
        }

        private void btnGetAllResults_Click(object sender, EventArgs e)
        {
            Form1.stResult.GetAllResults();
        }
    }
}
