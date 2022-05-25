namespace Model
{
    public class ProjectList
    {
        private readonly List<Project> _projects;


        public ProjectList()
        {
            _projects = new List<Project>();
        }

        public IEnumerable<Project> GetProjects()
        {
            return _projects;
        }

        public void AddProject(Project project)
        {
            _projects.Add(project);
        }
    }
}
