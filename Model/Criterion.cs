using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Criterion to be assessed.
    /// </summary>
    public class Criterion
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int CriterionId { get; set; }
        /// <summary>
        /// Competence foreign key the criterion belongs to.
        /// </summary>
        public int CompetenceId { get; set; }
        /// <summary>
        /// Competence the criterion belongs to.
        /// </summary>
        public Competence Competence { get; set; } = null!;
        /// <summary>
        /// Consise name of the criterion.
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;
        /// <summary>
        /// Description of the criterion.
        /// </summary>
        [Required]
        public string Description { get; set; } = null!;
/*        /// <summary>
        /// Entity set of requirements this competence has.
        /// </summary>
        public ICollection<Requirement> Requirements { get; set; } = new HashSet<Requirement>();*/
/*        /// <summary>
        /// Entity set of ratings where this criterion is rated.
        /// </summary>
        /// <remarks>
        /// Can only be used for statistical purposes and not in practice.
        /// </remarks>
        public ICollection<Rating> Ratings { get; set; } = default!;*/
    }
}
