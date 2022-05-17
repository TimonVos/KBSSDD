using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Model;

namespace Service.Database
{
    public class AssessmentContext
    {
        public List<ProjectGroup> Groups { get; set; }
        public Project Project { get; set; }
        public Form Form { get; set; }
        public List<ControlQuestion> ControlQuestions { get; set; }
        public List<Competence> Competences { get; set; }
        public List<AppearsFrom> AppearsFrom { get; set; }
        public List<Criterion> Criteria { get; set; }
        public List<CriterionAssessment> CriterionAssessments { get; set; }

        public List<Indicator> Indicators { get; set; }


        public AssessmentContext()
        {
            standardForm();
        }
        /// <summary>
        /// function to fill form without database integration
        /// </summary>
        private void standardForm()
        {
            Groups = new List<ProjectGroup>();
            Project = new Project("OOSDDH", "OOSDDH2", 0, Groups);
            ProjectGroup group1 = new ProjectGroup(0, 1, Project);
            ProjectGroup group2 = new ProjectGroup(1, 2, Project);
            ProjectGroup group3 = new ProjectGroup(2, 3, Project);
            Groups.Add(group1);
            Groups.Add(group2);
            Groups.Add(group3);

            ControlQuestions = new List<ControlQuestion>();
            ControlQuestion ctq1 = new ControlQuestion(0, Form, "Het portfolio is compleet en voldoet aan de gestelde richtlijnen.");
            ControlQuestion ctq2 =
                new ControlQuestion(0, Form, "Het portfolio bevat alle gerealiseerde beroepsproducten.");
            ControlQuestions.Add(ctq1);
            ControlQuestions.Add(ctq2);

            Competences = new List<Competence>();
            Competence comp1 = new Competence(0, "Analyseren",
                "Geen competentie beschrijving", 20, 0, AppearsFrom, Criteria);
            Competence comp2 = new Competence(1, "Adviseren", "Geen competentie beschrijving", 80, 0, AppearsFrom,
                Criteria);
            Competences.Add(comp1);
            Competences.Add(comp2);

            Form = new Form(0, ControlQuestions, Competences);

            AppearsFrom = new List<AppearsFrom>();
            AppearsFrom apf1 = new AppearsFrom(0, "Product Backlog");
            AppearsFrom apf2 = new AppearsFrom(1, "Sprint Backlog");
            AppearsFrom.Add(apf1);
            AppearsFrom.Add(apf2);

            Indicators = new List<Indicator>();
            Indicator indi1 = new Indicator(0, "Ontwikkelpunt", CriterionAssessments);
            Indicator indi2 = new Indicator(1, "Competent", CriterionAssessments);
            Indicator indi3 = new Indicator(2, "Voorbeeldig", CriterionAssessments);
            Indicators.Add(indi1);
            Indicators.Add(indi2);
            Indicators.Add(indi3);

            Criteria = new List<Criterion>();
            Criterion crit1 = new Criterion(0, "Systematische methoden", "Er zijn geschikte systematische methoden gekozen voor requirements analyse en deze zijn op navolgbare wijze uitgevoerd. Met andere woorden, hoe is het probleem helder gekregen. Als bewijsmateriaal kun je o.a. denken aan interviewverslagen en UML-diagrammen.",
                0, comp1, CriterionAssessments);
            Criteria.Add(crit1);

            CriterionAssessments = new List<CriterionAssessment>();
            string temp = "Bereidt gesprekken niet voor. Koppelt niet terug aan betrokkenen. Maakt geen gebruik van UML of vergelijkbare diagrammen. Verdiept zich niet in het domein. Houdt geen rekening met niet - functionele eisen.";
            CriterionAssessment critassess1 = new CriterionAssessment(0, temp, 0, indi1, 0, crit1);
            CriterionAssessments.Add(critassess1);
            temp =
                "Bereidt gesprekken enigszins voor en koppelt in enige mate terug aan betrokkenen. Maakt gebruik van hooguit één soort diagram (bijv. domeinmodel of use case diagram). Verdiept zich enigszins in het domein, bijvoorbeeld door het bestuderen van vergelijkbare systemen. Houdt impliciet rekening met niet-functionele eisen.";
            CriterionAssessment critassess2 = new CriterionAssessment(1, temp, 1, indi1, 0, crit1);
            CriterionAssessments.Add(critassess2);
            temp = "Bereidt gesprekken goed voor en koppelt de resultaten terug aan betrokkenen.Maakt gebruik van verschillende UML diagrammen om het probleem vanuit verschillende gezichtspunten te benaderen. Kiest de juiste diagrammen voor de context.Verdiept zich uitgebreid in het domein en gebruikt daarvoor verschillende bronnen.Houdt expliciet rekening met niet - functionele eisen.";
            CriterionAssessment critassess3 = new CriterionAssessment(2, temp, 2, indi1, 0, crit1);
            foreach (Competence comp in Competences)
            {
                comp.Criteria = Criteria;
                foreach (Criterion crit in comp.Criteria)
                {
                    crit.CriterionAssessments = new List<CriterionAssessment>();
                    crit.CriterionAssessments.Add(critassess1);
                    crit.CriterionAssessments.Add(critassess2);
                    crit.CriterionAssessments.Add(critassess3);
                }
            }
        }
    }
}
