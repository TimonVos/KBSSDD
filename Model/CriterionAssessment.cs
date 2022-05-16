using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// Model for the selectable assessments for a criterion on assessment form
    /// </summary>
    public class CriterionAssessment
    {
        public CriterionAssessment(int criterionAssessmentId, string criterionAssessmentDescription, int indicatorId, Indicator indicator, int criterionId, Criterion criterion)
        {
            CriterionAssessmentId = criterionAssessmentId;
            CriterionAssessmentDescription = criterionAssessmentDescription;
            IndicatorId = indicatorId;
            Indicator = indicator;
            CriterionId = criterionId;
            Criterion = criterion;
        }
        public int CriterionId { get; set; }
        public Criterion Criterion { get; set; }
        public int CriterionAssessmentId { get; set; }
        public string CriterionAssessmentDescription { get; set; }
        public int IndicatorId { get; set; }
        public Indicator Indicator { get; set; }
    }
}
