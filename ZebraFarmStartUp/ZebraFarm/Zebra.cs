using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZebraFarm
{
    public class Zebra
    {
        public static int idSeeder;

        private int id;
        private string name;
        private int motherId;
        private int fatherId;

        public Gender Gender
        {
            get;
            set;
        }

        public int Id
        {
            private set { this.id = value; }
            get { return this.id; }
        }

        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }

        public Zebra(string name, Gender gender)
        {
            this.Name = name;
            this.Gender = gender;
            this.motherId = -1;
            this.fatherId = -1;
            this.id = idSeeder;
            idSeeder++;
        }

        public Zebra(string name, Gender gender, int motherId, int fatherId)
        {
            this.Name = name;
            this.Gender = gender;
            this.motherId = motherId;
            this.fatherId = fatherId;
            this.Id = idSeeder;
            idSeeder++;
        }
        
        public Zebra AttemptToProduceOffspring(Zebra mate)
        {
            if(Gender == Gender.MARE && mate.Gender == Gender.STALLION)
            {
                Random rnd = new Random();
                int decider = rnd.Next(101);

                if(decider < 45)
                {
                    string name = $"{this.Name}-with-{mate.Name}";
                    Zebra newBorn = new Zebra(name, Gender.STALLION, this.id, mate.id);
                    return newBorn;
                }
                else if(decider >= 45 && decider < 90)
                {
                    string name = $"{this.Name}-with-{mate.Name}";
                    Zebra newBorn = new Zebra(name, Gender.MARE, this.id, mate.id);
                    return newBorn;
                }
                return null;
            }
            return null;
        }

        public string GetInfo()
        {
            string s = this.Name + "(id " + this.id.ToString() + ") is a " + this.Gender.ToString();
            if (this.motherId > -1)
            { s += "; motherId " + this.motherId; }
            if (this.fatherId > -1)
            { s += "; fatherId " + this.fatherId; }
            return s;
        }

    }
}
