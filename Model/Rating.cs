using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Rating for the <see cref="Model.Criterion"/> of the <see cref="Group"/>.
    /// </summary>
    public class Rating
    {
        /// <summary>
        /// Primary and foreign key of assessment.
        /// </summary>
        public int AssessmentId { get; set; }
        /// <summary>
        /// Corresponding <see cref="Model.Assessment"/>.
        /// </summary>
        public Assessment Assessment { get; set; } = null!;
        /// <summary>
        /// Primary and foreign key of criterion.
        /// </summary>
        public int CriterionId { get; set; }
        /// <summary>
        /// Corresponding criterion.
        /// </summary>
        public Criterion Criterion { get; set; } = null!;
        /// <summary>
        /// Selected requirement.
        /// </summary>
        public Requirement Requirement { get; set; } = null!;
    }
}
