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
        public IDictionary<Competence, double> GetGrades(Assessment assessment)
        {
            IDictionary<Competence, double> temp = new Dictionary<Competence, double>();
            double critAmount = 0;
            double grade = 0;
            Competence prevComp = assessment.Ratings.FirstOrDefault().Criterion.Competence;
            
            IEnumerable<Rating> selectedRatings = assessment.Ratings;
            foreach (Rating rating in selectedRatings)
            {
                critAmount++;
                grade += rating.Requirement.Indicator.Value;
                if (prevComp != rating.Criterion.Competence)
                {
                    prevComp = rating.Criterion.Competence;
                    temp.Add(rating.Criterion.Competence ,grade / critAmount);
                }
            }
            return temp;
        }

    }
}
