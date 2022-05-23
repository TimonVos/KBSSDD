using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using Model;
using Service.AssessmentServices;
using Service.Database;

namespace ViewModel.FormAssessment
{
    public class CompetenceViewModel : ViewModelBase
    {
        public string Title { get => CompetenceModel.Name; }
        public string Description { get => CompetenceModel.Description; }

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
        public Competence CompetenceModel { get; set; }
        private CriterionViewModel _selectedCriterion;

        public CriterionViewModel SelectedCriterion
        {
            get => _selectedCriterion;
            set
            {
                _selectedCriterion = value;
                OnPropertyChanged(nameof(SelectedCriterion));
            }
        }
        public CompetenceViewModel(Competence comp)
        {
            CompetenceModel = comp;
            Criteria = Factory.CreateCriteria(CompetenceModel.Criteria);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
