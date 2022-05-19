using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Join table of <see cref="Group"/> and <see cref="Student"/>.
    /// </summary>
    public class GroupStudent
    {
        /// <summary>
        /// Primary and foreign key of <see cref="Group"/>
        /// </summary>
        public int GroupId { get; set; }
        /// <summary>
        /// Corresponding <see cref="Group"/> entity.
        /// </summary>
        public Group Group { get; set; }
        /// <summary>
        /// Primary and foreign key of <see cref="Group"/>
        /// </summary>
        public int StudentNumber { get; set; }
        /// <summary>
        /// Corresponding <see cref="Student"/> entity.
        /// </summary>
        public Student Student { get; set; }
    }
}
