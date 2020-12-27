using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    public class Bank
    {
        private string name;
        List<BankAccount> accountList = new List<BankAccount>();

        public Bank(string name)
        {
            this.name = name;
        } 
            
        public int CreateAccount(string name)
        {
            BankAccount newAcc = new BankAccount(name);
            accountList.Add(newAcc);
            return newAcc.Accountnr;
        }

        public int[] GetAllAccounts()
        {
            List<int> accountNmr = new List<int>();
            foreach (BankAccount acc in accountList)
            {
                accountNmr.Add(acc.Accountnr);
            }

            return accountNmr.ToArray();
        }

        public int[] GetAllAccountsWithName(string name)
        {
            List<int> accountNmr = new List<int>();
            foreach(BankAccount acc in accountList)
            {
                if(acc.ClientName == name)
                {
                    accountNmr.Add(acc.Accountnr);
                }
            }
            return accountNmr.ToArray();
        }

        public string GetAccountInfo(int number)
        {
            foreach(BankAccount acc in accountList)
            {
                if(acc.Accountnr == number)
                {
                    return acc.GetInfo();
                }
            }
            return "There is no account with this number";
        }

        public string GetTransactionsWithNmr(int number)
        {
            foreach(BankAccount acc in accountList)
            {
                if(acc.Accountnr == number)
                {
                    return acc.GetTransactions();
                }
            }
            return "There is no account with this number";
        }

        public bool DepositToAccount(int number, double amount)
        {
            foreach(BankAccount acc in accountList)
            {
                if(acc.Accountnr == number)
                {
                    if (acc.Deposit(amount))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool WithdrawFrom(int number, double amount)
        {
            foreach (BankAccount acc in accountList)
            {
                if (acc.Accountnr == number)
                {
                    if (acc.Withdraw(amount))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public double[] GetAllBalances()
        {
            List<double> allBalances = new List<double>();
            foreach(BankAccount acc in accountList)
            {
                allBalances.Add(acc.Balance);
            }
            return allBalances.ToArray();
        }
    }
}
