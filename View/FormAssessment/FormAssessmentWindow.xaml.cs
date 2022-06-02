using System.Windows;
using Model;
using ViewModel.FormAssessment;

namespace View.FormAssessment
{
    /// <summary>
    /// Interaction logic for FormAssessmentWindow.xaml
    /// </summary>
    public partial class FormAssessmentWindow : Window
    {
        public FormAssessmentWindow(Project project) : base()
        {
            Resources.Add("ViewModel", new AssessmentFormViewModel(project));
            InitializeComponent();
        }
    }
}
