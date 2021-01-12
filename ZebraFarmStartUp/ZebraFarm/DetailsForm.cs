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
    public partial class DetailsForm : Form
    {
        ZebraFarm oldFarm;
        int chosenId;
        public DetailsForm(ZebraFarm zf, int id)
        {
            InitializeComponent();
            oldFarm = zf;
            chosenId = id;
            Zebra chosenOne = oldFarm.GetZebra(id);
            if (chosenOne != null)
            {
                this.Text = $"Zebra with id {chosenOne.Id}";
                tbxZebraName.Text = chosenOne.Name;
                if (chosenOne.Gender == Gender.STALLION)
                {
                    rbnZebraGenderStallion.Select();
                }
                else if (chosenOne.Gender == Gender.MARE)
                {
                    rbnZebraGenderMare.Select();
                }
                else
                {
                    rbnZebraGenderUnknown.Select();
                }
            }
            else
            {
                MessageBox.Show("No zebra was found with this id");
                tbxZebraName.Enabled = false;
                rbnZebraGenderStallion.Enabled = false;
                rbnZebraGenderMare.Enabled = false;
                rbnZebraGenderUnknown.Enabled = false;
                btnUpdateAndClose.Enabled = false;
            }
            
        }

        private void btnUpdateAndClose_Click(object sender, EventArgs e)
        {
            Zebra chosenOne = oldFarm.GetZebra(chosenId);
            chosenOne.Name = tbxZebraName.Text;
            if (rbnZebraGenderMare.Checked)
            {
                chosenOne.Gender = Gender.MARE;
            }
            else if (rbnZebraGenderStallion.Checked)
            {
                chosenOne.Gender = Gender.STALLION;
            }
            else
            {
                chosenOne.Gender = Gender.UNKNOWN;
            }
            this.Close();
        }
    }
}
