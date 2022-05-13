using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Assessment
    {
        public Form AssessedForm { get; set; }
        public int Grade { get; set; }
        public List<Rating> Ratings { get; set; }
    }
}
