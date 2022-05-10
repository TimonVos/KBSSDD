using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    public class CompetenceViewModel
    {
        public Competence? Model { get; set; }
        public IEnumerable<CriterionViewModel>? Criteria { get; set; }

        public CompetenceViewModel()
        {

        }

        public override string ToString()
        {
            return Model?.ToString() ?? "-";
        }
    }
}
