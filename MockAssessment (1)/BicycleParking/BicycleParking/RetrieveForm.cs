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
    public partial class RetrieveForm : Form
    {
        
        string ticketNumber;
        BicycleParking oldParking;

        public RetrieveForm(BicycleParking bp, string ticketNumber)
        {
            InitializeComponent();
            oldParking = bp;
            this.ticketNumber = ticketNumber;
        }

        private void btnRetrieveBicycle_Click(object sender, EventArgs e)
        {
            double price = oldParking.RetrieveBicycle(ticketNumber, Convert.ToInt32(tbxHoursInParking.Text), tbxOwnerZipcode.Text);
            if (price == -1)
            {
                MessageBox.Show("No parked bicycle was found with the selected ticket number");
                this.Close();
                return;
            }
            MessageBox.Show("The total cost is " + price);
            this.Close();
        }
    }
}
