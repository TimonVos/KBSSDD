using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Form
    {
        #region Properties
        /// <summary>
        /// Dictionary of competences to be rated, each provided with a integer to indicate weight towards final grade.
        /// </summary>
        public Dictionary<Competence, int> ?Competences { get; set; }
        /// <summary>
        /// Small array for the control questions for knock-out criteria of a project.
        /// </summary>
        private string[] ?ControlQuestions { get; set; }
        #endregion

        #region StandardFormFiller
        /// <summary>
        /// Used during sprint 1 to fill in a static form
        /// Fills the Dictionary of the form with the competences from a static non changeable form.
        /// (To be replaced with a function that gets form information from database in later sprints)
        /// </summary>
        public void StandardFormFiller()
        {
            string[] tempString1 =
            {
                "Het portfolio is compleet en voldoet aan de gestelde richtlijnen. ",
                "Het portfolio bevat alle gerealiseerde beroepsproducten.",
                "Het portfolio en alle broncode."
            };
            ControlQuestions = tempString1;
            Competence tempCompetence = new Competence();
            this.Competences = new Dictionary<Competence, int>();
            tempCompetence.Name = "Analyseren";
            string[] criteria =
            {
                "Systematische methoden",
                "Business case beschreven",
                "Productbacklog aangevuld",
                "Sprintbacklog voldoende detail"
            };
            string[] criteriumDescriptions = { 
                "Er zijn geschikte systematische methoden gekozen voor requirements " +
                "analyse en deze zijn op navolgbare wijze uitgevoerd. Met andere woorden, " +
                "hoe is het probleem helder gekregen. Als bewijsmateriaal kun je o.a. denken aan " +
                "interviewverslagen en UML-diagrammen.",

                "De business case (de rechtvaardiging van het project, de probleemstelling, de opdracht) " +
                "is beschreven en afgestemd met de opdrachtgever.",

                "De productbacklog wordt continue aangevuld met items die tijdens de analyse " +
                "(bijvoorbeeld tijdens sprint planning meetings) van het op te lossen ‘probleem’, naar voren komen.",

                "Sprintbacklog items zijn tot in voldoende detail geanalyseerd en systematisch uitgewerkt. " +
                "(Voldoende detail = Gemaakte keuzes worden door alle belanghebbenden begrepen). " +
                "Hulpmiddelen daarbij zijn o.a.: Userstories incl. scherm/interactie/navigatie-ontwerp, Domeinmodel, Usecase/Userstory diagram."

            };
            string[] ratingDescriptions =
            {
                "Bereidt gesprekken niet voor. Koppelt niet terug aan betrokkenen. " +
                "Maakt geen gebruik van UML of vergelijkbare diagrammen. Verdiept zich niet in het domein. " +
                "Houdt geen rekening met niet-functionele eisen. ",

                "Bereidt gesprekken enigszins voor en koppelt in enige mate terug aan betrokkenen. " +
                "Maakt gebruik van hooguit één soort diagram (bijv. domeinmodel of use case diagram). " +
                "Verdiept zich enigszins in het domein, bijvoorbeeld door het bestuderen van vergelijkbare systemen. " +
                "Houdt impliciet rekening met niet-functionele eisen.",

                "Bereidt gesprekken goed voor en koppelt de resultaten terug aan betrokkenen. " +
                "Maakt gebruik van verschillende UML diagrammen om het probleem vanuit verschillende gezichtspunten te benaderen. " +
                "Kiest de juiste diagrammen voor de context. Verdiept zich uitgebreid in het domein en gebruikt daarvoor verschillende " +
                "bronnen. Houdt expliciet rekening met niet-functionele eisen.",



                "De student voert de opdracht uit, echter zonder na te denken over de achterliggende probleemstelling. ",
                "De student is zich bewust van het onderliggende probleem voor de opdracht en legt dit vast. ",
                "De student werkt de business case uit en toont aan dat de gekozen oplossing daarmee in overeenstemming is. " +
                "De student heeft alternatieven in overweging genomen en besproken met de opdrachtgever ",



                "Het team is niet actief bezig met de product backlog.",

                "Tijdens de sprint planning meetings, worden er veelvuldig nieuwe items vastgelegd.",

                "Tijdens de sprint planning meetings, worden er veelvuldig nieuwe items vastgelegd. " +
                "De items worden tijdens en/of na de sprint planning meeting met de product owner besproken en " +
                "afhankelijk van de prioriteit ",



                "Sprintbacklog items worden kort besproken tijdens een sprint planning meeting en op basis daarvan wordt een " +
                "inschatting gemaakt voor de benodigde inspanning. " +
                "Als een docent er naar vraagt, blijkt echter dat een ieder zijn eigen interpretatie geeft aan een item.",

                "Sprintbacklog items worden  besproken tijdens een sprint planning. Diepgang ontbreekt echter nog.",



                "Zowel product owner als teamleden weten voor ieder item nauwkeurig wat er gerealiseerd gaat worden. " +
                "Onafhankelijk van elkaar zouden ze tot een vergelijkbare uitwerking komen. " +
                "Tijdens de sprint planning meeting is er uitgebreid gebruik gemaakt van bijvoorbeeld het white board, " +
                "om zaken duidelijk te maken, en alternatieven te bespreken. " +
                "Het kan ook zijn dat items al eerder tot in voldoende detail zijn uitgewerkt, " +
                "zodat deze minder aandacht behoeven tijdens de meeting. "
            };
            int i = 0;
            tempCompetence.Criteriums = new List<Criterion>();
            foreach (string criteriumDescription in criteriumDescriptions)
            {
                int k = i;
                Criterion tempCriterium = new Criterion();
                tempCriterium.RatingsDictionary = new Dictionary<Indicator, string>();
                if (i > 0)
                {
                    k = k / 3;
                }
                tempCriterium.Name = criteria[k];
                tempCriterium.Description = criteriumDescription;
                for (int j = 0; j < 3; j++)
                {
                    string header = "";
                    switch (j)
                    {
                        case 0:
                            header = "Ontwikkelpunt";
                            break;
                        case 1:
                            header = "Competent";
                            break;
                        case 2:
                            header = "Voorbeeldig";
                            break;
                    }
                    Indicator tempRating = new Indicator();
                    tempRating.Description = ratingDescriptions[i + j];
                    tempCriterium.RatingsDictionary.Add(tempRating, header);
                }
                tempCompetence.Criteriums.Add(tempCriterium);
                i += 3;
            }
            this.Competences.Add(tempCompetence, 10);
            Competence tempCompetence2 = new Competence();
            tempCompetence2.Name = "Manage & Control";
            tempCompetence2.Criteriums = new List<Criterion>();
            criteria[0] = "test1";
            ratingDescriptions[0] = "test3";
            criteriumDescriptions[0] = "test2";
            i = 0;
            foreach (string criteriumDescription in criteriumDescriptions)
            {
                int k = i;
                Criterion tempCriterium = new Criterion();
                tempCriterium.RatingsDictionary = new Dictionary<Indicator, string>();
                if (i > 0)
                {
                    k = k / 3;
                }
                tempCriterium.Name = criteria[k];
                tempCriterium.Description = criteriumDescription;
                for (int j = 0; j < 3; j++)
                {
                    string header = "";
                    switch (j)
                    {
                        case 0:
                            header = "Ontwikkelpunt";
                            break;
                        case 1:
                            header = "Competent";
                            break;
                        case 2:
                            header = "Voorbeeldig";
                            break;
                    }
                    Indicator tempRating = new Indicator();
                    tempRating.Description = ratingDescriptions[i + j];
                    tempCriterium.RatingsDictionary.Add(tempRating, header);
                }
                tempCompetence2.Criteriums.Add(tempCriterium);
                i += 3;
            }
            this.Competences.Add(tempCompetence2, 10);
        }
        #endregion
    }
}
