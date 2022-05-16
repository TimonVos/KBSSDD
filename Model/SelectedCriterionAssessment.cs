using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class SelectedCriterionAssessment
    {
        public SelectedCriterionAssessment(int assessmentId, FormAssessment assessment, CriterionAssessment criteriumAssessment)
        {
            AssessmentId = assessmentId;
            Assessment = assessment;
            CriteriumAssessment = criteriumAssessment;
        }

        public int AssessmentId { get; set; }
        public FormAssessment Assessment { get; set; }
        public virtual CriterionAssessment CriteriumAssessment { get; set; }

    }
}
