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
        public string Title
        {
            get => CriterionModel.Name;
        }

        public string Description
        {
            get => CriterionModel.Description;
        }
        public Criterion CriterionModel { get; set; }

        private IEnumerable<RequirementViewModel> _criterionAssessments;

        public IEnumerable<RequirementViewModel> CriterionAssessments
        {
            get => _criterionAssessments;

            set
            {
                _criterionAssessments = value;
                OnPropertyChanged(nameof(CriterionAssessments));
            }
        }

    }
}
