using System.Collections.Generic;
using Model;
using ViewModel.GroupAdmin;

namespace ViewModel.FormAssessment
{
    public class FormAssessmentViewModel : ViewModelBase
    {

        #region ViewModels
        private CompetenceViewModel _selectedCompetenceViewModel;
        public CompetenceViewModel SelectedCompetenceViewModel
        {
            get => _selectedCompetenceViewModel;
            set
            {
                _selectedCompetenceViewModel = value;
                OnPropertyChanged(nameof(SelectedCompetenceViewModel));
            }

        }
        public IEnumerable<CompetenceViewModel> CompetenceViewModels { get; set; }

        private IEnumerable<RatingViewModel> _ratingViewModels;
        public IEnumerable<RatingViewModel> RatingViewModels
        {
            get => _ratingViewModels;
            set
            {
                _ratingViewModels = value;
                OnPropertyChanged(nameof(RatingViewModels));
            }
        }
        public IEnumerable<IndicatorViewModel> IndicatorViewModels { get; set; }
        public IEnumerable<ProjectGroupViewModel> ProjectGroupViewModels { get; set; }

        #endregion
        public Form FormModel { get; set; }
        private AssessmentViewModel _assessmentViewModel;

        public AssessmentViewModel AssessmentViewModel
        {
            get => _assessmentViewModel;
            set
            {
                _assessmentViewModel = value;
                OnPropertyChanged(nameof(AssessmentViewModel));
            }
        }

        private List<double> _competenceGrades;
        public List<double> CompetenceGrades
        {
            get
            {
                foreach (CompetenceViewModel comp in CompetenceViewModels)
                {
                    _competenceGrades.Add(comp.getCompetenceGrade(Factory.AssessmentContext, AssessmentViewModel.AssessmentModel));
                }
                return _competenceGrades;
            }
            set
            {
                _competenceGrades = value;
                OnPropertyChanged(nameof(CompetenceGrades));
            }
        }

        public FormAssessmentViewModel()
        {
            ProjectGroupViewModels = Factory.CreateGroups(Factory.AssessmentContext.Groups);
            CompetenceViewModels = Factory.CreateCompetences(Factory.AssessmentContext.Competences);
            IndicatorViewModels = Factory.CreateIndicators(Factory.AssessmentContext.Indicators);
            foreach(CompetenceViewModel compvm in CompetenceViewModels)
            {
                compvm.Criteria = Factory.CreateCriteria(compvm.CompetenceModel.Criteria);
            }
            foreach (CompetenceViewModel compvm in CompetenceViewModels)
            {
                foreach (CriterionViewModel critvm in compvm.Criteria)
                {
                    critvm.CriterionAssessments =
                        Factory.CreateCriterionAssessments(critvm.CriterionModel.CriterionAssessments);
                }
            }

            RatingViewModels =
                Factory.CreateSelectedAssessments(Factory.AssessmentContext.Ratings);

        }
    }
}
