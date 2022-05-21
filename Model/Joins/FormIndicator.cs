using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Join table of form and indicator.
    /// </summary>
    public class FormIndicator
    {
        /// <summary>
        /// Primary and foreign key of form.
        /// </summary>
        public int FormId { get; set; }
        /// <summary>
        /// Corresponding form entity.
        /// </summary>
        public Form Form { get; set; } = null!;
        /// <summary>
        /// Primary and foreign key of indicator.
        /// </summary>
        public int IndicatorId { get; set; }
        /// <summary>
        /// Corresponding indicator entity.
        /// </summary>
        public Indicator Indicator { get; set; } = null!;
    }
}
