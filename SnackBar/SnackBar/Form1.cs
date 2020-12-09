using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnackBar
{
    public partial class Form1 : Form
    {
        SnackBar sb = new SnackBar();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            switch(sb.ProcessOrder(Convert.ToInt32(nudFrikandel.Value), Convert.ToInt32(nudKroket.Value), Convert.ToInt32(nudMexicano.Value)))
            {
                case "frikandel":
                    MessageBox.Show("There is not enough stock of frikandel for your order");
                    break;

                case "kroket":
                    MessageBox.Show("There is not enough stock of kroket for your order");
                    break;

                case "mexicano":
                    MessageBox.Show("There is not enough stock of mexicano for your order");
                    break;

                case "":
                    MessageBox.Show($"Your order is placed. Please pay {SnackBar.price} Euro(s)");
                    break;

            }
        }

        private void btnShowRevenue_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{sb.GetRevenue()}");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbFrikandel.Checked)
            {
                sb.SetNewStockOrPrice("frikandel", Convert.ToInt32(nudNewStock.Value), Convert.ToDouble(nudNewPrice.Value));
            }
            if (rbKroket.Checked)
            {
                sb.SetNewStockOrPrice("kroket", Convert.ToInt32(nudNewStock.Value), Convert.ToDouble(nudNewPrice.Value));
            }
            if (rbMexicano.Checked)
            {
                sb.SetNewStockOrPrice("mexicano", Convert.ToInt32(nudNewStock.Value), Convert.ToDouble(nudNewPrice.Value));
            }
        }

        private void btnShowAllInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sb.GetAllInfo());
        }
    }
}
