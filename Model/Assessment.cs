using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Assessment of the group and their selected project.
    /// </summary>
    public class Assessment
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int AssessmentId { get; set; }
        /// <summary>
        /// The assessed group.
        /// </summary>
        public Group Group { get; set; } = null!;
        /// <summary>
        /// Project that the group has selected.
        /// </summary>
        public Project Project { get; set; } = null!;
/*        /// <summary>
        /// Entity set of ratings the assessment has reviewed.
        /// </summary>
        public IEnumerable<Rating> Ratings { get; set; } = default!;*/
    }
}
