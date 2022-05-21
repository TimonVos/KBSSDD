using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Name { get; set; } = null!;
        /// <summary>
        /// Subject code of the project.
        /// </summary>
        public string Code { get; set; } = null!;
        /// <summary>
        /// Entity set of assessment this project is used in.
        /// </summary>
        /// <remarks>
        /// Can only be used for statistical purposes and not in practice.
        /// </remarks>
        public IEnumerable<Assessment> Assessments { get; set; } = new HashSet<Assessment>();
    }
}
