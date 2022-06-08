using System.Windows;
using System.Windows.Controls;
using View.FormAssessment;
using ViewModel;
using ViewModel.FormAssessment;
using ViewModel.GroupAdmin;

namespace View.GroupSelection
{
    /// <summary>
    /// Interaction logic for GroupSelectionScreen.xaml
    /// </summary>
    public partial class GroupSelectionScreen : Window
    {
        public GroupSelectionScreen()
        {
            this.InitializeComponent();

        }

        private void StartAssessment(object sender, RoutedEventArgs e)
        {
            var group = (GroupViewModel)((Button)sender).Tag;
            if (!Application.Current.Resources.Contains("AssessmentFormViewModel"))
            {
                Application.Current.Resources.Add("AssessmentFormViewModel", new AssessmentFormViewModel(group));
            } else
            {
                ((AssessmentFormViewModel)Application.Current.Resources["AssessmentFormViewModel"]).SelectedGroup = group;
            }
            new FormAssessmentWindow().Show();
            Close();
        }

        private void DeleteSelectedStudent(object sender, RoutedEventArgs e)
        {

        }

        private void GroupSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
        }
    }
}
