using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Rating
    {
        public Rating(int assessmentId, FormAssessment assessment, Requirement requirement)
        {
            AssessmentId = assessmentId;
            Assessment = assessment;
            Requirement = requirement;
        }

        public int AssessmentId { get; set; }
        public FormAssessment Assessment { get; set; }
        public virtual Requirement Requirement { get; set; }

    }
}
