using Model;

namespace ViewModel.GroupAdmin
{
    public class ProjectGroupViewModel
    {
        public string Title 
        {
            get => $"Groep {GroupModel.Number}";
        }
        public Group GroupModel { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
