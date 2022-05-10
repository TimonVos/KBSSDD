using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Group : ISubject
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public List<Student> Students { get; set; }

        public Group(string name, int number, List<Student> students)
        {
            Name = name;
            Number = number;
            Students = students;
        }

        public override string ToString()
        {
            return $"{Name} (Groep {Number})";
        }
    }
}
