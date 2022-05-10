using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rating
    {
        public ISubject Subject { get; set; }
        public Criterion Criterion { get; set; }
        public Indicator Indicator { get; set; }
        public Rating(ISubject subject, Criterion criterion, Indicator indicator)
        {
            Subject = subject;
            Criterion = criterion;
            Indicator = indicator;
        }
    }
}
