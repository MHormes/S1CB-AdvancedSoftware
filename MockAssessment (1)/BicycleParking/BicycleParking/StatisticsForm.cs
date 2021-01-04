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
    public partial class StatisticsForm : Form
    {
        BicycleParking oldParking;
        string partialZipcode;

        public StatisticsForm(BicycleParking bp, string partialZipcode)
        {
            InitializeComponent();
            oldParking = bp;
            this.partialZipcode = partialZipcode;
            this.Text = "Statistics for zipcode " + partialZipcode;

            bp.GetAllRetrievedBicyclesByZipcode(partialZipcode);
            foreach(Bicycle bic in bp.GetAllRetrievedBicyclesByZipcode(partialZipcode))
            {
                lbxBicycles.Items.Add(bic.GetInfo());
            }
        }
    }
}
