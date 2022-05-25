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
        }

        private void StartAssessment(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteSelectedStudent(object sender, RoutedEventArgs e)
        {

        }

        private void GroupSelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (this.DataContext is GroupSelectionViewModel VM)
            {
                //VM.SelectedGroupChanged.invoke(this, this.GroupListBox.SelectedIndex);
            }
            // this.DataContext.Sele
            // hoe ga ik het zo binden dat ik mijn event hier goed kan invoken? 
            // ik heb gegeken ernaar om het in de GroupSelection.g.i.cs aan te passen om zo het smooth te koppelen
        }
    }
}
