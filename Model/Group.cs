using System.Collections.ObjectModel;

namespace Model
{
    public class Group
    {
        public string Name { get; set; }
        public ObservableCollection<Student> Students;


        public Group() // default constructor
        {
            Students = new ObservableCollection<Student>();
        }

        public Group(string name)
        {
            this.Name = name;
            Students = new ObservableCollection<Student>();
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
