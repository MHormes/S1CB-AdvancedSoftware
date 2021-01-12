using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BicycleParking
{
    public class BicycleParking
    {
        private double pricePerHour;
        private double surchargeElectricPerHour;
        List<Bicycle> bicList;

        public BicycleParking(double pricePerHour, double surchargeElectricPerHour)
        {
            this.pricePerHour = pricePerHour;
            this.surchargeElectricPerHour = surchargeElectricPerHour;
            bicList = new List<Bicycle>();
        }

        private Bicycle GetBicycle(string ticketNumber)
        {
            foreach (Bicycle bic in bicList)
            {
                if (bic.TicketNumber == ticketNumber)
                {
                    return bic;
                }
            }
            return null;
        }

        public string ParkBicycle(BicycleType type)
        {
            Bicycle newBic = new Bicycle(type);
            bicList.Add(newBic);
            return newBic.TicketNumber;
        }

        public double RetrieveBicycle(string ticketNumber, int hoursInParking, string zipcode)
        {
            double priceToPay = 0;

            foreach (Bicycle bic in bicList)
            {
                if (bic.TicketNumber == ticketNumber && bic.IsInParking == true)
                {
                    bic.HoursInParking = hoursInParking;
                    bic.OwnerZipcode = zipcode;
                    bic.IsInParking = false;
                    BicycleType type = bic.Type;

                    switch (type)
                    {
                        case BicycleType.NORMAL:
                            {
                                priceToPay = hoursInParking * pricePerHour;
                                return priceToPay;
                            }
                        case BicycleType.ELECTRIC:
                            {
                                priceToPay = hoursInParking * pricePerHour + hoursInParking * surchargeElectricPerHour;
                                return priceToPay;
                            }
                        case BicycleType.FOLDING:
                            {
                                priceToPay = (hoursInParking * pricePerHour)/2;
                                return priceToPay;
                            }
                        case BicycleType.TANDEM:
                            {
                                priceToPay = (hoursInParking * pricePerHour) * 2;
                                return priceToPay;
                            }
                    }
                }
            }
            return -1;
        }

        public Bicycle[] GetAllRetrievedBicyclesByZipcode(string partialZipcode)
        {
            List<Bicycle> foundBic = new List<Bicycle>();
            foreach(Bicycle bic in bicList)
            {
                if (bic.OwnerZipcode != null)
                {
                    //partial should work aswell
                    if (bic.OwnerZipcode.Contains(partialZipcode))
                    {
                        foundBic.Add(bic);
                    }
                }
            }
            return foundBic.ToArray();
        }
    }
}
