using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Model
{
    public class Student
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentNumber { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public ICollection<Group> Groups { get; set; } = new HashSet<Group>();
        public List<GroupStudent> GroupStudents { get; set; }
    }
}
