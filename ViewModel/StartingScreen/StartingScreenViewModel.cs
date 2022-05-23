using System.Collections.Generic;
using Model;


namespace ViewModel.StartingScreen
{
    public class StartingScreenViewModel : ViewModelBase
    {

        private IEnumerable<ProjectViewModel> _projects;
        public IEnumerable<ProjectViewModel> Projects 
        { 
            get => _projects;
            set
            {
                _projects = value;
                OnPropertyChanged(nameof(Projects));
            }
        }

        public StartingScreenViewModel()
        {
            _projects = Factory.CreateProjects(Factory.assessmentContext.projects);
        }
    }
}


