namespace Model
{
    /// <summary>
    /// Model for the indicators that are connected to the criteria assessments which indicate the final project grade
    /// </summary>
    public class Indicator
    {
        public Indicator(int indicatorId, string name, ICollection<Requirement> criterionAssessment, int grade)
        {
            IndicatorId = indicatorId;
            Name = name;
            CriterionAssessment = criterionAssessment;
            GradeEquivalent = grade;
        }

        public int IndicatorId { get; set; }
        public string Name { get; set; }
        public int GradeEquivalent { get; set; }
        public ICollection<Requirement> CriterionAssessment { get; set; }
    }
}
