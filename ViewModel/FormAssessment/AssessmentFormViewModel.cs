using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Security.RightsManagement;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Toolkit.Mvvm.Input;
using Model;
using Service.Database;
using ViewModel.GroupAdmin;
using ViewModel.StartingScreen;

namespace ViewModel.FormAssessment
{
    public class AssessmentFormViewModel : ViewModelBase
    {
        #region Properties

        private double _projectGrade;

        public double ProjectGrade
        {
            get => _projectGrade;
            set
            {
                _projectGrade = value;
                OnPropertyChanged(nameof(ProjectGrade));
            }
        }
        public ProjectViewModel? SelectedProject { get; set; }
        public Project? Project { get; set; }
        public IEnumerable<SubjectViewModel>? Subjects { get; set; }

        private SubjectViewModel _selectedSubject;

        public SubjectViewModel? SelectedSubject
        {
            get => _selectedSubject;
            set
            {
                _selectedSubject = value;
                OnPropertyChanged(nameof(SelectedSubject));
            }
        }
        
        private GroupViewModel? _selectedGroup;
        public GroupViewModel? SelectedGroup
        {
            get => _selectedGroup;
            set
            {
                _selectedGroup = value;
                List<SubjectViewModel> temp = new List<SubjectViewModel>();
                temp.Add(_selectedGroup!);
                foreach (StudentViewModel std in _selectedGroup?.Students!)
                {
                    temp.Add(std);
                }
                Subjects = temp;
                SelectedSubject = _selectedGroup;
                OnPropertyChanged(nameof(SelectedGroup));
            }
        }

        private IEnumerable<RatingViewModel>? _ratings;
        public IEnumerable<RatingViewModel>? Ratings
        {
            get => _ratings;
            set
            {
                _ratings = value;
                OnPropertyChanged(nameof(Ratings));
            }
        }

        private CompetenceViewModel? _selectedCompetence;

        public CompetenceViewModel? SelectedCompetence
        {
            get => _selectedCompetence;
            set
            {
                _selectedCompetence = value;
                OnPropertyChanged(nameof(SelectedCompetence));
            }
        }


        private FormViewModel? _form;
        public FormViewModel? Form
        {
            get => _form;
            set
            {
                _form = value;
                OnPropertyChanged(nameof(Form));
            }
        }

        private IDictionary<Competence, double>? _competenceGrades;
        public IDictionary<Competence, double>? CompetenceGrades
        {
            get => _competenceGrades;
            set
            {
                _competenceGrades = value;
                OnPropertyChanged(nameof(CompetenceGrades));
            }
        }
        #endregion
        #region Commands

        public ICommand SaveCommand { get; set; }
        public ICommand LoadCommand { get; set; }

        private void Save(RequirementViewModel requirement)
        {
            if (!SelectedGroup.Assessments.Any())
            {
                Assessment temp = new Assessment();
                temp.Project = SelectedProject.ProjectModel;
                temp.Group = SelectedGroup.GroupModel;
                Helper.SaveRating(temp, requirement.RequirementModel);
                SelectedGroup.Assessments = new List<AssessmentViewModel>
                {
                    Factory.CreateAssessment(temp)
                };
            }
            else
            {
                Helper.SaveRating(SelectedGroup.Assessments.FirstOrDefault().AssessmentModel, requirement.RequirementModel);
            }

            requirement.IsChecked = true;
            using (var db = new AssessmentContext())
            {
                Assessment oldModel = SelectedGroup.Assessments.FirstOrDefault().AssessmentModel;
                Assessment newModel = db.Assessments.
                    Include(a=> a.Ratings).ThenInclude(r => r.Criterion).ThenInclude(c => c.Competence)
                    .Include(a => a.Ratings).ThenInclude(r => r.Requirement).ThenInclude(r => r.Indicator)
                    .First(a => a.AssessmentId == oldModel.AssessmentId);
                SelectedGroup.Assessments.FirstOrDefault().AssessmentModel = newModel;
            }
            Load(requirement);
        }

        private void Load(RequirementViewModel requirement)
        {
            using (var db = new AssessmentContext())
            {
                requirement.IsChecked = Helper.GetRating(SelectedGroup.Assessments.FirstOrDefault().AssessmentModel,
                    requirement.RequirementModel);
            }

            CompetenceGrades = Helper.GetGrades(SelectedGroup?.SelectedAssessment.AssessmentModel!);
            ProjectGrade = Helper.CalculateFinalGrade(CompetenceGrades);
        }
        #endregion

        public void Initialize(Project project, Group group)
        {
            SelectedProject = Factory.CreateProject(project);
            SelectedGroup = Factory.CreateGroup(group);
            Form = Factory.CreateForm(SelectedProject.ProjectModel.Form);
            SelectedCompetence = Form.Competences.FirstOrDefault();
        }
        public AssessmentFormViewModel()
        {
            SaveCommand = new RelayCommand<RequirementViewModel>((RequirementViewModel? requirement) =>
            {
                Save(requirement!);
            });
            LoadCommand = new RelayCommand<RequirementViewModel>((RequirementViewModel? requirement) =>
            {
                Load(requirement);
            });
            using var db = new AssessmentContext();
            var project = db.Projects.FirstOrDefault();
            Initialize(project, db.Assessments.Where(a => a.Project == project).Include(a => a.Group).FirstOrDefault().Group);
        }
    }
}
