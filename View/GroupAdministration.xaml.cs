using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
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
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for GroupAdministration.xaml
    /// </summary>
    public partial class GroupAdministration : Window
    {
        public GroupAdministration()
        {
            InitializeComponent();
        }


        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            StudentDelete.Visibility= Visibility.Visible;
        }

        
        private void Groups_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GroupDelete.Visibility = Visibility.Visible;
            StudentGrid.Visibility = Visibility.Visible;
        }
    }
}
