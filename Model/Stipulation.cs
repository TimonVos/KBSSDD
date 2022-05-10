using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Stipulation
    {
        public Criterion Criterion { get; set; }
        public Indicator Indicator { get; set; }
        public string Content { get; set; }

        public Stipulation(Criterion criterion, Indicator indicator, string content)
        {
            Criterion = criterion;
            Indicator = indicator;
            Content = content;
        }

        public override string ToString()
        {
            return $"{Content}";
        }
    }
}
