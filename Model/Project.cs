using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    /// <summary>
    /// Project that is chosen by groups that will have a form chosen by the teacher.
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int ProjectId { get; set; }
        /// <summary>
        /// From primary key the project belongs to.
        /// </summary>
        public int FormId { get; set; }
        /// <summary>
        /// From the project belongs to.
        /// </summary>
        public Form Form { get; set; } = default!;
        /// <summary>
        /// Name of the project.
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;
        /// <summary>
        /// Descripion of the form.
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Subject code of the project.
        /// </summary>
        [Required]
        public string Code { get; set; } = null!;
        /// <summary>
        /// Descripion of the project.
        /// </summary>
        public string Description { get; set; } = null!;
        /// <summary>
        /// Entity set of assessment this project is used in.
        /// </summary>
        /// <remarks>
        /// Can only be used for statistical purposes and not in practice.
        /// </remarks>
        public ICollection<Assessment> Assessments { get; set; } = new HashSet<Assessment>();
        /// <summary>
        /// Groups that belong to this project that are assessed.
        /// </summary>
        [NotMapped]
        public ICollection<Group> Groups { get => (from a in Assessments where a.ProjectId == this.ProjectId select a.Group).ToList(); }
    }
}
