using Model;
using System.Collections.Generic;
using System.Linq;

namespace ViewModel
{
    internal class AssessmentFactory
    {
        private AssessmentContext assessmentContext;

        public AssessmentFactory()
        {
            assessmentContext = new AssessmentContext();
        }

        public CompetenceViewModel CreateCompetence(Competence competence)
        {
            var competenceViewModel = new CompetenceViewModel() { Model = competence };

            competenceViewModel.Criteria = CreateCriteria(competenceViewModel);

            return competenceViewModel;
        }

        public CriterionViewModel CreateCriterion(Criterion criterion, CompetenceViewModel competenceViewModel)
        {
            return new CriterionViewModel() { Model = criterion, Competence = competenceViewModel };
        }

        public CriterionViewModel CreateCriterion(Indicator criterion)
        {
            return new CriterionViewModel();
        }

        public IEnumerable<CompetenceViewModel> CreateCompetences()
        {
            return assessmentContext.Competences.Select(CreateCompetence);
        }

        public IEnumerable<CriterionViewModel>? CreateCriteria(CompetenceViewModel competenceViewModel)
        {
            if (competenceViewModel.Model is not null)
                return assessmentContext
                    .GetCriteria(competenceViewModel.Model)
                    .Select(criterion => CreateCriterion(criterion, competenceViewModel));

            return null;
        }
    }
}
