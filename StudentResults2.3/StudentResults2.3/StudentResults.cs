using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResults2._3
{
    public class StudentResults
    {
        List<Course> courseList = new List<Course>();
        Course newCourse;
        private int studentNumber;
        private string name;

        public StudentResults(int studentNumber, string name)
        {
            this.studentNumber = studentNumber;
            this.name = name;
        }

        public bool AddResult(string code, Grade grade)
        {
            foreach(Course cor in courseList)
            {
                if (cor.GetCode() == code)
                {
                    return false;
                }
            }
            newCourse = new Course(code, grade);
            this.courseList.Add(newCourse);
            return true;
        }
        public Course GetResult(string code)
        {
            foreach(Course cor in courseList)
            {
                if (cor.GetCode() == code)
                {
                    return cor;
                }
            }
            return null;
        }

        public Course[] GetAllResults()
        {
            return this.courseList.ToArray();
        }

        public void UpdateResult(string code, string remark)
        {
            foreach (Course cor in courseList)
            {
                if (cor.GetCode() == code)
                {
                    cor.SetRemark(remark);
                }
            }

        }

        public void RemoveResult(string code)
        {
            foreach(Course cor in courseList)
            {
                if(cor.GetCode() == code)
                {
                    courseList.Remove(cor);
                    return;
                }
            }
        }

        public string GetInfo()
        {
            List<Course> failedList = new List<Course>();
            string failedInfo = "You have failed:";
            foreach(Course cor in courseList)
            {
                if (!cor.HasPassed())
                {
                    failedList.Add(cor);
                }
            }
            if(failedList.Count == 0)
            {
                return "You have passed al courses";
            }
            
            foreach(Course cor in failedList)
            {
                failedInfo += $" {cor.GetInfo()}";
            }
            return failedInfo;
        }
    }
}
