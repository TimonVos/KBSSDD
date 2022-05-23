using Model;


namespace ViewModel.StartingScreen
{
    public class StartingScreenViewModel : ViewModelBase
    {
        public string Title
        {
            get => ProjectListModel.ProjectName;
        }
        public int Number
        {
            get => ProjectListModel.ProjectId;
        }


        public Project ProjectListModel { get; set; }

    }
}


