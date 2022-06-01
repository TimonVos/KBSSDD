using System.Collections.Generic;
using Model;

namespace ViewModel.FormAssessment
{
    public class CompetenceViewModel : ViewModelBase
    {
        public string Title { get => CompetenceModel.Name; }
        public string Description { get => CompetenceModel.Description; }

        private IEnumerable<CriterionViewModel>? _criteria;
        public IEnumerable<CriterionViewModel>? Criteria
        {
            get => _criteria;
            set
            {
                _criteria = value;
                OnPropertyChanged(nameof(Criteria));
            }
        }
        public Competence CompetenceModel { get; set; }
        private CriterionViewModel? _selectedCriterion;

        public CriterionViewModel? SelectedCriterion
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
