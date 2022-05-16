using System.Windows;
using ViewModel;


namespace View
{
    /// <summary>
    /// Interaction logic for GroupSelection.xaml
    /// </summary>
    public partial class GroupSelection : Window
    {
        public GroupSelection()
        {
            this.InitializeComponent();
            this.DataContext = new GroupSelectionViewModel();

            this._viewModel = new GroupSelectionViewModel();

            this.GroupListBox.ItemsSource = this._viewModel.Groups;
            this.StudentListBox.ItemsSource = this._viewModel.Students;
        }

        private void StartAssessment(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            var AssessmentWindow = new Window();
            AssessmentWindow.Show();
        }
    }
}
