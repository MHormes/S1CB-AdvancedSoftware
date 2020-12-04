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
        public Form1()
        {
            myCar = new Car();
            myCar.SetBrand("BMW");
            myCar.SetMaxSpeed(260);
            InitializeComponent();

            lblCarInfo.Text = myCar.GetInfo();
        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            myCar.SpeedUp();
            lblCarInfo.Text = myCar.GetInfo();
        }

        private void btnBrake_Click(object sender, EventArgs e)
        {
            myCar.SlowDown();
            lblCarInfo.Text = myCar.GetInfo();
        }
    }
}
