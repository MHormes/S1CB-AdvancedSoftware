using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGrades
{
    public partial class Form1 : Form
    {
        Grade grade;
        List<Grade> gradeList = new List<Grade>();
        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateList()
        {
            lbxGrades.Items.Clear();

            foreach (Grade grad in gradeList)
            {
                lbxGrades.Items.Add(grad.GetInfo());
            }
            StatsUpdate();
        }

        public void StatsUpdate()
        {
            double fail = 0, pass = 0, u = 0, p = 0, s = 0, g = 0, o = 0;
            foreach(Grade grad in gradeList)
            {
                if(grad.GetGrade() == "P")
                {
                    fail += 1;
                    p += 1;
                }
                else if(grad.GetGrade() == "U")
                {
                    fail += 1;
                    u += 1;
                }
                else if (grad.GetGrade() == "S")
                {
                    pass += 1;
                    s += 1;
                }
                else if (grad.GetGrade() == "G")
                {
                    pass += 1;
                    g += 1;
                }
                else if (grad.GetGrade() == "O")
                {
                    pass += 1;
                    o += 1;
                }

            }

            lblPassed.Text = $"Passed: {(pass / gradeList.Count()) * 100}%";
            lblFail.Text = $"Failed: {(fail / gradeList.Count()) * 100}%";
            lblP.Text = $"P: {(p / gradeList.Count()) * 100}%";
            lblU.Text = $"U: {(u / gradeList.Count()) * 100}%";
            lblS.Text = $"S: {(s / gradeList.Count()) * 100}%";
            lblG.Text = $"G: {(g / gradeList.Count()) * 100}%";
            lblO.Text = $"O: {(o / gradeList.Count()) * 100}%";
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            grade = new Grade();
            grade.SetGrade(txbName.Text, Convert.ToString(cbGrade.SelectedItem));
            gradeList.Add(grade);
            UpdateList();
        }

        

    }
}
