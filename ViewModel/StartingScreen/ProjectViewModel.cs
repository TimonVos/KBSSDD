using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel.StartingScreen
{
    public class ProjectViewModel
    {
        public string Title
        {
            get => ProjectModel.ProjectName;
        }
        public Project ProjectModel { get; set; }

        public ProjectViewModel(Project prjMdl)
        {
            ProjectModel = prjMdl;
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
