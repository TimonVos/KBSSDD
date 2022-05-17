using System;
using System.Collections.Generic;
using System.Windows.Documents;
using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;
using ViewModel.GroupAdmin;

namespace ViewModel.FormAssessment
{
    public class AssessmentFormFactory
    {
        public AssessmentContext? AssessmentContext = new AssessmentContext();

        public FormAssessmentViewModel CreateForm()
        {
            return new FormAssessmentViewModel();
        }

        public ProjectGroupViewModel CreateGroup(ProjectGroup group)
        {
            ProjectGroupViewModel temp = new ProjectGroupViewModel();
            temp.GroupModel = group;
            return temp;
        }

        public IEnumerable<ProjectGroupViewModel> CreateGroups(IEnumerable<ProjectGroup> groups)
        {
            List<ProjectGroupViewModel> temp = new List<ProjectGroupViewModel>();
            foreach(ProjectGroup group in groups)
            {
                temp.Add(CreateGroup(group));
            }
            return temp;
        }

        public StudentViewModel CreateStudent()
        {
            return new StudentViewModel();
        }

        public CompetenceViewModel CreateCompetence(Competence comp)
        {
            CompetenceViewModel temp = new CompetenceViewModel();
            temp.CompetenceModel = comp;
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
