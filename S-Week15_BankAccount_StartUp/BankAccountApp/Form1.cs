using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccountApp
{
    public partial class Form1 : Form
    {

        BankAccount newAccount;

        public Form1()
        {
            InitializeComponent();
            newAccount = new BankAccount();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            newAccount.Withdraw(Convert.ToDouble(tbxAmount.Text));
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            newAccount.Deposit(Convert.ToDouble(tbxAmount.Text));
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
           lblShowAll.Text = newAccount.GetTransactions();
        }
    }
}
