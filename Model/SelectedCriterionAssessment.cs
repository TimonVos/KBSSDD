using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SelectedCriterionAssessment
    {
        public SelectedCriterionAssessment(int assessmentId, FormAssessment assessment, CriterionAssessment criterionAssessment)
        {
            AssessmentId = assessmentId;
            Assessment = assessment;
            CriterionAssessment = criterionAssessment;
        }

        public int AssessmentId { get; set; }
        public FormAssessment Assessment { get; set; }
        public virtual CriterionAssessment CriterionAssessment { get; set; }

    }
}
