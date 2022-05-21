using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel.FormAssessment
{
    public class RequirementViewModel
    {
        public string Description
        {
            get => CriterionAssessmentModel.CriterionAssessmentDescription;
        }

        public string Title
        {
            get
            {
                return CriterionAssessmentModel.Criterion.CriterionName;
            }
        }

        public string GroupName
        {
            get
            {
                return CriterionAssessmentModel.Criterion.GetHashCode().ToString();
            }
        }

        public IndicatorViewModel Indicator { get; set; }

        public Requirement CriterionAssessmentModel { get; set; }
    }
}
