using System.ComponentModel.DataAnnotations;

namespace Model
{
    /// <summary>
    /// Collection of criteria to be assessed for a competence.
    /// </summary>
    public class Competence
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int CompetenceId { get; set; }
        /// <summary>
        /// Form foreign key the competence belongs to.
        /// </summary>
        public int FormId { get; set; }
        /// <summary>
        /// Form the competence belongs to.
        /// </summary>
        public Form Form { get; set; } = null!;
        /// <summary>
        /// Consise name of the competence.
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;
        /// <summary>
        /// Description of the competence.
        /// </summary>
        [Required]
        public string Description { get; set; } = null!;
        /// <summary>
        /// Weight of the competence. Total weight of the form must be 1.0d;
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// A description of valid evidences for the competence.
        /// </summary>
        [Required]
        public string Evidence { get; set; } = null!;
        /// <summary>
        /// Entity set of criteria this competence has.
        /// </summary>
        public ICollection<Criterion> Criteria { get; set; } = new HashSet<Criterion>();
    }
}
