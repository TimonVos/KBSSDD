﻿using System.Windows;
using Model;
using ViewModel.FormAssessment;

namespace View.FormAssessment
{
    /// <summary>
    /// Interaction logic for FormAssessmentWindow.xaml
    /// </summary>
    public partial class FormAssessmentWindow : Window
    {
        public FormAssessmentWindow() : base()
        {
            InitializeComponent();
        }

        private void ManageStudentsButton_Click(object sender, RoutedEventArgs e)
        {
            new GroupSelection.GroupSelection().Show();
            Close();
        }
    }
}
