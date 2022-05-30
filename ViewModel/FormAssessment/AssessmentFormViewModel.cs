﻿using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Model;
using ViewModel.GroupAdmin;

namespace ViewModel.FormAssessment
{
    public class AssessmentFormViewModel : ViewModelBase
    {
        #region Properties

        public ProjectViewModel SelectedProject { get; set; }
        public IEnumerable<SubjectViewModel> Subjects { get; set; }

        private SubjectViewModel _selectedSubject;

        public SubjectViewModel SelectedSubject
        {
            get => _selectedSubject;
            set
            {
                _selectedSubject = value;
                OnPropertyChanged(nameof(SelectedSubject));
            }
        }
        
        private GroupViewModel _selectedGroup;
        public GroupViewModel SelectedGroup
        {
            get => _selectedGroup;
            set
            {
                _selectedGroup = value;
                List<SubjectViewModel> temp = new List<SubjectViewModel>();
                temp.Add(_selectedGroup);
                foreach (StudentViewModel std in _selectedGroup.Students)
                {
                    temp.Add(std);
                }
                Subjects = temp;
                SelectedSubject = _selectedGroup;
                OnPropertyChanged(nameof(SelectedGroup));
            }
        }

        private IEnumerable<RatingViewModel> _ratings;
        public IEnumerable<RatingViewModel> Ratings
        {
            get => _ratings;
            set
            {
                _ratings = value;
                OnPropertyChanged(nameof(Ratings));
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

        public IDictionary<Competence, double> CompetenceGrades
        {
            get => Helper.GetGrades(SelectedGroup.SelectedAssessment.AssessmentModel);
        }
        #endregion
        public AssessmentFormViewModel()
        {
            SelectedProject = Factory.GetProject();
            Form = Factory.CreateForm(SelectedProject.ProjectModel.Form);
            SelectedGroup = Factory.CreateGroup(SelectedProject.ProjectModel.Groups.Where(grp => grp.Name == "Groep 1").FirstOrDefault());
            Ratings = Factory.CreateRatings(SelectedGroup.SelectedAssessment.AssessmentModel.Ratings);
        }

    }
}