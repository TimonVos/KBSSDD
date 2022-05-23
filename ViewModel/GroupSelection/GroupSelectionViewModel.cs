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


        // TextBox Content
        public string GroupName { get; set; }
        public string SelectedGroup { get; set; }

        private int _selectedGroupIndex;

        public int SelectedGroupIndex
        {
            get { return _selectedGroupIndex; }
            set {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedGroupIndex)));
                _selectedGroupIndex = value; 
            }
        }


        //STUDENT PROPERTIES____________

        public RelayCommand AddStudent { get; set; }
        public RelayCommand RemoveStudent { get; set; }


        /// <summary>
        /// Student Name TextBox Content
        /// </summary>
        public string StudentName { get; set; }
        /// <summary>
        /// Student Number TextBox Content
        /// </summary>
        public string StudentNumber { get; set; }

        /// <summary>
        /// List of studentnames
        /// </summary>
        private ObservableCollection<string> _studentNames = new ObservableCollection<string>();

        public ObservableCollection<string> StudentNames
        {
            get
            {
                _studentNames.Clear();
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

            Groups[SelectedGroupIndex].Students.Add(new Student(1158062, "Timon Vos"));
            Groups[0].Students.Add(new Student(1145823, "Jan Doedel"));

            Groups[1].Students.Add(new Student(1130293, "Harm de Boer"));

            AddGroup = new RelayCommand(() =>
            {
                Groups.Add(new Group(GroupName));
            });

            RemoveGroup = new RelayCommand(() =>
            {
                Groups.RemoveAt(SelectedGroupIndex);
            });


            //STUDENTS______________________________________
            
            StudentName = "Student Naam";
            StudentNumber = "Student Nummer";


            AddStudent = new RelayCommand(() =>
            {
                Groups[SelectedGroupIndex].Students.Add(new Student(int.Parse(StudentNumber), StudentName));
            });

            RemoveStudent = new RelayCommand(() =>
            {
                
                
            });
        }

        private void OnSelectionChanged(object sender, int index)
        {
            this.SelectedGroupIndex = index;
        }
    }
}
