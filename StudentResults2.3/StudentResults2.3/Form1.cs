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
    public partial class Form1 : Form
    {
        public static StudentResults stResult;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            stResult = new StudentResults(Convert.ToInt32(tbxStudentNumber.Text), tbxStudentName.Text);
            Form2 newForm = new Form2();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
