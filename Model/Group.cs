﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Group
    {
        public int GroupId { get; set; }
        public int Number { get; set; }
        public string? Name { get; set; }
        public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
        public List<GroupStudent> GroupStudents { get; set; }
    }
}
