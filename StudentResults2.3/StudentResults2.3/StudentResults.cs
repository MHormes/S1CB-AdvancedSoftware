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
                if (cor.GetInfo() == $"{code}-{grade}")
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
            
        }
        public Course GetAllResults()
        {
            
        }
        public void UpdateResult(string code, string remark)
        {

        }
        public void RemoveResult(string code)
        {

        }
        public string GetInfo()
        {

        }
    }
}
