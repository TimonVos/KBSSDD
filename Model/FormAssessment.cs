namespace Model
{
    /// <summary>
    /// Model for the final assessment of a group
    /// </summary>
    public class FormAssessment
    {
        public FormAssessment(int assessmentId, int groupId, ProjectGroup @group)
        {
            AssessmentId = assessmentId;
            GroupId = groupId;
            Group = @group;
        }

        public int AssessmentId { get; set; }
        public int GroupId { get; set; }
        public ProjectGroup Group { get; set; }

        public ICollection<SelectedCriterionAssessment> SelectedAssessments { get; set; }

    }
}
