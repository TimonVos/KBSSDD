using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Indicator
    {
        public string Name { get; set; }
        public double Rating { get; set; }
        public Indicator(string name, double rating)
        {
            Name = name;
            Rating = rating;
        }

        public override string ToString()
        {
            return $"{Name} ({Rating})";
        }
    }
}
