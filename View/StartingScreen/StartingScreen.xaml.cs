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
using View.FormAssessment;
using ViewModel;
using ViewModel.FormAssessment;
using ViewModel.StartingScreen;

namespace View.StartingScreen
{
    /// <summary>
    /// Interaction logic for StartingScreen.xaml
    /// </summary>
    public partial class StartingScreen : Window
    {
        public StartingScreen()
        {
            InitializeComponent();

            this.DataContext = new StartingScreenViewModel();
        }


        /*
        public string ProjectName;
        public string ProjectCode;
        public bool IsChecked { get; set; }
        */

        private void ProjectAdd_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void NextScreen_Click(object sender, RoutedEventArgs e)
        {
            var project = (Project)((Button)sender).Tag;
            Application.Current.Resources.Add("GroupSelectionViewModel", new GroupSelectionViewModel(project));
            new GroupSelection.GroupSelectionScreen().Show();
            Close();
        }
    }
}
