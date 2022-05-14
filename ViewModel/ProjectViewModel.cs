using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    internal class ProjectViewModel
    {
        public ProjectViewModel(Project project)
        {
            Project = project;
        }

        public Project Project { get; set; }
    }
}
