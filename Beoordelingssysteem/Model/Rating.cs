using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rating
    {
        #region Properties

        public string ?Description { get; set; }

        #endregion

        public override string ToString()
        {
            return Description;
        }
    }
}
