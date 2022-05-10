using System.Collections.Generic;
using System.Windows;
using Model;

namespace ViewModel
{
    public class CompetenceViewModel : DependencyObject
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
