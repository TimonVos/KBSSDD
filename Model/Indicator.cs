namespace Model
{
    /// <summary>
    /// Model for the indicators that are connected to the criteria assessments which indicate the final project grade
    /// </summary>
    public class Indicator
    {
        public Indicator(int indicatorId, string name, ICollection<CriterionAssessment> criterionAssessment)
        {
            IndicatorId = indicatorId;
            Name = name;
            CriterionAssessment = criterionAssessment;
        }

        public int IndicatorId { get; set; }
        public string Name { get; set; }
        public ICollection<CriterionAssessment> CriterionAssessment { get; set; }
    }
}
