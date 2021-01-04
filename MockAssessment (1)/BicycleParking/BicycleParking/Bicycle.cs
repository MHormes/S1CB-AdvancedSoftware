using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BicycleParking
{
    public class Bicycle
    {
        public static int ticketSeeder = 10000;

        private string ticketNumber;
        private int hoursInParking;
        private string ownerZipcode;

        public BicycleType Type
        {
            private set;
            get;
        }

        public bool IsInParking
        {
            set;
            get;
        }

        public string TicketNumber
        {
            get { return this.ticketNumber; }
            set { this.ticketNumber = value; }
        }

        public int HoursInParking
        {
            set
            {
                if (value < 1)
                {
                    this.hoursInParking = 1;
                }
                else
                {
                    this.hoursInParking = value;
                }
            }
            get { return this.hoursInParking; }
        }

        public string OwnerZipcode
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    this.ownerZipcode = "Unknown";
                }
                else
                {
                    this.ownerZipcode = value;
                }
            }
            get { return this.ownerZipcode; }
        }

        public Bicycle(BicycleType type)
        {
            this.Type = type;
            IsInParking = true;
            string s = Convert.ToString(type);
            TicketNumber = s.Substring(0, 3) + ticketSeeder.ToString();
            ticketSeeder++;
        }

        public string GetInfo()
        {
            string s = this.ticketNumber + ": " + this.Type.ToString() + " bicycle";
            if (!this.IsInParking)
            {
                s += " - hours parked " + this.hoursInParking;
                s += " & owner zipcode " + this.ownerZipcode;
            }
            return s;
        }
    }
}
