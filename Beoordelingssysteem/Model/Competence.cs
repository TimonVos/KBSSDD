using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Competence
    {
        #region Properties

        public string ?Name { get; set; }
        public string[] ?RatedBy { get; set; }
        public List<Criterium> ?Criteriums { get; set; }
        public string ?Notes { get; set; }
        #endregion
    }
}
