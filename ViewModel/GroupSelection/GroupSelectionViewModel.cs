using System.Collections;
using System.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Windows;
using Model;
using System.Linq;

namespace ViewModel
{
    public class GroupSelectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public RelayCommand AddGroup { get; set; }
        public RelayCommand RemoveGroup { get; set; }
        public ObservableCollection<Group> Groups { get; set; }


        // TextBox Content
        public string GroupName { get; set; }

        private Group _selectedGroup;

        public Group SelectedGroup
        {
            get { return _selectedGroup; }
            set { 
                _selectedGroup = value;
                this.Students = _selectedGroup.Students;
            }
        }



        //STUDENT PROPERTIES____________

        public RelayCommand AddStudent { get; set; }
        public RelayCommand RemoveStudent { get; set; }

        public ObservableCollection<Student> Students { get; set; }
        public Student SelectedStudent { get; set; }

        /// <summary>
        /// Student Name TextBox Content
        /// </summary>
        public string StudentName { get; set; }
        /// <summary>
        /// Student Number TextBox Content
        /// </summary>
        public string StudentNumber { get; set; }
        

        public GroupSelectionViewModel()
        {
            Groups = new ObservableCollection<Group>();
            

            //GROUPS________________________________________
            GroupName = "Groep";

            
            Groups.Add(new Group("Groep 1"));
            Groups.Add(new Group("Groep 2"));

            Groups[0].Students.Add(new Student(1158062, "Timon Vos"));

            Groups[1].Students.Add(new Student(1130293, "Harm de Boer"));

            AddGroup = new RelayCommand(() =>
            {
                Groups.Add(new Group(GroupName));
            });

            RemoveGroup = new RelayCommand(() =>
            {
                Groups.Remove(SelectedGroup);
            });


            //STUDENTS______________________________________
            
            StudentName = "Student Naam";
            StudentNumber = "Student Nummer";


            AddStudent = new RelayCommand(() =>
            {
                this.Students.Add(new Student(int.Parse(StudentNumber), StudentName));
            });

            RemoveStudent = new RelayCommand(() =>
            {
                this.Students.Remove(SelectedStudent);
            });
        }
    }
}
