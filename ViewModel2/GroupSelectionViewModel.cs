using System.Collections;
using System.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace ViewModel
{
    public class GroupSelectionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;


        public RelayCommand AddGroup { get; set; }
        public RelayCommand RemoveGroup { get; set; }
        public RelayCommand AddStudent { get; set; }
        public RelayCommand RemoveStudent { get; set; }

        public string GroupTextBox { get; set; }



        //listbox contents________________
        public ArrayList Groups { get; set; }
        public ArrayList Students { get; set; }

        public GroupSelectionViewModel()
        {
            GroupTextBox = "Group";
            AddStudent = new RelayCommand(() =>
            {

            });


            // dummy data for the listboxes
            Groups = new ArrayList()
            {
                "ur mom",
                "ur dad"
            };

            Students = new ArrayList()
            {
                "S1158062 (Timon Vos)",
                "S1155295 (Dilano Bartijn)"
            };
        }




    }
}
