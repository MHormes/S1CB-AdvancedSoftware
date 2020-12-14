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
            switch (this.grade)
            {
                case Grade.Poor:
                    return false;
                    break;
                case Grade.Unsatisfactory:
                    return false;
                    break;
                case Grade.Satisfactory:
                    return true;
                    break;
                case Grade.Good:
                    return true;
                    break;
                case Grade.Outstanding:
                    return true;
                    break;
            }
            return true;
        }
        public string GetRemark()
        {
            return remark;
        }

        public string GetCode()
        {
            return code;
        }
        public void SetRemark(string remark)
        {
            this.remark = remark;
        }
        public string GetInfo()
        {
            if (string.IsNullOrWhiteSpace(remark))
            {
                return $"{code} - {grade}";
            }
            return $"{code} - {grade} - ({remark})";
        }
    }
}
