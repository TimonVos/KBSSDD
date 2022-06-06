using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;
using Model;
using Service.Database;
using Service.AssessmentServices;


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

        private StartingScreenHelper _helper =new StartingScreenHelper();

        // check voor voor id 1 of id 2 bij form voor 
        public RelayCommand AddPrj { get; set; }

        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public bool IsChecked { get; set; }

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

        private void UpdateProjectsHelper()
        {
            this.Projects = Factory.CreateProjects();
        }


        public StartingScreenViewModel()
        {
            this.ProjectName = "Project Naam";
            this.ProjectCode = "Project Code";

            using var context = new AssessmentContext();
            Projects = Factory.CreateProjects();

            AddPrj = new RelayCommand(() =>
            {
                if(ProjectName != string.Empty && ProjectCode != string.Empty)
                {
                    _helper.AddNewProject(ProjectName, ProjectCode, IsChecked);

                    UpdateProjectsHelper();
                }
            });
        }
    }
}
