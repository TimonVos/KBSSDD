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
using ViewModel.StartAssessment;

namespace View.StartAssessment
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class StartingScreen : Window
    {
        public StartingScreen()
        {
            InitializeComponent();
            this.DataContext = new StartingScreenViewModel();
           
            this.FormListBox.ItemsSource = this.DataContext.Forms;
        }
    }
}
