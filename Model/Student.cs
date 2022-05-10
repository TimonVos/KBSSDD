using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student : ISubject
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public Student(int number, string name)
        {
            Number = number;
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} (S{Number})";
        }
    }
}
