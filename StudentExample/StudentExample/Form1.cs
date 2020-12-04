using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentExample
{
    public partial class Form1 : Form
    {
        Student student;
        List<Student> studentList = new List<Student>();
   
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            student = new Student();
            student.SetName(tbxStudentName.Text);
            student.SetPcn(Convert.ToInt32(tbxPCN.Text));

            studentList.Add(student);

            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstStudent.Items.Clear();
            foreach (Student stud in studentList)
            {
                lstStudent.Items.Add(stud.GetInfo());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstStudent.Items.Clear();
            foreach(Student stud in studentList)
            {
                if (stud.GetPcn() == Convert.ToInt32(tbxPCN.Text))
                {
                    lstStudent.Items.Add(stud.GetInfo());
                }
            }
        }
    }
}
