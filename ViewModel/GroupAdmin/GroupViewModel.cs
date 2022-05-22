using System.Collections.Generic;
using Model;

namespace ViewModel.GroupAdmin
{
    public class GroupViewModel : ViewModelBase
    {
        public string Title { get => GroupModel.Name; }
        public Group GroupModel { get; set; }
        public IEnumerable<StudentViewModel> Students { get; set; }

        public GroupViewModel()
        {
            Students = Factory.CreateStudents(GroupModel.Students);
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
