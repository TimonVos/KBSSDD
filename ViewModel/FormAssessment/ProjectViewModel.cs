using Model;

namespace ViewModel.FormAssessment
{
    public class ProjectViewModel
    {
        public Project ProjectModel { get; set; }

        public ProjectViewModel(Project prjModel)
        {
            ProjectModel = prjModel;
        }
    }
}
