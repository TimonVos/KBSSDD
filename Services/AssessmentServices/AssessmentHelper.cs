using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Model;
using Service.Database;

namespace Service.AssessmentServices
{
    public class AssessmentHelper
    {
        /// <summary>
        /// Calculates the current grade for the competence
        /// </summary>
        /// <param name="context">current data context</param>
        /// <param name="assessment">current assessment being calculated for</param>
        /// <param name="comp">current competence currently being graded</param>
        /// <returns>final rating for a competence</returns>
        public double getCompetenceGrade(AssessmentContext context, Assessment assessment, Competence comp)
        {
            double critAmount = 0;
            double grade = 0;
            IEnumerable<Rating> selectedRatings = new List<Rating>();
            foreach (Criterion crit in comp.Criteria)
            {
                selectedRatings = (from rating in context.Ratings 
                    where rating.AssessmentId == assessment.AssessmentId 
                    select rating);
            }

            foreach (Rating rating in selectedRatings)
            {
                critAmount++;
                grade += rating.Requirement.Indicator.Value;
            }

            return grade / critAmount;
        }
    }
}
