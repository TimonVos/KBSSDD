using System.Windows;
using System.Windows.Controls;
using Model;
using View.FormAssessment;
using ViewModel;
using ViewModel.FormAssessment;
using ViewModel.GroupAdmin;

namespace View.GroupSelection
{
    /// <summary>
    /// Interaction logic for GroupSelection.xaml
    /// </summary>
    public partial class GroupSelection : Window
    {
        public GroupSelection()
        {
            this.InitializeComponent();

        }

        private void StartAssessment(object sender, RoutedEventArgs e)
        {
            var group = (GroupViewModel)((Button)sender).Tag;
            Application.Current.Resources.Add("AssessmentFormViewModel", new AssessmentFormViewModel(group));
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
