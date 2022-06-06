using Model;

namespace ViewModel.GroupAdmin
{
    public class StudentViewModel : SubjectViewModel
    {
        public string Title { get => $"S{StudentModel.StudentNumber} - {StudentModel.Name}"; }
        public Student StudentModel { get; set; }
        public override string ToString()
        {
            return Title;
        }
    }
}
