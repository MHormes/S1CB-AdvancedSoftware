using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExampleClassObject
{
    class Account
    {
        private string accountName;
        private int accountNmr;
        private double balance;

        public void CreateAccount(string newName, int newAccountNmr)
        {
                accountName = newName;
                accountNmr = newAccountNmr;
                balance = 0;
        }

        public Boolean Deposit(string amount)
        {
            if (!String.IsNullOrEmpty(amount))
            {
                double amountDouble = Convert.ToDouble(amount);
                if (amountDouble >= 0)
                {
                    balance += amountDouble;
                    return true;
                }
            }
            return false;
        }

        public Boolean Withdraw(string amount)
        {
            if (!String.IsNullOrEmpty(amount))
            {
                double amountDouble = Convert.ToDouble(amount);
                if (amountDouble >= 0 && balance >= amountDouble)
                {
                    balance -= amountDouble;
                    return true;
                }
            }
                return false;
            }

        public double GetBalance()
        {
            return balance;
        }

        public string GetInfo()
        {
            return $"Client: {accountName} ({accountNmr}) balance: {balance} euro(s) ";
        }
    }
}
