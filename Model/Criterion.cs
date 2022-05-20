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
        /// <see cref="Model.Competence"/> the criterion belongs to.
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
        /// <summary>
        /// Entity set of <see cref="Crtierion"/> this competence has.
        /// </summary>
        public ICollection<Criterion> Requirements { get; set; } = default!;
    }
}
