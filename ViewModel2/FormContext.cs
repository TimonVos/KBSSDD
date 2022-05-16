using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;
using Model;

namespace ViewModel
{
    public class FormContext : INotifyPropertyChanged
    {
        #region RatingSelected

        public ICommand RatingCommand { get; set; }

        #endregion
        #region FormCreation
        /// <summary>
        /// Form object required to remember data filled in menus
        /// </summary>
        private Form _form;
        /// <summary>
        /// Constructor, uses CreateForm to setup the Form object
        /// </summary>
        public FormContext()
        {
            CreateForm();
            RatingCommand = new RelayCommand<String>((String? criterium) =>
            {

            });

        }
        /// <summary>
        /// Initializes Form object, currently uses standardFormFiller
        /// Form will later be filled by the Formtype from the database
        /// </summary>
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
            CriteriumList = new ObservableCollection<Criterium>();
        }

        #endregion

        #region Collections
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
        private static ObservableCollection<Criterium>? _criteriumList;
        public ObservableCollection<Criterium>? CriteriumList
        {
            get => _criteriumList;
            set
            {
                _criteriumList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_criteriumList)));
            }
        }
        /// <summary>
        /// Clears previous list of Criteria and replaces it with the selected Competence's Criterium list.
        /// </summary>
        /// <param name="comp"> Competence that is currently being selected in Competence list</param>
        public static void selectCompetence(Competence comp)
        {
            if (_criteriumList.Count > 0)
            {
                _criteriumList.Clear();
            }
            foreach (Criterium c in comp.Criteriums)
            {
                _criteriumList.Add(c);
            }
        }

        /// <summary>
        /// List of available ratings for each criteria
        /// </summary>
        private static ObservableCollection<Rating>? _ratingsList;

        public ObservableCollection<Rating>? RatingsList
        {
            get => _ratingsList;
            set
            {
                _ratingsList = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_ratingsList)));
            }
        }
        #endregion

        #region ToolTip

        private string _toolTip;

        public string ToolTip
        {
            get => _toolTip;
            set
            {
                _toolTip = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(_toolTip)));
            }
        }

        #endregion
        public event PropertyChangedEventHandler? PropertyChanged;

    }
}
