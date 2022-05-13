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
        public GroupViewModel(List<Group> groups)
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
            GroupSelectionCommand = new RelayCommand<AssessmentFormViewModel>((AssessmentFormViewModel? assessment) =>
            {
                //SelectedGroup = assessment;
            });

        }

        #region Commands

        public ICommand GroupSelectionCommand { get; set; }

        #endregion

        #region Properties

        public Group SelectedGroup { get; set; }

        /// <summary>
        /// List of groups related to current selected project
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
