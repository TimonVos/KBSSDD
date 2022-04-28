using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WPF;

namespace Model
{
    public class FormContext : INotifyPropertyChanged
    {
        public FormContext()
        {
            CreateForm();
        }
        private ObservableCollection<string> ?_competenceList;
        public ObservableCollection<string> ?CompetenceList
        {
            get => _competenceList;

            set
            {
                _competenceList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_competenceList)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void CreateForm()
        {
            Form tempForm = new Form();
            tempForm.StandardFormFiller();
            List<string> newList = new List<string>();
            List<Competence> newList2 = tempForm.Competences.Keys.ToList();
            foreach (Competence competence in newList2)
            {
                newList.Add(competence.Name);
            }
            CompetenceList = new ObservableCollection<string>(newList);
        }
    }
}
