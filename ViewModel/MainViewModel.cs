using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Microsoft.Toolkit.Mvvm.Input;
using Model;

namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public IEnumerable<CompetenceViewModel>? Competences
        {
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
        public IEnumerable<CriterionViewModel>? Criteria
        {
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

        public ICommand IndicatorRadioButton_CheckedCommand { get; set; }
        public ICommand IndicatorRadioButton_LoadedCommand { get; set; }


        private IEnumerable<CompetenceViewModel>? _competences;
        private CompetenceViewModel? _activeCompetence;
        private IEnumerable<CriterionViewModel>? _criteria;
        private CriterionViewModel? _activeCriterion;

        private AssessmentFactory factory;

        public ISubject DummySubject { get; set; } = new Student(123, "John");

        public MainViewModel()
        {
            factory = new AssessmentFactory();

            Competences = factory.CreateCompetences();

            IndicatorRadioButton_CheckedCommand = new RelayCommand<IndicatorViewModel>(IndicatorRadioButton_CheckedCommandHandler);
            IndicatorRadioButton_LoadedCommand = new RelayCommand<IndicatorViewModel>(IndicatorRadioButton_LoadedCommandHandler);
        }

        private void IndicatorRadioButton_CheckedCommandHandler(IndicatorViewModel? indicator)
        {
            var context = factory.Context;

            var rating = context.Ratings.FirstOrDefault(rating =>
                rating.Subject == DummySubject &&
                rating.Criterion == indicator?.Criterion?.Model
            );

            if (rating is not null && indicator?.Model is not null)
            {
                rating.Indicator = indicator.Model;
            }
            else
            {
                context.Ratings.Add(
                    new Rating(
                        DummySubject,
                        indicator?.Criterion?.Model ?? new Criterion(),
                        indicator?.Model ?? new Indicator()
                    ));
            }
        }

        private void IndicatorRadioButton_LoadedCommandHandler(IndicatorViewModel? indicator)
        {
            var context = factory.Context;

            var rating = context.Ratings.FirstOrDefault(rating =>
                rating.Subject == DummySubject &&
                rating.Criterion == indicator?.Criterion?.Model
            );

            if (rating is not null && indicator?.Model is not null)
                if (rating.Indicator == indicator.Model)
                    indicator.IsCheckd = true;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
