using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public IEnumerable<CompetenceViewModel> Competences { get; set; }
        public IEnumerable<IndicatorViewModel> Indicators { get; set; }
        public Form FormModel { get; set; }

        #endregion

        public FormViewModel()
        {
            Competences = Factory.CreateCompetences(FormModel.Competences);
            Indicators = Factory.CreateIndicators(FormModel.Indicators);
        }
    }
}
