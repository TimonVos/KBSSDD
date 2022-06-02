using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;
using Model;
using Service.Database;

namespace ViewModel.StartingScreen
{
    public class ProjectViewModel : ViewModelBase
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
