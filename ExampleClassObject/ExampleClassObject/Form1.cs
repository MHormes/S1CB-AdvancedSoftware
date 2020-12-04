using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleClassObject
{

    public partial class Form1 : Form
    {
        Account checkingAccount = new Account();
        Account savingAccount = new Account();

        public Form1()
        {
            InitializeComponent();
            
            checkingAccount.CreateAccount("Checking", 1234);
            savingAccount.CreateAccount("Saving", 6789);
            UpdateBalance();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (rdbChecking.Checked)
            {
                bool x = checkingAccount.Deposit(tbxAmount.Text);
                if (!x)
                {
                    MessageBox.Show("Amount cannot be below 0");
                }
            }
            if (rdbSaving.Checked)
            {
                bool x = savingAccount.Deposit(tbxAmount.Text);
                if (!x)
                {
                    MessageBox.Show("Amount cannot be below 0");
                }
            }
            UpdateBalance();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (rdbChecking.Checked)
            {
                bool x = checkingAccount.Withdraw(tbxAmount.Text);
                if (!x)
                {
                    MessageBox.Show("Amount/Balance cannot be below 0");
                }
            }
            if (rdbSaving.Checked)
            {
                bool x = savingAccount.Withdraw(tbxAmount.Text);
                if (!x)
                {
                    MessageBox.Show("Amount/Balance cannot be below 0");
                }
            }
            UpdateBalance();
        }

        private void UpdateBalance()
        {
            lblBalanceCheck.Text = Convert.ToString(checkingAccount.GetBalance());
            lblBalanceSave.Text = Convert.ToString(savingAccount.GetBalance());
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (rdbChecking.Checked)
            {
                MessageBox.Show(checkingAccount.GetInfo());
            }
            if (rdbSaving.Checked)
            {
                MessageBox.Show(savingAccount.GetInfo());
            }
        }
    }
}

