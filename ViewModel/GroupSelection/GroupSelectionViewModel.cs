using System.Collections;
using System.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;
using Model;
using System.Linq;

namespace ViewModel
{
    public class GroupSelectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public delegate int SelectedGroupChanged(object sender, int index);

        public RelayCommand AddGroup { get; set; }
        public RelayCommand RemoveGroup { get; set; }
        public ObservableCollection<Group> Groups { get; set; }
        private ObservableCollection<string> _groupNames = new ObservableCollection<string>();

        public ObservableCollection<string> GroupNames
        {
            get
            {
                _groupNames.Clear();
                foreach (Group group in Groups)
                {
                    _groupNames.Add(group.Name);
                };
                return _groupNames;
            }
            set { _groupNames = value; }
        }

        public string GroupName { get; set; }
        public string SelectedGroup { get; set; }


        public RelayCommand AddStudent { get; set; }
        public RelayCommand RemoveStudent { get; set; }
        public string StudentName { get; set; }
        public string StudentNumber { get; set; }
        public string SelectedStudent { get; set; }

        private ObservableCollection<string> _studentNames = new ObservableCollection<string>();

        public ObservableCollection<string> StudentNames
        {
            get
            {
                
                foreach (var GroupInstance in Groups)
                {
                    if (GroupInstance.Name.Equals(SelectedGroup))
                    {
                        foreach (Student student in GroupInstance.Students)
                        {
                            _studentNames.Add($"{student.StudentId} - ({student.StudentName})");
                        }
                    }
                }
                return _studentNames;
            }
        }


        public GroupSelectionViewModel()
        {

            //GROUPS________________________________________
            GroupName = "Groep";

            Groups = new ObservableCollection<Group>();
            Groups.Add(new Group("Groep 1"));
            Groups.Add(new Group("Groep 2"));

            Groups[0].Students.Add(new Student(1158062, "Timon Vos"));

            AddGroup = new RelayCommand(() =>
            {
                Groups.Add(new Group(GroupName));
            });

            RemoveGroup = new RelayCommand(() =>
            {
                foreach (var GroupInstance in Groups)
                {
                    if (GroupInstance.Name.Equals(SelectedGroup))
                    {
                        Groups.Remove(GroupInstance);
                    }
                }
            });


            //STUDENTS______________________________________
            
            StudentName = "Student Naam";
            StudentNumber = "Student Nummer";


            AddStudent = new RelayCommand(() =>
            {
                
            });

            RemoveStudent = new RelayCommand(() =>
            {
                
                
            });
            

            
        }
    }
}
