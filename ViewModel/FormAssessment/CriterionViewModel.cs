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
            get => CriterionModel.CriterionName;
        }

        public string Description
        {
            get => CriterionModel.CriterionDescription;
        }
        public Criterion CriterionModel { get; set; }

        private IEnumerable<CriterionAssessmentViewModel> _criterionAssessments;

        public IEnumerable<CriterionAssessmentViewModel> CriterionAssessments
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
