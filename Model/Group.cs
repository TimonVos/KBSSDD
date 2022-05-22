using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
