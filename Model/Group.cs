using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Group : Subject
    {
        public int? Grade { get; set; }
        public string? Name { get; set; }
        public List<Student>? Students { get; set; }
    }
}
