using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel.GroupAdmin
{
    public class StudentViewModel
    {
        public string Title { get => StudentModel.Name; }
        public Student StudentModel { get; set; }
    }
}
