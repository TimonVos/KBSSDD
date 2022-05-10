using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class IndicatorViewModel
    {
        public Indicator? Model { get; set; }
        public CriterionViewModel? Criterion { get; set; }

        public IndicatorViewModel()
        {

        }
    }
}
