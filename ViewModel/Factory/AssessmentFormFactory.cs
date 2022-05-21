using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Documents;
using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;
using ViewModel.GroupAdmin;

namespace ViewModel.FormAssessment
{
    public class AssessmentFormFactory
    {
        public AssessmentContext? Context = new AssessmentContext();
        
        public ProjectGroupViewModel CreateGroup()
        {
            ProjectGroupViewModel temp = new ProjectGroupViewModel();
            temp.GroupModel = group;
            return temp;
        }

        public IEnumerable<ProjectGroupViewModel> CreateGroups()
        {
            List<ProjectGroupViewModel> temp = new List<ProjectGroupViewModel>();
            foreach(Group group in groups)
            {
                temp.Add(CreateGroup(group));
            }
            return temp;
        }

        public StudentViewModel CreateStudent()
        {
            return new StudentViewModel();
        }

        public CompetenceViewModel CreateCompetence(Form form)
        {
            CompetenceViewModel temp = new CompetenceViewModel();
            temp.CompetenceModel = Context.Competences.Where(c => c.FormId == form.FormId).FirstOrDefault();
            return temp;
        }

        public IEnumerable<CompetenceViewModel> CreateCompetences(IEnumerable<Competence> comps)
        {
            List<CompetenceViewModel> temp = new List<CompetenceViewModel>();
            foreach (Competence cmp in comps)
            {
                temp.Add(CreateCompetence(cmp));
            }

            return temp;
        }

        public AssessmentViewModel CreateAssessment(Assessment assess)
        {
            AssessmentViewModel temp = new AssessmentViewModel();
            temp.AssessmentModel = assess;
            return temp;
        }

        public CriterionViewModel CreateCriterion(Criterion crit)
        {
            CriterionViewModel temp = new CriterionViewModel();
            temp.CriterionModel = crit;
            return temp;
        }

        public IEnumerable<CriterionViewModel> CreateCriteria(IEnumerable<Criterion> crits)
        {
            List<CriterionViewModel> temp = new List<CriterionViewModel>();
            foreach (Criterion crit in crits)
            {
                temp.Add(CreateCriterion(crit));
            }

            return temp;
        }

        public RequirementViewModel CreateRequirement(Requirement critassess, Indicator indi)
        {
            RequirementViewModel temp = new RequirementViewModel();
            temp.CriterionAssessmentModel = critassess;
            temp.Indicator = CreateIndicator(indi);
            return temp;
        }


        public IEnumerable<RequirementViewModel> CreateRequirements(
            IEnumerable<Requirement> criterionAssessments)
        {
            List<RequirementViewModel> temp = new List<RequirementViewModel>();
            foreach (Requirement critassess in criterionAssessments)
            {
                temp.Add(CreateRequirement(critassess, critassess.Indicator));
            }
            return temp;
        }

        public RatingViewModel CreateSelectedAssessment(
            Rating selectedAssessment)
        {
            RatingViewModel temp = new RatingViewModel();
            temp.SelectedAssessmentModel = selectedAssessment;
            return temp;
        }

        public IEnumerable<RatingViewModel> CreateSelectedAssessments(
            IEnumerable<Rating> selectedAssessments)
        {
            List<RatingViewModel> temp = new List<RatingViewModel>();
            foreach (Rating selectedAssessment in selectedAssessments)
            {
                temp.Add(CreateSelectedAssessment(selectedAssessment));
            }

            return temp;
        }

        public IndicatorViewModel CreateIndicator(Indicator indi)
        {
            IndicatorViewModel temp = new IndicatorViewModel();
            temp.IndicatorModel = indi;
            return temp;
        }
        public IEnumerable<IndicatorViewModel> CreateIndicators(IEnumerable<Indicator> indicators)
        {
            List<IndicatorViewModel> temp = new List<IndicatorViewModel>();
            foreach (Indicator indi in indicators)
            {
                temp.Add(CreateIndicator(indi));
            }

            return temp;
        }
    }
}
