using System.Windows;
using System.Windows.Controls;
using Model;
using ViewModel;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedCompetence.Content = CompetenceSelection.SelectedItem.ToString();
            MainFormGrid.Visibility = Visibility.Visible;
            FormContext.selectCompetence((Competence)CompetenceSelection.SelectedItem);

        }
    }
}
