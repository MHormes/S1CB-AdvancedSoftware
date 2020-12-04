using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApplication
{
    public partial class Form1 : Form
    {
        Car myCar;
        Car myCar2;
        public Form1()
        {
            myCar = new Car();
            myCar.SetBrand("BMW");
            myCar.SetMaxSpeed(260);

            myCar2 = new Car();
            myCar2.SetBrand("Volvo");
            myCar2.SetMaxSpeed(240);
            InitializeComponent();

            lblBMW.Text = myCar.GetInfo();
            lblVolvo.Text = myCar2.GetInfo();
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                myCar.SpeedUp();
                lblBMW.Text = myCar.GetInfo();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                myCar2.SpeedUp();
                lblVolvo.Text = myCar2.GetInfo();
            }
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                myCar.SlowDown();
                lblBMW.Text = myCar.GetInfo();
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                myCar2.SlowDown();
                lblVolvo.Text = myCar2.GetInfo();
            }
        }
    }
}
