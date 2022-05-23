using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service.Database;

namespace ViewModel.StartingScreen
{
    public class StartingScreenFactory
    {

        public AssessmentContext assessmentContext = new AssessmentContext();


        public ProjectViewModel CreateProject(Project project)
        {
            ProjectViewModel temp = new ProjectViewModel();
            temp.ProjectModel = project;
            return temp;
        }

        public IEnumerable<ProjectViewModel> CreateProjects(IEnumerable<Project> projects)
        {
            List<ProjectViewModel> temp = new List<ProjectViewModel>();
            foreach (Project prj in projects)
            {
                temp.Add(CreateProject(prj));
            }
            return temp;
        }
    }
}
