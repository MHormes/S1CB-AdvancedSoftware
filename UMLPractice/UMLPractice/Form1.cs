using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMLPractice
{
    public partial class Form1 : Form
    {
        private ProjectGroup pg;

        public Form1()
        {
            InitializeComponent();
            pg = new ProjectGroup("Group 1");
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxMemberName.Text))
            {
                MessageBox.Show("Please give a name");
                return;
            }
            pg.AddMember(tbxMemberName.Text, tbxStudentNumber.Text);
        }

        private void btnGroupInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pg.GetInfo());
        }
    }
}
