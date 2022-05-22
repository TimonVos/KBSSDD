using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel.FormAssessment
{
    public class CriterionViewModel : ViewModelBase
    {
        public string Title { get => CriterionModel.Name; }
        public string Description { get => CriterionModel.Description; }
        public Criterion CriterionModel { get; set; }
        public IEnumerable<RequirementViewModel> Requirements { get; set; }

        public CriterionViewModel()
        {
            Requirements = Factory.CreateRequirements(CriterionModel.Requirements);
        }
    }
}
