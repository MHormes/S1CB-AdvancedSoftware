using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetInformation
{
    public class Pet
    {
        private string petName;
        private int birthYear;
        private string petType;

        public bool SetPet(string newName, string year, string newType)
        {
            if (!String.IsNullOrWhiteSpace(newName) && !String.IsNullOrWhiteSpace(year) && !String.IsNullOrWhiteSpace(newType))
            {
                petName = newName;
                birthYear = Convert.ToInt32(year);
                petType = newType;
                return true;
            }
            return false;
        }

        public int GetAge()
        {
            return birthYear;
        }
    }
}
