using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Join table of <see cref="Model.Group"/> and <see cref="Model.Student"/>.
    /// </summary>
    public class GroupStudent
    {
        /// <summary>
        /// Primary and foreign key of <see cref="Model.Group"/>
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// Corresponding <see cref="Model.Group"/> entity.
        /// </summary>
        public Group Group { get; set; } = null!;
        /// <summary>
        /// Primary and foreign key of <see cref="Model.Group"/>
        /// </summary>
        public int StudentNumber { get; set; }
        /// <summary>
        /// Corresponding <see cref="Model.Student"/> entity.
        /// </summary>
        public Student Student { get; set; } = null!;
    }
}
