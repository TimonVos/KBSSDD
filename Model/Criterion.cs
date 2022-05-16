namespace Model
{
    /// <summary>
    /// Model for the criteria at which the competence is assessed on an assessment form
    /// </summary>
    public class Criterion
    {
        public Criterion(int criterionId, string criterionName, string criterionDescription, int competenceId, Competence competence, ICollection<CriterionAssessment> criterionAssessments)
        {
            CriterionId = criterionId;
            CriterionName = criterionName;
            CriterionDescription = criterionDescription;
            CompetenceId = competenceId;
            Competence = competence;
            CriterionAssessments = criterionAssessments;
        }

        public int CriterionId { get; set; }
        public string CriterionName { get; set; }
        public string CriterionDescription { get; set; }
        public int CompetenceId { get; set; }
        public Competence Competence { get; set; }
        public ICollection<CriterionAssessment> CriterionAssessments { get; set; }

    }
}
