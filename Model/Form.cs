using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Reusable form for different projects.
    /// </summary>
    public class Form
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int FormId { get; set; }
        /// <summary>
        /// Descripion of the form.
        /// </summary>
        public string? Description { get; set; }
        /// <summary>
        /// Entity set of <see cref="Competence"/> this form has.
        /// </summary>
        public ICollection<Competence> Competences { get; set; } = default!;
        /// <summary>
        /// Entity set of <see cref="Project"/> this form belongs to.
        /// </summary>
        public ICollection<Project> Projects { get; set; } = default!;
    }
}
