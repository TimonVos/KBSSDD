using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Model
{
    /// <summary>
    /// Students that are assigned to groups.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Primary key. Represent the real registration number of a student.
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentNumber { get; set; }
        /// <summary>
        /// Full name of a student.
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;
        /// <summary>
        /// Entity set of <see cref="Group"/> this student belongs to.
        /// </summary>
        public ICollection<Group> Groups { get; set; } = new HashSet<Group>();
        /// <summary>
        /// <inheritdoc cref="Group.GroupStudents"/>
        /// </summary>
        public ICollection<GroupStudent> GroupStudents { get; set; } = new HashSet<GroupStudent>();
    }
}
