using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;
using Model;

namespace ViewModel
{
    public class GroupViewModel : INotifyPropertyChanged
    {
        Group testGroup1 = new Group();
        Group testGroup2 = new Group();
        Student st1 = new Student();
        Student st2 = new Student();
        public GroupViewModel()
        {
            testGroup1.Name = "Groep 1";
            testGroup1.Students = new List<Student>();
            testGroup2.Students = new List<Student>();
            st1.Name = "Test Student1";
            st1.StudentNumber = "S1111111";
            testGroup1.Students.Add(st1);
            st2.Name = "Test Student2";
            st2.StudentNumber = "S2222222";
            testGroup1.Students.Add(st2);
            testGroup2.Name = "Groep 2";
            testGroup2.Students.Add(st2);
            GroupList = new ObservableCollection<Group>();
            StudentList = new ObservableCollection<Student>();
            GroupList.Add(testGroup1);
            GroupList.Add(testGroup2);
            InitializeCommands();
        }

        #region Commands
        /// <summary>
        /// Initializes all commands used in GroupViewModel
        /// </summary>
        private void InitializeCommands()
        {
            InitializeGroupSelectionCommand();
            InitializeGroupDeleteCommand();
        }
        /// <summary>
        /// Group selection in group administration screen
        /// Sets selected group to the one given in the command parameter
        /// Clears current viewed StudentList
        /// Will then add each student from the selected group to the StudentList for viewing
        /// </summary>
        private void InitializeGroupSelectionCommand()
        {
            GroupSelectionCommand = new RelayCommand<Group>((group) =>
            {
                SelectedGroup = group;
                StudentList?.Clear();
                if (SelectedGroup?.Students == null)
                {
                    return;
                }
                foreach (Student student in SelectedGroup.Students)
                {
                    StudentList?.Add(student);
                }
            });
        }
        /// <summary>
        /// Simple command that removes the current SelectedGroup from the GroupList
        /// (Will later need to interface with database and remove group from database)
        /// </summary>
        private void InitializeGroupDeleteCommand()
        {
            GroupDeleteCommand = new RelayCommand(() =>
            {
                if (SelectedGroup == null)
                {
                    return;
                }
                GroupList?.Remove(SelectedGroup);
            });
        }
        public ICommand GroupSelectionCommand { get; set; }
        public ICommand GroupDeleteCommand { get; set; }
        #endregion

        #region Properties
        /// <summary>
        /// Simple property to keep track of current selected group in group administration
        /// </summary>
        private Group? SelectedGroup { get; set; }
        /// <summary>
        /// List of groups shown in the group administration screen
        /// </summary>
        private ObservableCollection<Group>? _groupList;
        public ObservableCollection<Group>? GroupList
        {
            get => _groupList;

            set
            {
                _groupList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_groupList)));
            }
        }
        /// <summary>
        /// List of Students from the currently selected group in the group administration screen
        /// </summary>
        private ObservableCollection<Student>? _studentList;

        public ObservableCollection<Student>? StudentList
        {
            get => _studentList;
            set
            {
                _studentList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_studentList)));
            }
        }

            #endregion
        #region PropertyChanged implementation
        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
