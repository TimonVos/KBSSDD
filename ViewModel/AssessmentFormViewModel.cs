using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace ViewModel
{
    internal class AssessmentFormViewModel : INotifyPropertyChanged
    {
        public AssessmentFormViewModel()
        {
            CreateForm();
        }
        private FormViewModel? FormViewModel { get; set; }
        private GroupViewModel? GroupViewModel { get; set; }
        private Form _form;
        private void CreateForm()
        {
            _form = new Form();
            _form.StandardFormFiller();
            List<string> tempList = new List<string>();
            foreach (Competence comp in _form.Competences.Keys)
            {
                tempList.Add(comp.Name);
            }

            CompetenceList = new ObservableCollection<Competence>(_form.Competences.Keys);
            CriteriumList = new ObservableCollection<Criterion>();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// List of competences that will be rated on current form
        /// </summary>
        private ObservableCollection<Competence>? _competenceList;
        public ObservableCollection<Competence>? CompetenceList
        {
            get => _competenceList;

            set
            {
                _competenceList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_competenceList)));
            }
        }
        /// <summary>
        /// List of criteria that's filled from each competence
        /// Changes after every competence selection
        /// </summary>
        private static ObservableCollection<Criterion>? _criteriumList;
        public ObservableCollection<Criterion>? CriteriumList
        {
            get => _criteriumList;
            set
            {
                _criteriumList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_criteriumList)));
            }
        }
        /// <summary>
        /// List of available ratings for each criteria
        /// </summary>
        private static ObservableCollection<Indicator>? _ratingsList;

        public ObservableCollection<Indicator>? RatingsList
        {
            get => _ratingsList;
            set
            {
                _ratingsList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_ratingsList)));
            }
        }
    }
}
