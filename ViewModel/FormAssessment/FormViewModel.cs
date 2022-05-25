using System.Collections.Generic;
using Model;

namespace ViewModel.FormAssessment
{
    public class FormViewModel : ViewModelBase
    {
        #region Properties

        public string Title
        {
            get => FormModel.Name;
        }

        private IEnumerable<CompetenceViewModel> _competences;
        public IEnumerable<CompetenceViewModel> Competences
        {
            get => _competences;
            set
            {
                _competences = value;
                OnPropertyChanged(nameof(Competences));
            }
        }
        private IEnumerable<IndicatorViewModel> _indicators { get; set; }

        public IEnumerable<IndicatorViewModel> Indicators
        {
            get => _indicators;
            set
            {
                _indicators = value;
                OnPropertyChanged(nameof(Indicators));
            }
        }
        public Form FormModel { get; set; }

        #endregion

        public FormViewModel(Form frmModel)
        {
            FormModel = frmModel;
            Competences = Factory.CreateCompetences(FormModel.Competences);
            Indicators = Factory.CreateIndicators(FormModel.Indicators);
        }
    }
}
