using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
