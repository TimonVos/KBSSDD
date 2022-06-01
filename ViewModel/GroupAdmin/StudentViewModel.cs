using System.Collections.Generic;
using System.Linq;
using Model;
using ViewModel.FormAssessment;

namespace ViewModel.GroupAdmin
{
    public class StudentViewModel : SubjectViewModel
    {
        public new string Title { get => "S" + StudentModel?.StudentNumber; }
        public Student? StudentModel { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
