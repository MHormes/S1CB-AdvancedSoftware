using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZebraFarm
{
    public class ZebraFarm
    {
        List<Zebra> zebraList;

        private string name;

        public string Name
        {
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    this.name = "Unknown";
                    return;
                }
                this.name = value;
            }
            get { return this.name; }
        }

        public ZebraFarm(string name)
        {
            this.Name = name;
            zebraList = new List<Zebra>();
            Zebra berta = new Zebra("Berta1", Gender.MARE);
            Zebra henk = new Zebra("Henk1", Gender.STALLION);
            zebraList.Add(berta);
            zebraList.Add(henk);
        }

        public Zebra GetZebra(int id)
        {
            foreach(Zebra z in zebraList)
            {
                if(z.Id == id)
                {
                    return z;
                }
            }
            return null;
        }

        public Zebra[] GetZebras()
        {
            return zebraList.ToArray();
        }

        public Zebra[] GetZebras(Gender g)
        {
            List<Zebra> rightGender = new List<Zebra>();
            foreach(Zebra z in zebraList)
            {
                if(z.Gender == g)
                {
                    rightGender.Add(z);
                }
            }
            return rightGender.ToArray();
        }

        public bool AttemptToBread(int motherId, int fatherId)
        {
            Zebra possibleNewBorn = GetZebra(motherId).AttemptToProduceOffspring(GetZebra(fatherId));
            if (possibleNewBorn == null)
            {
                return false;
            }
            zebraList.Add(possibleNewBorn);
            return true;
        }
    }
}
