using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel.StartingScreen
{
    public class StartingScreenFactory
    {
        public StartingScreenViewModel CreateProjectList(Project project)
        {
            StartingScreenViewModel temp = new StartingScreenViewModel();
            temp.ProjectListModel = project;
            return temp;
        }

        public IEnumerable<StartingScreenViewModel> CreateProjectLists(IEnumerable<Project> projects)
        {
            List<StartingScreenViewModel> temp = new List<StartingScreenViewModel>();
            foreach (Project name in projects)
            {
                temp.Add(CreateProjectList(name));
            }
            return temp;
        }
    }
}
