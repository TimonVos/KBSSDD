using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel.FormAssessment
{
    public class CompetenceViewModel
    {
        public string Title
        {
            get => CompetenceModel.CompetenceName;
        }

        public string Description
        {
            get => CompetenceModel.CompetenceDescription;
        }
        public Competence CompetenceModel { get; set; }
        public IEnumerable<CriterionViewModel> Criteria { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
