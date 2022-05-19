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

        private IEnumerable<SelectedCriterionAssessmentViewModel> _selectedCriterionAssessmentViewModels;
        public IEnumerable<SelectedCriterionAssessmentViewModel> SelectedCriterionAssessmentViewModels
        {
            get => _selectedCriterionAssessmentViewModels;
            set
            {
                _selectedCriterionAssessmentViewModels = value;
                OnPropertyChanged(nameof(_selectedCriterionAssessmentViewModels));
            }
        }
        public IEnumerable<IndicatorViewModel> IndicatorViewModels { get; set; }
        public IEnumerable<ProjectGroupViewModel> ProjectGroupViewModels { get; set; }

        #endregion
        public Form FormModel { get; set; }
        
        

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

            SelectedCriterionAssessmentViewModels =
                Factory.CreateSelectedAssessments(Factory.AssessmentContext.SelectedAssessments);
        }
    }
}
