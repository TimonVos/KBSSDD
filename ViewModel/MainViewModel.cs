using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using Model;

namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public IEnumerable<CompetenceViewModel>? Competences {
            get => _competences;
            set
            {
                if (value != _competences)
                {
                    _competences = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Competences)));
                }
            }
        }
        public CompetenceViewModel? ActiveCompetence
        {
            get => _activeCompetence;
            set
            {
                if (value != _activeCompetence)
                {
                    _activeCompetence = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ActiveCompetence)));

                    if (value is not null)
                        Criteria = factory.CreateCriteria(value);
                }
            }
        }
        public IEnumerable<CriterionViewModel>? Criteria {
            get => _criteria;
            set
            {
                if (value != _criteria)
                {
                    _criteria = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Criteria)));
                }
            }
        }
        public CriterionViewModel? ActiveCriterion
        {
            get => _activeCriterion;
            set
            {
                if (value != _activeCriterion)
                {
                    _activeCriterion = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ActiveCriterion)));
                }
            }
        }
        public IEnumerable<IndicatorViewModel>? Indicators {
            get => _indicators;
            set
            {
                if (value != _indicators)
                {
                    _indicators = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Indicators)));
                }
            }
        }

        private IEnumerable<CompetenceViewModel>? _competences;
        private CompetenceViewModel? _activeCompetence;
        private IEnumerable<CriterionViewModel>? _criteria;
        private CriterionViewModel? _activeCriterion;
        private IEnumerable<IndicatorViewModel>? _indicators;

        private AssessmentFactory factory;

        public MainViewModel()
        {
            factory = new AssessmentFactory();

            Competences = factory.CreateCompetences();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
