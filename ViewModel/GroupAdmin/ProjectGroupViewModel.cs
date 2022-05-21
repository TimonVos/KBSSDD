using Model;

namespace ViewModel.GroupAdmin
{
    public class ProjectGroupViewModel
    {
        public string Title 
        {
            get => $"Groep {GroupModel.GroupNumber}";
        }
        public ProjectGroup GroupModel { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
