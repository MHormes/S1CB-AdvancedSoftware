using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    public class Grade
    {
        private string stName;
        private string grade;

        public void SetGrade(string name, string grade)
        {
            stName = name;
            this.grade = grade;
        }

        public string GetInfo()
        {
            return $"{stName} - {grade}";
        }
        public string GetGrade()
        {
            return grade;
        }
    }
}
