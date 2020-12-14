using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyRounding
{
    class CrazyMath
    {
        public double RoundWholes(double value)
        {
            Random rnd = new Random();
            int decision = rnd.Next(2);
            if(decision == 0)
            {
                return Math.Ceiling(value);
            }
            return Math.Floor(value);
            
        }

        public double RoundTenths(double value)
        {
            Random rnd = new Random();
            int decision = rnd.Next(2);
            if (decision == 0)
            {
                return Math.Ceiling(value*10) / 10;
            }
            return Math.Floor(value*10) / 10;
        }

        public double RoundHundreths(double value)
        {
            Random rnd = new Random();
            int decision = rnd.Next(2);
            if (decision == 0)
            {
                return Math.Ceiling(value*100) / 100;
            }
            return Math.Floor(value*100) / 100;
        }
    }
}
