using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class GroupStudent
    {
        public int GroupId { get; set; }
        public Group Group { get; set; }
        public int StudentNumber { get; set; }
        public Student Student { get; set; }
    }
}
