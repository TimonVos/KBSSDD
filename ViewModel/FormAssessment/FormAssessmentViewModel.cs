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
        public GroupViewModel ProjectGroupViewModel { get; set; }
        public AssessmentContext AssessmentContext { get; set; }


        private CriterionViewModel _selectedCriterionViewModel;
        public CriterionViewModel SelectedCriterionViewModel
        {
            get => _selectedCriterionViewModel;
            set
            {
                _selectedCriterionViewModel = value;
                OnPropertyChanged(nameof(SelectedCriterionViewModel));
            }
        }

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
        public IEnumerable<CriterionViewModel> CriterionViewModels { get; set; }

        public FormAssessmentViewModel()
        {
            ProjectGroupViewModel = Factory.CreateGroup();
            CompetenceViewModels = Factory.CreateCompetences(Factory.AssessmentContext.Competences);
            IndicatorViewModels = Factory.CreateIndicators(Factory.AssessmentContext.Indicators);
            CriterionViewModels = Factory.CreateCriteria(Factory.AssessmentContext.Criteria);
        }
    }
}
