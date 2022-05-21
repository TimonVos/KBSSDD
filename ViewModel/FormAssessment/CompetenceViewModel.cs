using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Model;
using Service.Database;

namespace ViewModel.FormAssessment
{
    public class CompetenceViewModel : ViewModelBase
    {
        
        public string Title
        {
            get => CompetenceModel.CompetenceName;
        }

        public string Description
        {
            get => CompetenceModel.CompetenceDescription;
        }

        public double CompetenceGrade
        {
            get => Helper.getCompetenceGrade(Factory.AssessmentContext, new Assessment(), CompetenceModel);
        }

        public double getCompetenceGrade(AssessmentContext context, Assessment assess)
        {
            return Helper.getCompetenceGrade(context, assess, CompetenceModel);
        }

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

        public Competence CompetenceModel { get; set; }
        private IEnumerable<CriterionViewModel> _criteria;
        public IEnumerable<CriterionViewModel> Criteria 
        {
            get => _criteria;
            set
            {
                _criteria = value;
                OnPropertyChanged(nameof(Criteria));
            }
        }


        public override string ToString()
        {
            return Title;
        }
    }
}
