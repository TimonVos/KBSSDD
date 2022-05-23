using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Bogus;
using Model;
using Service.AssessmentServices;
using ViewModel.GroupAdmin;

namespace ViewModel.FormAssessment
{
    public class AssessmentFormViewModel : ViewModelBase
    {
        #region Properties

        public ProjectViewModel SelectedProject { get; set; }
        public IEnumerable<AssessmentViewModel> Assessments { get; set; }

        private IEnumerable<GroupViewModel> _groups;
        public IEnumerable<GroupViewModel> Groups
        {
            get => _groups;
            set
            {
                _groups = value;
                OnPropertyChanged(nameof(Groups));
            }
        }

        private GroupViewModel _selectedGroup;

        public GroupViewModel SelectedGroup
        {
            get => _selectedGroup;
            set
            {
                _selectedGroup = value;
                OnPropertyChanged(nameof(SelectedGroup));
            }
        }

        private CompetenceViewModel _selectedCompetence;

        public CompetenceViewModel SelectedCompetence
        {
            get => _selectedCompetence;
            set
            {
                _selectedCompetence = value;
                OnPropertyChanged(nameof(SelectedCompetence));
            }
        }
        private IEnumerable<int> _competenceGrades;
        public IEnumerable<int> CompetenceGrades;

        private FormViewModel _form;
        public FormViewModel Form
        {
            get => _form;
            set
            {
                _form = value;
                OnPropertyChanged(nameof(Form));
            }
        }
        #endregion
        public AssessmentFormViewModel()
        {
            SelectedProject = Factory.GetProject();
            Form = Factory.CreateForm(SelectedProject.ProjectModel.Form);
            Assessments = Factory.CreateAssessments(SelectedProject.ProjectModel.Assessments);
            Groups = Factory.CreateGroups(SelectedProject.ProjectModel.Groups);
        }

    }
}
