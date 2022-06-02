using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Windows.Input;
using System.Windows.Media.Imaging;
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

        public ProjectViewModel? SelectedProject { get; set; }
        public IEnumerable<SubjectViewModel>? Subjects { get; set; }

        private List<RequirementViewModel> _selectedRequirements { get; set; }

        public List<RequirementViewModel> SelectedRequirements
        {
            get => _selectedRequirements;
            set
            {
                _selectedRequirements = value;
                OnPropertyChanged(nameof(SelectedRequirements));
            }
        }
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
                if (_selectedCompetence != null)
                {
                    foreach (CriterionViewModel criterion in _selectedCompetence.Criteria)
                    {
                        foreach (RequirementViewModel requirement in criterion.Requirements)
                        {
                            requirement.IsChecked = false;
                        }
                    }
                }
                _selectedCompetence = value;
                OnPropertyChanged(nameof(SelectedCompetence));
                Load();
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

        public IDictionary<Competence, double>? CompetenceGrades
        {
            get => Helper.GetGrades(SelectedGroup?.SelectedAssessment.AssessmentModel!);
        }
        #endregion
        #region Commands

        public ICommand SaveCommand { get; set; }

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
        }

        private void Load()
        {
            SelectedRequirements.Clear();
            using (var db = new AssessmentContext())
            {
                var ratings = Helper.GetRatings(SelectedGroup.Assessments.FirstOrDefault().AssessmentModel, SelectedCompetence.CompetenceModel);
                foreach (var rating in ratings)
                {
                    foreach (CriterionViewModel criterion in SelectedCompetence.Criteria)
                    {
                        if (rating.CriterionId == criterion.CriterionModel.CriterionId)
                        {
                            RequirementViewModel temp = criterion.Requirements
                                .Where(r => r.RequirementModel.RequirementId == rating.RequirementId).FirstOrDefault();
                            temp.IsChecked = true;
                            SelectedRequirements.Add(temp);
                        }
                    }
                }
            }
        }
        #endregion

        public void Initialize(Project project, Group group)
        {
            SelectedProject = Factory.CreateProject(project);
            SelectedGroup = Factory.CreateGroup(group);
            Form = Factory.CreateForm(SelectedProject.ProjectModel.Form);
            SelectedRequirements = new List<RequirementViewModel>();
            SelectedCompetence = Form.Competences.FirstOrDefault();
        }
        public AssessmentFormViewModel()
        {
            SaveCommand = new RelayCommand<RequirementViewModel>((RequirementViewModel? requirement) =>
            {
                Save(requirement!);
            });
            using var db = new AssessmentContext();
            Initialize(db.Projects.FirstOrDefault(), db.Groups.FirstOrDefault());
        }

    }
}
