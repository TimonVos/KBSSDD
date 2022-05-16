
namespace Model
{
    public class Project
    {
        public Project(string projectName, string projectCode, int projectId, ICollection<ProjectGroup> groups)
        {
            ProjectName = projectName;
            ProjectCode = projectCode;
            ProjectId = projectId;
            Groups = groups;
        }

        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public int ProjectId { get; set; }
        public ICollection<ProjectGroup> Groups { get; set; }

        
    }
}