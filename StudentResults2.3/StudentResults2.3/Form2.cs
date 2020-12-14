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
            cbxGrade.Items.Add(Grade.Poor);
            cbxGrade.Items.Add(Grade.Unsatisfactory);
            cbxGrade.Items.Add(Grade.Satisfactory);
            cbxGrade.Items.Add(Grade.Good);
            cbxGrade.Items.Add(Grade.Outstanding);
        }

        private void btnAddResult_Click(object sender, EventArgs e)
        {
            Grade givenGrade = (Grade)cbxGrade.SelectedItem;
            
            if (!Form1.stResult.AddResult(tbxCourseCode.Text, givenGrade))
            {
                MessageBox.Show("The grade for this course already exists");
                return;
            }
            UpdateListBox();
        }

        private void btnGetAllResults_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            lbxGetResults.Items.Clear();

            for (int i = 0; i < Form1.stResult.GetAllResults().Length; i++)
            {
                lbxGetResults.Items.Add(Form1.stResult.GetAllResults()[i].GetInfo());
            }
        }

        private void btnUpdateCourse_Click(object sender, EventArgs e)
        {
            Form1.stResult.UpdateResult(tbxUpdateCourse.Text, tbxRemark.Text);
            UpdateListBox();
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            Form1.stResult.RemoveResult(tbxRemoveCourse.Text);
            UpdateListBox();
        }

        private void btnPassed_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Form1.stResult.GetInfo());
        }
    }
}
