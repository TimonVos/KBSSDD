using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Rating a criterion can have with its corresponding value,
    /// e.g.: "Failed", "Adequate", "Excellent".
    /// </summary>
    public class Indicator
    {
        /// <summary>
        /// Primary key.
        /// </summary>
        public int IndicatorId { get; set; }
        /// <summary>
        /// Name of the indicator.
        /// </summary>
        [Required]
        public string Name { get; set; } = null!;
        /// <summary>
        /// Value of the indicator. Between 1 and 10 for example.
        /// </summary>
        public double Value { get; set; }
        /// <summary>
        /// Entity set of <see cref="Form"/> this group has.
        /// </summary>
        public ICollection<Form> Forms { get; set; } = default!;
        /// <summary>
        /// Join table of <see cref="Form"/> and <see cref="Indicator"/>.
        /// </summary>
        public ICollection<FormIndicator> FromIndicators { get; set; } = default!;
    }
}
