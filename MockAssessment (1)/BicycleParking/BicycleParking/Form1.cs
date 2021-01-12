using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BicycleParking
{
    public partial class Form1 : Form
    {
        BicycleParking myParking;

        public Form1()
        {
            InitializeComponent();
            myParking = new BicycleParking(1.20, 0.50);
        }

        private void btnParkBicycle_Click(object sender, EventArgs e)
        {
            string s = myParking.ParkBicycle(GetRbCheck());
            cbbTicketnumbers.Items.Add(s);
            lblTicketNumber.Text = s;
        }

        private void btnRetrieveBicycle_Click(object sender, EventArgs e)
        {
            RetrieveForm newForm = new RetrieveForm(myParking, cbbTicketnumbers.SelectedItem.ToString());
            newForm.ShowDialog();
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            string partialZipcode = tbxPartialZipcode.Text;
            StatisticsForm newForm = new StatisticsForm(myParking, partialZipcode);
            newForm.ShowDialog();
        }

        private BicycleType GetRbCheck()
        {
            BicycleType givenType;

            if (rbnElectric.Checked)
            {
                givenType = BicycleType.ELECTRIC;
            }
            else if (rbnFolding.Checked)
            {
                givenType = BicycleType.FOLDING;
            }
            else if (rbnNormal.Checked)
            {
                givenType = BicycleType.NORMAL;
            }
            else
            {
                givenType = BicycleType.TANDEM;
            }

            return givenType;
        }
    }
}
