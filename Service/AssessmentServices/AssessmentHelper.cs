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
        public IDictionary<Competence, double> GetGrades(Assessment assessment)
        {
            IDictionary<Competence, double> temp = new Dictionary<Competence, double>();
            int critAmount = 0;
            double grade = 0;
            int ratingAmount = 0;
            Competence prevComp = assessment.Ratings.FirstOrDefault().Criterion.Competence;
            
            IEnumerable<Rating> selectedRatings = assessment.Ratings;
            foreach (Rating rating in selectedRatings)
            {
                if (prevComp != rating.Criterion.Competence)
                {
                    temp.Add(prevComp ,grade / critAmount);
                    prevComp = rating.Criterion.Competence;
                    critAmount = 0;
                    grade = 0;
                }
                critAmount++;
                ratingAmount++;
                grade += rating.Requirement.Indicator.Value;
                if (ratingAmount == selectedRatings.Count())
                {
                    temp.Add(prevComp, Math.Round(grade / critAmount, 2));
                }
            }
            return temp;
        }
        /// <summary>
        /// Calculates the final grade of an assessment
        /// </summary>
        /// <param name="CompetenceGrades">Dictionary of all the competence grades</param>
        /// <returns>double of the final grade</returns>
        public double CalculateFinalGrade(IDictionary<Competence, double> CompetenceGrades)
        {
            double finalGrade = 0;
            foreach (Competence comp in CompetenceGrades.Keys)
            {

                finalGrade += (CompetenceGrades[comp]) * (comp.Weight / 100);
            }

            finalGrade = Math.Round(finalGrade);
            return finalGrade;
        }
        /// <summary>
        /// Checks if a competence has been completely filled in on the form
        /// </summary>
        /// <param name="comp">Competence being checked</param>
        /// <param name="ratings">List of ratings from the assessment</param>
        /// <returns>boolean that tells you if a competence is complete</returns>
        public bool CheckCriteriaAmount(Competence comp, IEnumerable<Rating> ratings)
        {
            int amount = 0;
            foreach (Rating rating in ratings)
            {
                if (rating.Criterion.Competence == comp)
                {
                    amount++;
                }
            }
            if (amount < comp.Criteria.Count)
            {
                return false;
            }
            else return true;
        }
        /// <summary>
        /// Checks if an assessment has been completely filled in
        /// </summary>
        /// <param name="assess">Assessment to be checked</param>
        /// <returns>boolean, false if not everything is filled in true if it is</returns>
        public bool CheckAssessmentComplete(Assessment assess)
        {
            foreach (Competence comp in assess.Project.Form.Competences)
            {
                if (CheckCriteriaAmount(comp, assess.Ratings) == false)
                {
                    return false;
                }
            }
            return true;
        }

        public void SaveRating(Assessment assessment, Requirement requirement)
        {
            using var context = new AssessmentContext();
            if (context.Assessments.Count(assess => assess.AssessmentId == assessment.AssessmentId) > 0)
            {
                assessment.Ratings.Add(new Rating{Assessment = assessment, Criterion = requirement.Criterion, Requirement = requirement});
                context.Update(assessment);
                context.SaveChanges();
            }
            else
            {
                context.Assessments.Add(assessment);
                assessment.Ratings.Add(new Rating { Assessment = assessment, Criterion = requirement.Criterion, Requirement = requirement });
                context.Update(assessment);
                context.SaveChanges();
            }
        }

    }
}
