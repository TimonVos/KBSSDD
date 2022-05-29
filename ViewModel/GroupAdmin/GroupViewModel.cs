using System.Collections.Generic;
using System.Linq;
using Model;
using ViewModel.FormAssessment;

namespace ViewModel.GroupAdmin
{
    public class GroupViewModel : SubjectViewModel
    {
        public string Title { get => GroupModel.Name; }
        public Group GroupModel { get; set; }
        private AssessmentViewModel _selectedAssessment;

        public AssessmentViewModel SelectedAssessment
        {
            get => _selectedAssessment;
            set
            {
                _selectedAssessment = value;
                OnPropertyChanged(nameof(SelectedAssessment));
            }
        }
        public IEnumerable<AssessmentViewModel> Assessments { get; set; }
        public IEnumerable<StudentViewModel> Students { get; set; }

        public GroupViewModel(Group grpMdl)
        {
            GroupModel = grpMdl;
            Students = Factory.CreateStudents(GroupModel.Students);
            Assessments = Factory.CreateAssessments(GroupModel.Assessments);
            _selectedAssessment = Assessments.FirstOrDefault();
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
