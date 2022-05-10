using Model;
using System.Collections.Generic;
using System.Linq;

namespace ViewModel
{
    internal class AssessmentFactory
    {
        public AssessmentContext Context { get; set; }

        public AssessmentFactory()
        {
            Context = new AssessmentContext();
        }

        public CompetenceViewModel CreateCompetence(Competence competence)
        {
            var competenceViewModel = new CompetenceViewModel() { Model = competence };

            competenceViewModel.Criteria = CreateCriteria(competenceViewModel);

            return competenceViewModel;
        }

        public CriterionViewModel CreateCriterion(Criterion criterion, CompetenceViewModel competenceViewModel)
        {
            var critrionViewModel = new CriterionViewModel() { Model = criterion, Competence = competenceViewModel };

            critrionViewModel.Indicators = CreateIndicators(critrionViewModel);

            return critrionViewModel;
        }

        public CriterionViewModel CreateCriterion(Indicator criterion)
        {
            return new CriterionViewModel();
        }

        public IndicatorViewModel CreateIndicator(Indicator indicator, CriterionViewModel criterion)
        {
            return new IndicatorViewModel() { Model = indicator, Criterion = criterion };
        }

        public IEnumerable<CompetenceViewModel> CreateCompetences()
        {
            return Context.Competences.Select(CreateCompetence);
        }

        public IEnumerable<CriterionViewModel>? CreateCriteria(CompetenceViewModel competenceViewModel)
        {
            if (competenceViewModel.Model is not null)
                return Context
                    .GetCriteria(competenceViewModel.Model)
                    .Select(criterion => CreateCriterion(criterion, competenceViewModel));

            return null;
        }

        public IEnumerable<IndicatorViewModel> CreateIndicators(CriterionViewModel criterion)
        {
            return Context.Indicators.Select(indicator => CreateIndicator(indicator, criterion));
        }
    }
}
