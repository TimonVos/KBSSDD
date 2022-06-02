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
        public ProjectViewModel? Project {
            get => _project;
            set
            {
                if (value != _project)
                {
                    _project = value;
                    OnPropertyChanged(nameof(Project));
                }

                if (_project == null)
                    CanContinue = false;
                else
                    CanContinue = true;
            }
        }
        public bool CanContinue {
            get => _canContinue;
            set
            {
                if (value != _canContinue)
                {
                    _canContinue = value;
                    OnPropertyChanged(nameof(CanContinue));
                }
            }
        }

        private ProjectViewModel? _project;
        private bool _canContinue;

        public StartingScreenViewModel()
        {
            ProjectName = "Project naam";
            ProjectCode = "Project code";

            using var context = new AssessmentContext();
            Projects = Factory.CreateProjects();

            AddPrj = new RelayCommand(() =>
            {
                if(ProjectName != string.Empty && ProjectCode != string.Empty)
                {

                }
            });
        }
    }
}
