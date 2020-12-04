using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectAssignment2._2
{
    public partial class Form1 : Form
    {
        Course newCourse;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            newCourse = new Course();
            newCourse.SetName(tbxCourseName.Text);
            newCourse.SetEc(Convert.ToInt32(tbxCourseECs.Text));
        }
    }
}
