using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPCS2June2019
{
    public partial class SpecificForm : Form
    {
       
        public SpecificForm(NewsItem specificItem)
        {
            InitializeComponent();
            this.Text = "About a specific news-item";

            lblGeneralInfo.Text = specificItem.GetGeneralInfo();
            foreach(string s in specificItem.GetAllLines())
            {
                lbxAllLines.Items.Add(s);
            }
        }
    }
}
