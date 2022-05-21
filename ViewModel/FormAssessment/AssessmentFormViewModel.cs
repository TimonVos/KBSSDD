using System.Collections.Generic;
using System.Linq;
using Bogus;
using Model;
using ViewModel.GroupAdmin;

namespace ViewModel.FormAssessment
{
    public class AssessmentFormViewModel : ViewModelBase
    {
        public Form FormModel { get; set; }
        public Assessment AssessmentModel { get; set; }
        private List<Group> _groups;
        public IEnumerable<CompetenceViewModel> Competences { get; set; }
        public AssessmentFormViewModel()
        {
            if (Factory.Context.Projects.Count() < 1)
            {
                newForm();
            }
        }
        /// <summary>
        /// function to create form used before merge with project selection
        /// </summary>
        private void newForm()
        {
            using var context = Factory.Context;

            Project proj = new Project();
            proj.Name = "KBS Software Design en Development";
            proj.Code = "ICT.SE.OSD.PRJCT.V21";

            Form form = new Form();
            form.Name = "Assessment (bedrijfs)opdracht Kenmerkende BeroepsSituatie";

            context.Add(proj);
            context.Add(form);
            context.SaveChanges();

            proj.Form = form;
            context.Projects.Update(proj);
            context.SaveChanges();

            List<Indicator> indis = new List<Indicator>
            {
                new Indicator { Forms = new List<Form> { form }, Name = "Ontwikkelpunt", Value = 3 },
                new Indicator { Forms = new List<Form> { form }, Name = "Competent", Value = 7 },
                new Indicator { Forms = new List<Form> { form }, Name = "Voorbeeldig", Value = 9 },
            };
            context.Add(indis);
            form.Indicators = indis;
            context.Forms.Update(form);
            context.SaveChanges();

            List<Competence> competences = new List<Competence>
            {
                new Competence
                {
                    Evidence = "Product Backlog \n Sprint Backlog \n " +
                               "Beschreven Business Case (eventueel als inleiding bij het functioneel ontwerp) \n " +
                               "Ander bewijsmateriaal zoals: interviewverslagen, schetsen van UML - diagrammen, foto’s van schetsen op whiteboards \n" +
                               "Portfolio: Reflectie op competentie Analyse &Onderzoek",
                    Form = form,
                    Name = "Analyseren",
                    Weight = 10
                },
                new Competence
                {
                    Evidence = "Sprint review \n Sprint planning \n Product Backlog \n" +
                               "Sprint backlog \n Definition of Done \n" +
                               "Portfolio: Reflectie op competentie Advies en Communicatie",
                    Form = form,
                    Name = "Adviseren",
                    Weight = 10
                }
            };
            context.Add(competences);
            form.Competences = competences;
            context.Forms.Update(form);


        }

    }
}
