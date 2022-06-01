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
            get => ProjectModel?.Name!;
        }
        public Project? ProjectModel { get; set; }


        public override string ToString()
        {
            return Title;
        }
    }
}
