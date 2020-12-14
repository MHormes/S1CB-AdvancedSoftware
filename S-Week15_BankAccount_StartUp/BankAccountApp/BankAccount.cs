using System;
using System.Collections.Generic;

namespace BankAccountApp
{
    public class BankAccount
    {
        private int accountNr;
        private double balance;
        private List<double> transactions;

        public BankAccount(string clientName, int accountNr)
        {
            ClientName = clientName;
            this.accountNr = accountNr;
            this.transactions = new List<double>();
        }

        public int Accountnr
        {
            private set { }
            get { return this.accountNr; }
        }

        public string ClientName
        {
            set { }
            get { return ClientName; }
        }

        public double Balance
        {
            get { return Balance; }
            set
            {
                if(value >= 0)
                {
                    balance = value;
                }
            }
        }
        
        public string GetTransactions()
        {
            string label = this.transactions.Count + " transaction(s):" + Environment.NewLine;
            string typeOfTransaction;
            foreach (double t in this.transactions)
            {
                if (t >= 0)
                { typeOfTransaction = " deposited"; }
                else
                { typeOfTransaction = " withdrawn"; }
                label += t + typeOfTransaction + Environment.NewLine;
            }
            return label;
        }

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance = Balance + amount);
                this.transactions.Add(amount);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Withdraw(double amount)
        {
            if (Balance - amount > 0)
            {
                Balance = Balance - amount;
                this.transactions.Add(-1 * amount);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetInfo()
        {
            return String.Format("{0} (nr. {1}) - {2:0.00}", ClientName, this.accountNr, Balance);
        }
    }
}
