using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using Microsoft.Toolkit.Mvvm.Input;
using Model;
using Service;
using Service.Database;
using ViewModel.FormAssessment;
using ViewModel.GroupAdmin;
using System.Linq;
using System.Collections.Generic;
using Service.AssessmentServices;

namespace ViewModel
{
    public class GroupSelectionViewModel : ViewModelBase
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public RelayCommand AddGroup { get; set; }
        public RelayCommand RemoveGroup { get; set; }
        public RelayCommand ChangeGroupName { get; set; }

        private ObservableCollection<GroupViewModel> _groups;

        public ObservableCollection<GroupViewModel> Groups
        {
            get { return _groups; }
            set { 
                _groups = value;
                OnPropertyChanged(nameof(Groups));
            }
        }


        public ProjectViewModel Project { get; set; }

        private GroupManagementHelper _helper = new GroupManagementHelper();


        // TextBox Content
        public string GroupName { get; set; }
        public string GroupNumber { get; set; }


        private Group _selectedGroup;

        public Group SelectedGroup
        {
            get { return _selectedGroup; }
            set
            {
                _selectedGroup = value;
                if (_selectedGroup != null)
                {
                    this.Students = new ObservableCollection<Student>(_selectedGroup.Students);
                } else
                {
                    this.Students = new ObservableCollection<Student>();
                }
            }
        }



        //STUDENT PROPERTIES____________

        public RelayCommand AddStudent { get; set; }
        public RelayCommand RemoveStudent { get; set; }

        private ObservableCollection<Student> _students;

        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set
            {
                _students = value;
                OnPropertyChanged(nameof(Students));
            }
        }

        public Student SelectedStudent { get; set; }

        /// <summary>
        /// Student Name TextBox Content
        /// </summary>
        public string StudentName { get; set; }
        /// <summary>
        /// Student Number TextBox Content
        /// </summary>
        public string StudentNumber { get; set; }


        private void UpdateGroupsHelper()
        {
            using var assessmentContext = new AssessmentContext();
            var grps = assessmentContext.Projects.Where(proj => proj.ProjectId == Project.ProjectModel.ProjectId);
            Groups = Factory.CreateGroups(grps.FirstOrDefault().Groups);
        }

        private void AddGroupsHelper()
        {
            using var assessmentContext = new AssessmentContext();
            var grps = assessmentContext.Projects.Where(proj => proj.ProjectId == Project.ProjectModel.ProjectId);
            Group tempGroup = new Group();
            tempGroup.Name = GroupName;
            try
            {
                tempGroup.Number = int.Parse(GroupNumber);
            }
            catch
            {
                MessageBox.Show("Voer een groepsnummer in");
            }
            _helper.AddGroup(tempGroup, Project.ProjectModel);
            UpdateGroupsHelper();
        }

        public GroupSelectionViewModel()
        {
            using var assessmentContext = new AssessmentContext();


            Project = Factory.GetProject();

            List<Group> temp = new List<Group>();
            var grps = assessmentContext.Projects.Where(proj => proj.ProjectId == Project.ProjectModel.ProjectId);
            //GROUPS________________________________________

            if (grps.Count() > 0)
            {
                foreach (var grp in grps.FirstOrDefault().Groups)
                {
                    temp.Add(grp);
                }
            }

            Groups = Factory.CreateGroups(temp);

            
            GroupName = "Groep Naam";
            GroupNumber = "Groep Nummer"; 

            AddGroup = new RelayCommand(() =>
            {
                AddGroupsHelper();
                
            });

            RemoveGroup = new RelayCommand(() =>
            {
                //Groups.Remove(SelectedGroup);
            });

            ChangeGroupName = new RelayCommand(() =>
            {
                /*
                ObservableCollection<Group> TempGroups = Groups;
                for (int i = 0; i < TempGroups.Count; i++)
                {
                    if (TempGroups[i] == SelectedGroup)
                    {
                        TempGroups[i].Name = GroupName;
                    }
                }
                
                Groups = new ObservableCollection<Group>(TempGroups);

                OnPropertyChanged(nameof(Groups));
                */
            });


            //STUDENTS______________________________________

            StudentName = "Student Naam";
            StudentNumber = "Student Nummer";


            AddStudent = new RelayCommand(() =>
            {
                try
                {
                    //SelectedGroup.Students.Add(new Student(int.Parse(StudentNumber), StudentName));
                }
                catch
                {
                    MessageBox.Show("Voer een getal in voor het studentnummer");
                }
                Students = new ObservableCollection<Student>(_selectedGroup.Students);
            });

            RemoveStudent = new RelayCommand(() =>
            {
                this.SelectedGroup.Students.Remove(SelectedStudent);
                //this.Students = SelectedGroup.Students;
            });
        }
    }
}
