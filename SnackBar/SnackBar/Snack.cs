using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackBar
{
    public class Snack
    {
        private string name;
        private double price;
        private int amountInStock;

        public Snack(string name, double price, int amountInStock)
        {
            this.name = name;
            this.price = price;
            this.amountInStock = amountInStock;
        }

        public bool DecreaseStock(int amount)
        {
            if(amount > amountInStock)
            {
                return false;
            }
            else
            {
                amountInStock -= amount;
                return true;
            }            
        }

        public string GetName()
        {
            return this.name;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public int GetAmountInStock()
        {
            return this.amountInStock;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public void SetAmountInStock(int amountInStock)
        {
            this.amountInStock += amountInStock;
        }
    }
}
