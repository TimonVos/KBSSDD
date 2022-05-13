using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Model;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for AssessmentForm.xaml
    /// </summary>
    public partial class AssessmentForm : Window
    {
        public AssessmentForm()
        {
            InitializeComponent();
        }


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedCompetence.Content = CompetenceSelection.SelectedItem.ToString();
            MainFormGrid.Visibility = Visibility.Visible;
            FormContext.selectCompetence((Competence)CompetenceSelection.SelectedItem);
        }

        private void GroupAdmin_Click(object sender, RoutedEventArgs e)
        {
            GroupAdministration newWindow = new GroupAdministration((FormContext)this.DataContext);
            newWindow.ShowDialog();
        }
    }
}
