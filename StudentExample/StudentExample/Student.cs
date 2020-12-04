using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExample
{
    class Student
    {
        private string stName;
        private int stPcn;

        public void SetName(string name)
        {
            stName = name;
        }

        public void SetPcn(int Pcn)
        {
            stPcn = Pcn;
        }

        public int GetPcn()
        {
            return stPcn;
        }

        public string GetInfo()
        {
            return $"student name: {stName} with pcn: {stPcn}";
        }
    }
}
