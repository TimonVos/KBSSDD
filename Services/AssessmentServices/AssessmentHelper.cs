using Model;

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
        public double getCompetenceGrade(Competence comp, Assessment assessment)
        {
            double critAmount = 0;
            double grade = 0;
            IEnumerable<Rating> selectedRatings = assessment.Ratings;
            foreach (Rating rating in selectedRatings)
            {
                critAmount++;
                grade += rating.Requirement.Indicator.Value;
            }
            return grade / critAmount;
        }
    }
}
