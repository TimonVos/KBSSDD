using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;
using Model;
using Service.Database;


namespace ViewModel.StartingScreen
{
    public class StartingScreenViewModel : ViewModelBase
    {

        private IEnumerable<ProjectViewModel>? _projects;
        public IEnumerable<ProjectViewModel>? Projects
        {
            get => _projects;
            set
            {
                _projects = value;
                OnPropertyChanged(nameof(Projects));
            }
        }






        // check voor voor id 1 of id 2 bij form voor 
        public RelayCommand AddPrj { get; set; }

        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }

        public StartingScreenViewModel()
        {
            ProjectName = "Project naam";
            ProjectCode = "Project code";

            AddPrj = new RelayCommand(() =>
            {
                if(ProjectName != string.Empty && ProjectCode != string.Empty)
                {

                }
            });
        }
 
    }
}



