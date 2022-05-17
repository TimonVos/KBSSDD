using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;
using Model;
using Service.Database;
using ViewModel.GroupAdmin;

namespace ViewModel.FormAssessment
{
    public class FormAssessmentViewModel : ViewModelBase
    {
 
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

        public IEnumerable<IndicatorViewModel> IndicatorViewModels { get; set; }
        public IEnumerable<ProjectGroupViewModel> ProjectGroupViewModels { get; set; }

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
        }
    }
}
