using System;
using System.Collections.Generic;
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
        /// Corresponding <see cref="Model.Assessment"/>.
        /// </summary>
        public Assessment Assessment { get; set; } = null!;
        /// <summary>
        /// Corresponding <see cref="Model.Criterion"/>.
        /// </summary>
        public Criterion Criterion { get; set; } = null!;
        /// <summary>
        /// Selected <see cref="Model.Requirement"/>.
        /// </summary>
        public Requirement Requirement { get; set; } = null!;
    }
}
