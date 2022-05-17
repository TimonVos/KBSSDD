﻿using System.Windows;
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
            this.Visibility = Visibility.Hidden;
            var AssessmentWindow = new Window();
            AssessmentWindow.Show();
        }

        private void DeleteSelectedStudent(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
