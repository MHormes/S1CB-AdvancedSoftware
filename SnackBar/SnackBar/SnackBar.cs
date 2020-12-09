using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnackBar
{
    public class SnackBar
    {
        public static double price = 0;
        private double revenue;

        Snack frikandel = new Snack("Frikandel", 1.20, 10);
        Snack kroket = new Snack("Kroket", 1.40, 10);
        Snack mexicano = new Snack("Mexicano", 2.00, 10);

        public SnackBar()
        {
        }

        public string ProcessOrder(int snack1, int snack2, int snack3)
        {
            if (!frikandel.DecreaseStock(snack1))
            {
                return frikandel.GetName();
            }
            if (!kroket.DecreaseStock(snack2))
            {
                return kroket.GetName();
            }
            if (!mexicano.DecreaseStock(snack3))
            {
                return mexicano.GetName();
            }
            price = (frikandel.GetPrice() * snack1) + (kroket.GetPrice() * snack2) + (mexicano.GetPrice() * snack3);
            revenue += price;
            return "";
        }

        public double GetRevenue()
        {
            return revenue;
        }

        public string GetAllInfo()
        {
            return $"{frikandel.GetName()}:{frikandel.GetAmountInStock()} - {frikandel.GetPrice()} \n{kroket.GetName()}:{kroket.GetAmountInStock()} - {kroket.GetPrice()} \n{mexicano.GetName()}:{mexicano.GetAmountInStock()} - {mexicano.GetPrice()}";
        }

        public void SetNewStockOrPrice(string name, int amount, double price)
        {
            switch (name)
            {
                case "frikandel":
                    if(amount != 0)
                    {
                        frikandel.SetAmountInStock(amount);
                    }
                    if(price != 0)
                    {
                        frikandel.SetPrice(price);
                    }
                    break;

                case "kroket":
                    if (amount != 0)
                    {
                        kroket.SetAmountInStock(amount);
                    }
                    if (price != 0)
                    {
                        kroket.SetPrice(price);
                    }
                    break;

                case "mexicano":
                    if (amount != 0)
                    {
                        mexicano.SetAmountInStock(amount);
                    }
                    if (price != 0)
                    {
                        mexicano.SetPrice(price);
                    }
                    break;
            }
        }
    }
}
