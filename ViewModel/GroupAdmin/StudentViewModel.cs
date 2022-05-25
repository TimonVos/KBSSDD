using Model;

namespace ViewModel.GroupAdmin
{
    public class StudentViewModel
    {
        public string Title { get => StudentModel.Name; }
        public Student StudentModel { get; set; }
    }
}
