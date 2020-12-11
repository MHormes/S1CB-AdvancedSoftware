using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResults2._3
{
    public class Course
    {
        private string code;
        private Grade grade;
        private string remark;

        public Course(string code, Grade grade)
        {
            this.code = code;
            this.grade = grade;
        }
        public Course(string code, Grade grade, string remark)
        {
            this.code = code;
            this.grade = grade;
            this.remark = remark;
        }
        public bool HasPassed()
        {

        }
        public string GetRemark()
        {
            return remark;
        }
        public void SetRemark(string remark)
        {

        }
        public string GetInfo()
        {
            return $"{code}-{grade}";
        }
    }
}
