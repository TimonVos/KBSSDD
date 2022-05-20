using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Join table of <see cref="Model.Form"/> and <see cref="Model.Indicator"/>.
    /// </summary>
    public class FormIndicator
    {
        /// <summary>
        /// Primary and foreign key of <see cref="Model.Form"/>
        /// </summary>
        public int FormId { get; set; }
        /// <summary>
        /// Corresponding <see cref="Model.Form"/> entity.
        /// </summary>
        public Form Form { get; set; } = null!;
        /// <summary>
        /// Primary and foreign key of <see cref="Model.Indicator"/>
        /// </summary>
        public int IndicatorId { get; set; }
        /// <summary>
        /// Corresponding <see cref="Model.Indicator"/> entity.
        /// </summary>
        public Indicator Indicator { get; set; } = null!;
    }
}
