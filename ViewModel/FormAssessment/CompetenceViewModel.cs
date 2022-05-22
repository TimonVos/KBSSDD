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
        public string Title { get => CompetenceModel.Name; }
        public string Description { get => CompetenceModel.Description; }
        public IEnumerable<CriterionViewModel> Criteria { get; set; }
        public Competence CompetenceModel { get; set; }
        public CriterionViewModel SelectedCriterion { get; set; }
        public CompetenceViewModel()
        {
            Criteria = Factory.CreateCriteria(CompetenceModel.Criteria);
        }
    }
}
