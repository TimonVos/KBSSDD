using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Student : Subject
    {
        public int? Grade { get; set; }
        public string? Name { get; set; }
        public string? StudentNumber { get; set; }

    }
}
