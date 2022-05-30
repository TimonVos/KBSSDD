using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using Microsoft.Toolkit.Mvvm.Input;
using Model;

namespace ViewModel
{
    public class GroupSelectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public RelayCommand AddGroup { get; set; }
        public RelayCommand RemoveGroup { get; set; }
        public RelayCommand ChangeGroupName { get; set; }
        public ObservableCollection<Group> Groups { get; set; }


        // TextBox Content
        public string GroupName { get; set; }


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
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Students)));
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


        public GroupSelectionViewModel()
        {
            Groups = new ObservableCollection<Group>();


            //GROUPS________________________________________
            GroupName = "Groep Naam";

            Groups.Add(new Group("Groep 1"));
            Groups.Add(new Group("Groep 2"));
            Groups.Add(new Group("Groep 3"));
            Groups.Add(new Group("Groep 4"));
            Groups.Add(new Group("Groep 5"));
            Groups.Add(new Group("Groep 6"));
            Groups.Add(new Group("Groep 7"));
            Groups.Add(new Group("Groep 8"));
            Groups.Add(new Group("Groep 9"));
            Groups.Add(new Group("Groep 10"));
            Groups.Add(new Group("Groep 11"));
            Groups.Add(new Group("Groep 12"));

            Groups[0].Students.Add(new Student(1234567, "John Doe"));
            Groups[0].Students.Add(new Student(2345678, "Jane Doe"));

            AddGroup = new RelayCommand(() =>
            {
                Groups.Add(new Group(GroupName));
            });

            RemoveGroup = new RelayCommand(() =>
            {
                Groups.Remove(SelectedGroup);
            });

            ChangeGroupName = new RelayCommand(() =>
            {
                ObservableCollection<Group> TempGroups = Groups;
                for (int i = 0; i < TempGroups.Count; i++)
                {
                    if (TempGroups[i] == SelectedGroup)
                    {
                        TempGroups[i].Name = GroupName;
                    }
                }
                
                Groups = new ObservableCollection<Group>(TempGroups);

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Groups)));
            });


            //STUDENTS______________________________________

            StudentName = "Student Naam";
            StudentNumber = "Student Nummer";


            AddStudent = new RelayCommand(() =>
            {
                try
                {
                    SelectedGroup.Students.Add(new Student(int.Parse(StudentNumber), StudentName));
                }
                catch
                {
                    MessageBox.Show("Voeg een getal in voor het studentnummer");
                }
                Students = new ObservableCollection<Student>(_selectedGroup.Students);
            });

            RemoveStudent = new RelayCommand(() =>
            {
                this.SelectedGroup.Students.Remove(SelectedStudent);
                this.Students = SelectedGroup.Students;
            });
        }
    }
}
