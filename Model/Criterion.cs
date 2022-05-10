using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Criterion
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Competence Competence { get; set; }

        public Criterion(string name, string description, Competence competence)
        {
            Name = name;
            Description = description;
            Competence = competence;
        }
    }
}
