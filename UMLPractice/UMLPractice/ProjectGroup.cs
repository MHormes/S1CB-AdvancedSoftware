using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMLPractice
{
    public class ProjectGroup
    {
        private string name;
        private List<Member> members = new List<Member>();

        public ProjectGroup(string name)
        {
            this.name = name;
        }

        public void AddMember(string name)
        {
            Member memb = new Member(name);
            this.members.Add(memb);
        }

        public string GetInfo()
        {
            string info = "";
            foreach (Member mem in members)
            {
                info += mem.GetInfo() + " ";
            }
            return $"{name} - {info}";
        }
    }
}
