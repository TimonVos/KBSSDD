using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Requirements for the <see cref="Model.Indicator"/> of the <see cref="Model.Criterion"/>.
    /// </summary>
    public class Requirement
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int RequirementId { get; set; }
        /// <summary>
        /// Criterion foreign key.
        /// </summary>
        public int CriterionId { get; set; }
        /// <summary>
        /// Corresponding criterion.
        /// </summary>
        public Criterion Criterion { get; set; } = null!;
        /// <summary>
        /// Indicator foreign key.
        /// </summary>
        public int IndicatorId { get; set; }
        /// <summary>
        /// Corresponding indicator.
        /// </summary>
        public Indicator Indicator { get; set; } = null!;
        /// <summary>
        /// Consise name of the requirement.
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Description of the requirement.
        /// </summary>
        public string Description { get; set; } = null!;
/*        /// <summary>
        /// Entity set of rating this requirement has been reviewd in.
        /// </summary>
        /// <remarks>
        /// Can only be used for statistical purposes and not in practice.
        /// </remarks>
        public IEnumerable<Rating> Ratings { get; set; } = default!;*/
    }
}
