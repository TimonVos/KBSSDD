using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Model for the list of files that indicate the assessment choice
    /// </summary>
    public class AppearsFrom
    {
        public AppearsFrom(int appearsFromId, string appearsFromDescription)
        {
            AppearsFromId = appearsFromId;
            AppearsFromDescription = appearsFromDescription;
            this.Competences = new HashSet<Competence>();
        }

        public int AppearsFromId { get; set; }
        public string AppearsFromDescription { get; set; }
        public virtual ICollection<Competence> Competences { get; set; }
    }
}
