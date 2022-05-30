using System.Collections.Generic;
using Model;

namespace ViewModel.FormAssessment
{
    public class CriterionViewModel : ViewModelBase
    {
        public string Title { get => CriterionModel.Name; }
        public string Description { get => CriterionModel.Description; }
        public Criterion CriterionModel { get; set; }
        public IEnumerable<RequirementViewModel> Requirements { get; set; }

        public CriterionViewModel(Criterion crit)
        {
            CriterionModel = crit;
            Requirements = Factory.CreateRequirements(CriterionModel.Requirements);
        }
    }
}
