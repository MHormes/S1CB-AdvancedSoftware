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
        Bank myBank = new Bank("Maarten");

        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            myBank.WithdrawFrom(Convert.ToInt32(tbxNumberForTrans.Text), Convert.ToDouble(tbxAmount.Text));
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            myBank.DepositToAccount(Convert.ToInt32(tbxNumberForTrans.Text), Convert.ToDouble(tbxAmount.Text));
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
           lbxAccounts.Items.Clear();
           for(int i = 0; i < myBank.GetAllAccounts().Length; i++)
            {
                lbxAccounts.Items.Add(myBank.GetAllAccounts()[i]);
            }
           
        }

        private void btnMakeAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Account with number: {Convert.ToString(myBank.CreateAccount(tbxNewName.Text))} created succesfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbxAccounts.Items.Clear();
            for(int i = 0; i < myBank.GetAllAccountsWithName(tbxFilterName.Text).Length; i++)
            {
                lbxAccounts.Items.Add(myBank.GetAllAccountsWithName(tbxFilterName.Text)[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myBank.GetAccountInfo(Convert.ToInt32(tbxFilterNumber.Text)));
        }

        private void btnSowTransactions_Click(object sender, EventArgs e)
        {
            lblShowTrans.Text = myBank.GetTransactionsWithNmr(Convert.ToInt32(tbxNumberForLog.Text));
        }
    }
}
