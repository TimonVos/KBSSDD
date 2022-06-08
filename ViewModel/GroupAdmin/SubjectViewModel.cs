using ViewModel.FormAssessment;

namespace ViewModel.GroupAdmin
{
    public class SubjectViewModel : ViewModelBase
    {
        public string? Title { get; set; }
        public AssessmentViewModel? Assessment { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
