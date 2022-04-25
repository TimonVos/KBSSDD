using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Criterium
    {
        #region Properties

        public string Description { get; set; }
        public Dictionary<Rating, string> RatingsDictionary { get; set; }
        #endregion
    }
}
