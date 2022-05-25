namespace Model
{
    public class Assessment
    {
        private readonly ProjectList _projectList;

        public Assessment()
        {
            _projectList = new ProjectList();
        }
        /// <summary>
        /// Get the projects in the system
        /// </summary>
        /// <returns>List of projects currently in the system</returns>
        public IEnumerable<Project> GetProjects()
        {
            return _projectList.GetProjects();
        }

    }
}
