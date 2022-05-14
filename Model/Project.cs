using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Project
    {
        public String ProjectCode { get; set; }
        public String ProjectName { get; set; }
        public List<Group> Groups { get; set; }
    }
}
