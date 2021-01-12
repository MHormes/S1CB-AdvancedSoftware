using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZebraFarm
{
    public partial class Form1 : Form
    {

        ZebraFarm myFarm;

        public Form1()
        {
            InitializeComponent();
            myFarm = new ZebraFarm("Farm Striped");
            this.Text = myFarm.Name;
            cbxZebraFilter.SelectedIndex = 0;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lbxZebras.Items.Clear();
            switch (cbxZebraFilter.SelectedIndex)
            {
                case 0:
                    {
                        for(int i = 0; i < myFarm.GetZebras().Length; i++)
                        {
                            lbxZebras.Items.Add(myFarm.GetZebras()[i].GetInfo());
                        }
                        break;
                    }
                case 1:
                    {
                        for(int i = 0; i < myFarm.GetZebras(Gender.MARE).Length; i++)
                        {
                            lbxZebras.Items.Add(myFarm.GetZebras(Gender.MARE)[i].GetInfo());
                        }
                        break;
                    }
                case 2:
                    {
                        for (int i = 0; i < myFarm.GetZebras(Gender.STALLION).Length; i++)
                        {
                            lbxZebras.Items.Add(myFarm.GetZebras(Gender.STALLION)[i].GetInfo());
                        }
                        break;
                    }
                case 3:
                    {
                        for (int i = 0; i < myFarm.GetZebras(Gender.UNKNOWN).Length; i++)
                        {
                            lbxZebras.Items.Add(myFarm.GetZebras(Gender.UNKNOWN)[i].GetInfo());
                        }
                        break;
                    }
            }
        }

        private void btnAttemptBreeding_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbxFatherId.Text) || string.IsNullOrWhiteSpace(tbxMotherId.Text))
            {
                MessageBox.Show("Please give 2 id's before clicking the button");
                return;
            }
            if (myFarm.AttemptToBread(Convert.ToInt32(tbxMotherId.Text), Convert.ToInt32(tbxFatherId.Text)))
            {
                MessageBox.Show("A new Zebra is born");
                return;
            }
            MessageBox.Show("Nothing happend");

        }

        private void btnShowZebra_Click(object sender, EventArgs e)
        {
            DetailsForm newForm = new DetailsForm(myFarm, Convert.ToInt32(tbxSearchZebra.Text));
            newForm.ShowDialog();
        }        
    }
}
