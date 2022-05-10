using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Competence
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        public Competence(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public Competence() : this("", 0)
        {

        }

        public override string ToString()
        {
            return $"{Name} ({Weight:n2}%)";
        }
    }
}
