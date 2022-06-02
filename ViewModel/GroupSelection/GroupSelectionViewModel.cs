using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Microsoft.Toolkit.Mvvm.Input;
using Model;
using Service.AssessmentServices;
using Service.Database;
using ViewModel.FormAssessment;
using ViewModel.GroupAdmin;

namespace ViewModel
{
    public class GroupSelectionViewModel : ViewModelBase
    {

        private int ProjectID;
        public ProjectViewModel Project { get; set; }
        private GroupManagementHelper _helper = new GroupManagementHelper();

        public RelayCommand AddGroup { get; set; }
        public RelayCommand RemoveGroup { get; set; }
        public RelayCommand ChangeGroupName { get; set; }

        private ObservableCollection<GroupViewModel> _groups;

        public ObservableCollection<GroupViewModel> Groups
        {
            get { return _groups; }
            set
            {
                _groups = value;
                OnPropertyChanged(nameof(Groups));
            }
        }





        // TextBox Content
        public string GroupName { get; set; }
        public string GroupNumber { get; set; }


        private GroupViewModel _selectedGroup;

        public GroupViewModel SelectedGroup
        {
            get { return _selectedGroup; }
            set
            {
                _selectedGroup = value;
                if (_selectedGroup != null)
                {
                    Students = new ObservableCollection<StudentViewModel>();
                }
            }
        }



        //STUDENT PROPERTIES____________

        public RelayCommand AddStudent { get; set; }
        public RelayCommand RemoveStudent { get; set; }

        private ObservableCollection<StudentViewModel> _students;

        public ObservableCollection<StudentViewModel> Students
        {
            get { return _students; }
            set
            {
                using var assessmentContext = new AssessmentContext();
                if (SelectedGroup != null)
                    _students = Factory.CreateStudents(assessmentContext.Groups.Where(grp => grp == SelectedGroup.GroupModel).Select(grp => grp.Students).FirstOrDefault());

                OnPropertyChanged(nameof(Students));
            }
        }

        public StudentViewModel SelectedStudent { get; set; }

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
            this.Project = Factory.GetProject(ProjectID);
            Groups = Factory.CreateGroups(Project.ProjectModel.Groups);
        }

        private void UpdateStudentsHelper()
        {
            using var assessmentContext = new AssessmentContext();

            Students = new ObservableCollection<StudentViewModel>(); // doesn't actually make it into a new ObservableCollection, it just updates Students


        }


        public GroupSelectionViewModel()
        {
            this.Project = Factory.GetProject(this.ProjectID); // SHOULD BE THE PROJECT ID YOU GET FROM PROJECTSELECTION SCREEN
            this.ProjectID = 4;

            //this.ProjectID = projectID;
            using var assessmentContext = new AssessmentContext();

            UpdateGroupsHelper(); // Initial load of all the groups

            //GROUPS________________________________________

            GroupName = "Groep Naam";
            GroupNumber = "Groep Nummer";

            AddGroup = new RelayCommand(() =>
            {
                using var assessmentContext = new AssessmentContext();
                var grps = assessmentContext.Projects.Where(proj => proj.ProjectId == Project.ProjectModel.ProjectId);
                Group tempGroup = new Group();
                tempGroup.Name = GroupName;
                try
                {
                    tempGroup.Number = int.Parse(GroupNumber);
                    _helper.AddGroup(tempGroup, Project.ProjectModel);
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Voer een groepsnummer in");
                }

                UpdateGroupsHelper();
            });



            RemoveGroup = new RelayCommand(() =>
            {
                _helper.RemoveGroup(SelectedGroup.GroupModel);
                UpdateGroupsHelper();
            });

            ChangeGroupName = new RelayCommand(() =>
            {
                try
                {
                    _helper.ChangeGroupName(SelectedGroup.GroupModel, GroupName, int.Parse(GroupNumber));
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Voer een groepsnummer in");
                }
                UpdateGroupsHelper();
            });


            //STUDENTS______________________________________

            StudentName = "Student Naam";
            StudentNumber = "Student Nummer";

            AddStudent = new RelayCommand(() =>
            {
                if (SelectedGroup != null)
                {
                    try
                    {
                        _helper.AddStudent(new Student { Name = StudentName, StudentNumber = int.Parse(StudentNumber) }, SelectedGroup.GroupModel);
                    }
                    catch (System.FormatException)
                    {
                        MessageBox.Show("Voer een getal in voor het studentnummer");
                    }
                    //Students = new ObservableCollection<StudentViewModel>(_selectedGroup.Students);

                }
                else
                {
                    MessageBox.Show("Selecteer een groep");
                }
            });

            RemoveStudent = new RelayCommand(() =>
            {
                if (SelectedStudent != null)
                {
                    _helper.RemoveStudent(SelectedStudent.StudentModel, SelectedGroup.GroupModel);
                } 
                UpdateStudentsHelper();
            });
        }
    }
}
