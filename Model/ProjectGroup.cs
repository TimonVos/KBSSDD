namespace Model
{
    public class ProjectGroup
    {
        public ProjectGroup(int groupId, int groupNumber, Project project)
        {
            GroupId = groupId;
            GroupNumber = groupNumber;
            Project = project;
            this.Students = new HashSet<Student>();
        }

        public int GroupId { get; set; }
        public int GroupNumber { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public ICollection<FormAssessment> Assessments { get; set; }

    }
}
