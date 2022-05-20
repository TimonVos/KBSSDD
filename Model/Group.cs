using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// A group of students.
    /// </summary>
    public class Group
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// Number representing the group number in the class.
        /// </summary>
        public int Number { get; set; }
        /// <summary>
        /// Optional name made up by a group.
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// Entity set of <see cref="Student"/> this group has.
        /// </summary>
        public ICollection<Student> Students { get; set; } = default!;
        /// <summary>
        /// Join table of <see cref="Group"/> and <see cref="Student"/>.
        /// </summary>
        public ICollection<GroupStudent> GroupStudents { get; set; } = default!;
        /// <summary>
        /// Entity set of <see cref="Assessment"/> this group has.
        /// </summary>
        public ICollection<Assessment> Assessments { get; set; } = default!;
    }
}
