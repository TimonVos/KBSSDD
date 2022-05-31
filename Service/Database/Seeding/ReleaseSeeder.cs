#if (!DEBUG)
using Microsoft.EntityFrameworkCore;
using Model;

namespace Service.Database.Seeding
{
    /// <summary>
    /// Seed the database with random data.
    /// </summary>
    public class ReleaseSeeder : SeederBase
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="modelBuilder"></param>
        public override void Seed(ModelBuilder modelBuilder)
        {
            var indicators = SeedIndicators(modelBuilder);
            var form = SeedForm(modelBuilder);
            SeedFormIndicators(modelBuilder, form, indicators);
            SeedCompetences(modelBuilder, form);
            SeedCriteria(modelBuilder);
            SeedProjects(modelBuilder, form);
        }

        private static List<Indicator> SeedIndicators(ModelBuilder modelBuilder, int id = 1)
        {
            var indicators = new List<Indicator>()
            {
                new Indicator { IndicatorId = id++, Name = "Ontwikkelpunt", Value = 3 },
                new Indicator { IndicatorId = id++, Name = "Competent", Value = 7 },
                new Indicator { IndicatorId = id++, Name = "Voorbeeldig", Value = 9 },
            };

            modelBuilder.Entity<Indicator>().HasData(indicators);

            return indicators;
        }

        private static Form SeedForm(ModelBuilder modelBuilder, int id = 1)
        {
            var form = new Form
            {
                FormId = id,
                Name = "Software Engineering periode 2",
            };

            modelBuilder.Entity<Form>().HasData(form);

            return form;
        }

        private static void SeedFormIndicators(ModelBuilder modelBuilder, Form form, List<Indicator> indicators)
        {
            foreach (var indicator in indicators)
                modelBuilder.Entity<FormIndicator>().HasData(new FormIndicator
                {
                    FormId = form.FormId,
                    IndicatorId = indicator.IndicatorId
                });
        }

        private static List<Competence> SeedCompetences(ModelBuilder modelBuilder, Form form, int id = 1)
        {
            var competences = new List<Competence>
            {
                new Competence
                {
                    CompetenceId = id++,
                    FormId = form.FormId,
                    Name = "Analyseren",
                    Weight = 0.1d,
                    Evidence =
                        "Product Backlog" + Environment.NewLine +
                        "Sprint Backlog" + Environment.NewLine +
                        "Beschreven Business Case (eventueel als inleiding bij het functioneel ontwerp)" + Environment.NewLine +
                        "Ander bewijsmateriaal zoals: interviewverslagen, schetsen van UML-diagrammen, foto’s van schetsen op whiteboards" + Environment.NewLine +
                        "Portfolio: Reflectie op competentie Analyse & Onderzoek",
                },
                new Competence
                {
                    CompetenceId = id++,
                    FormId = form.FormId,
                    Name = "Adviseren",
                    Weight = 0.1d,
                    Evidence =
                        "Sprint review" + Environment.NewLine +
                        "Sprint planning" + Environment.NewLine +
                        "Product backlog" + Environment.NewLine +
                        "Sprint backlog" + Environment.NewLine +
                        "Definition of Done" + Environment.NewLine +
                        "Portfolio: Reflectie op competentie Advies en Communicatie",
                },
                new Competence
                {
                    CompetenceId = id++,
                    FormId = form.FormId,
                    Name = "Ontwerpen",
                    Weight = 0.2d,
                    Evidence =
                        "Het functioneel ontwerp - Usecase/Userstory diagram, Domeinmodel en evt. andere diagrammen" + Environment.NewLine +
                        "Het technisch ontwerp  – ERD, (UML-)diagrammen" + Environment.NewLine +
                        "Testscenario’s (evt. in het functioneel ontwerp)" + Environment.NewLine +
                        "Portfolio: Reflectie op competentie Ontwerp en Architectuur",
                },
                new Competence
                {
                    CompetenceId = id++,
                    FormId = form.FormId,
                    Name = "Realiseren",
                    Weight = 0.3d,
                    Evidence =
                        "Broncode" + Environment.NewLine +
                        "Testscenario’s (evt. in het functioneel ontwerp)" + Environment.NewLine +
                        "Testprocedure" + Environment.NewLine +
                        "Testrapportages" + Environment.NewLine +
                        "Testprocedure" + Environment.NewLine +
                        "Unit testen" + Environment.NewLine +
                        "Code conventies" + Environment.NewLine +
                        "Installatiehandleiding" + Environment.NewLine +
                        "Portfolio: Reflectie op competentie Realisatie en Testen ",
                },
                new Competence
                {
                    CompetenceId = id++,
                    FormId = form.FormId,
                    Name = "Beheren",
                    Weight = 0.2d,
                    Evidence =
                        "Dagelijkse Scrum" + Environment.NewLine +
                        "Sprint review" + Environment.NewLine +
                        "Retrospective " + Environment.NewLine +
                        "Product backlog" + Environment.NewLine +
                        "Sprint backlog" + Environment.NewLine +
                        "Burn down charts" + Environment.NewLine +
                        "Portfolio: reflective op competentie management en beheer ",
                },
                new Competence
                {
                    CompetenceId = id++,
                    FormId = form.FormId,
                    Name = "Professionele Ontwikkeling",
                    Weight = 0.1d,
                    Evidence =
                        "Retrospective" + Environment.NewLine +
                        "Portfolio: Hoofdstuk 'Professionele ontwikkeling'"
                },
            };

            modelBuilder.Entity<Competence>().HasData(competences);

            return competences;
        }

        private List<Criterion> SeedCriteria(ModelBuilder modelBuilder, int id = 1)
        {
            var criteria = new List<Criterion>
            {
                // Analyseren
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Methodische requirement analyse",
                    CompetenceId = 1,
                    Description = "Alle gerealiseerde sprint backlog items zijn terug te vinden in het functioneel ontwerp. Denk onder andere aan een bijgewerkt domeinmodel  en use case diagram. De uitgewerkte backlog items zijn in het functioneel ontwerp terug te vinden als uitgewerkte user-stories. Waar zinvol is het functioneel ontwerp ondersteunt met activiteitendiagrammen, toestandsdiagrammen en sequentiediagrammen.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Afgestemde BC",
                    CompetenceId = 1,
                    Description = "De business case (de rechtvaardiging van het project, de probleemstelling, de opdracht) is beschreven en afgestemd met de opdrachtgever.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Continu aangevulde PBL",
                    CompetenceId = 1,
                    Description = "De productbacklog wordt continue aangevuld met items die tijdens de analyse (bijvoorbeeld tijdens sprint planning meetings) van het op te lossen ‘probleem’, naar voren komen.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Gedetailleerde BLI",
                    CompetenceId = 1,
                    Description = "Sprintbacklog items zijn tot in voldoende detail geanalyseerd en systematisch uitgewerkt. (Voldoende detail = Gemaakte keuzes worden door alle belanghebbenden begrepen). Hulpmiddelen daarbij zijn o.a.: Userstories incl. scherm/interactie/navigatie-ontwerp, Domeinmodel, Usecase/Userstory diagram.",
                },

                // Adviseren
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Geïnformeerde PO",
                    CompetenceId = 2,
                    Description = "De product owner is gedurende alle sprints tijdig en volledig geinformeerd.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Communicatievormen",
                    CompetenceId = 2,
                    Description = "Er zijn geschikte communicatievormen gekozen en daadwerkelijk toegepast met als doel adviezen te geven.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Correct Nederlands",
                    CompetenceId = 2,
                    Description = "Alle documenten zijn geschreven in correct Nederlands, zijn helder en duidelijk. ",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Meedenken met PO",
                    CompetenceId = 2,
                    Description = "Het scrum team denkt mee met de product owner (denk aan sprint planning). Het scrum team komt bijvoorbeeld met alternatieven voor wensen van de productowner die minder tijd kosten om te implementeren.",
                },

                // Ontwerpen
                new Criterion
                {
                    CriterionId = id++,
                    Name = "BLI in FO",
                    CompetenceId = 3,
                    Description = "Alle gerealiseerde sprint backlog items zijn terug te vinden in het functioneel ontwerp. Denk onder andere aan een bijgewerkt domeinmodel en use case diagram. De uitgewerkte backlog items zijn in het functioneel ontwerp terug te vinden als uitgewerkte user-stories. Waar zinvol is het functioneel ontwerp ondersteunt met activiteitendiagrammen, toestandsdiagrammen en sequentiediagrammen.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Bijwerken van ontwerp",
                    CompetenceId = 3,
                    Description = "Tijdens elke sprint wordt het ontwerp bijgewerkt. Denk bijvoorbeeld aan het toevoegen en/of uitbreiden van klassen in de verschillende klassendiagrammen. Belangrijke technische aspecten worden uitgelegd en ondersteund door (UML-)diagrammen.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Consistent FO en TO",
                    CompetenceId = 3,
                    Description = "Het functioneel ontwerp en het technisch ontwerp zijn volledig consistent met elkaar.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Bijgewerkt ERD",
                    CompetenceId = 3,
                    Description = "Tijdens elke sprint wordt het ERD bijgewerkt (indien van toepassing). Keuzes voor het db-ontwerp (bijv. een extra index) worden toegelicht. De naamgeving van de tabellen en kollomen van de database zijn consistent met de naamgeving zoals gebruikt in het domeinmodel" },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Toegelicht TO",
                    CompetenceId = 3,
                    Description = "De gevolgde architectuur en ontwerpkeuzes zijn in het technisch ontwerp toegelicht en gemotiveerd.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Zelfstandig ontwerp",
                    CompetenceId = 3,
                    Description = "In het ontwerp is alle benodige informatie opgenomen om een nieuw teamlid snel op weg te helpen met het realiseren van de software. Naast de eerder genoemde aspecten kun je daarbij ook denken aan het vermelden van gebruikte tools, frameworks en verwijzingingen naar bruikbaar studiemateriaal.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Testset voor ieder BLI",
                    CompetenceId = 3,
                    Description = "Voor ieder gerealiseerd item is een uitgebreide testset beschreven, waarmee de kwaliteit van de gerealiseerde software aangetoond kan worden.",
                },

                // Realiseren
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Comments",
                    CompetenceId = 4,
                    Description = "Alle broncode is op consistente wijze van commentaar voorzien.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Coding conventions",
                    CompetenceId = 4,
                    Description = "Code coventies zijn beschreven en nageleefd.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Consistentie",
                    CompetenceId = 4,
                    Description = "De code is consistent  met het opgestelde ontwerp.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Testprocedure",
                    CompetenceId = 4,
                    Description = "Er is een testprocedure beschreven waarin o.a. vastligt wie, wat en wanneer test.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Testrapportage",
                    CompetenceId = 4,
                    Description = "De student rapporteert over unit-testen en overige testen.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Unit tests",
                    CompetenceId = 4,
                    Description = "Waar zinvol, zijn unit-testen toegepast.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Self-documenting code",
                    CompetenceId = 4,
                    Description = "Alle namen in de code gebruiken een consistente vocabulair. Namen in de code beschrijven de intentie van de code.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Formatting",
                    CompetenceId = 4,
                    Description = "Formattering geeft een perfect inzicht in de beoogde structuur.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Refactoring",
                    CompetenceId = 4,
                    Description = "De code in methodes is voor de gewenste functionaliteit eenvoudig van opzet.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Scalability",
                    CompetenceId = 4,
                    Description = "De code is modulair opgezet en daardoor makkelijk te onderhouden, te lezen en te unit testen.",
                },

                // Beheren
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Opgenomen items in SR",
                    CompetenceId = 5,
                    Description = "Tijdens elke Sprint Review wordt duidelijk aangegeven welke items in de sprint opgenomen zijn en welke items daarvan wel dan wel niet zijn gerealiseerd. Per gerealiseerd item wordt een demo gegeven.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Besproken BDC in SR",
                    CompetenceId = 5,
                    Description = "Tijdens elke Sprint Review wordt de burn down chart besproken. Wat was de geplande velocity en waar is het team op uitgekomen?",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Daily standup",
                    CompetenceId = 5,
                    Description = "Scrum stand-ups worden dagelijks en getimeboxed (bijv. max 15 minuten) uitgevoerd en zijn navolgbaar (foto’s, reflectie) voor de assessoren.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Tool voor BLI",
                    CompetenceId = 5,
                    Description = "Er is een geschikte tool en systematiek geselecteerd voor het managen van de product backlog items. Dit wordt in het reflectieverslag besproken.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Version control system",
                    CompetenceId = 5,
                    Description = "Er is een geschikte tool en systematiek geselecteerd voor het samenwerken aan en het beheren van de broncode. Dit wordt in het reflectieverslag besproken.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Gedetaileerde BLI",
                    CompetenceId = 5,
                    Description = "Productbacklog items zijn in voldoende detail en consistent beschreven in de product backlog..",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Geprioriteerde BLI",
                    CompetenceId = 5,
                    Description = "Productbacklog items met een hoge prioriteit zijn al duidelijk verder uitgewerkt in vergelijking met items met een lage prioriteit.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Afgestemde PBL en SBL",
                    CompetenceId = 5,
                    Description = "Zowel productbacklog items als sprintbacklog items zijn volledig afgestemd met de productowner.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Bug tracking",
                    CompetenceId = 5,
                    Description = "Bekende bugs worden geadminstreerd (bijvoorbeeld door ze op te nemen in de product backlog) en het oplossen hiervan heeft een plaats gekregen in het software ontwikkelproces",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Retro",
                    CompetenceId = 5,
                    Description = "De retrospective is uitgevoerd en heeft (indien nodig) geleid tot aanpassingen op het proces.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "DoD",
                    CompetenceId = 5,
                    Description = "De Definition of Done is tot in voldoende detail uitgewerkt. (DoD bevat minimaal: Code Conventies, Testscenario’s, Documentatie-eisen, Acceptatiecriteria van de Product Owner)",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Increment",
                    CompetenceId = 5,
                    Description = "Er wordt na elke sprint een ready to release softwareproduct (overeenkomstig definition of done)  increment opgeleverd.",
                },

                // Professionele Ontwikkeling
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Reflectie op verbeteringspunten",
                    CompetenceId = 6,
                    Description = "Er is een gedetailleerde reflectie op de verbeterpunten uit de Retrospective beschreven. (Per student beschreven in ‘Professionele Ontwikkeling’)",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Leerdoelen",
                    CompetenceId = 6,
                    Description = "Bij aanvang zijn realistische vakinhoudelijke en persoonlijke professionele leerdoelen SMART geformuleerd. (Per student beschreven in ‘Professionele Ontwikkeling’). De student is hier actief mee aan de gang gegaan.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Professionele Ontwikkeling",
                    CompetenceId = 6,
                    Description = "Het werken aan professionele ontwikkeling  en de resultaten hiervan zijn aan de hand van concrete voorbeelden geïllustreerd. (Per student beschreven in ‘Professionele Ontwikkeling’)",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Sterktes en zwaktes",
                    CompetenceId = 6,
                    Description = "Er is inzicht in de eigen sterktes en zwaktes. (Per student beschreven in ‘Professionele Ontwikkeling’)",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Reflectie",
                    CompetenceId = 6,
                    Description = "Er is een gedetailleerde reflectie op alle hier genoemde competenties. De reflectie is per groep, waarbij de bijdrage van de individuele student goed naar voren komt.",
                },
            };

            modelBuilder.Entity<Criterion>().HasData(criteria);

            return criteria;
        }

        private List<Project> SeedProjects(ModelBuilder modelBuilder, Form form, int id = 1)
        {
            var projects = new List<Project>
            {
                new Project
                {
                    ProjectId = id++,
                    FormId = form.FormId,
                    Name = "Beoordelingssysteem",
                    Code = "ICT.SE.OSD.PRJCT.V21",
                    Description = "De docenten beoordelen KBS-projecten en stages met behulp van het assessmentformulier. Dit formulier vult de docent in op papier of in Word door de relevante vakken te markeren. Vervolgens moet de docent zelf het cijfer berekenen (afhankelijk van de weging) en daarna moeten de cijfers handmatig ingevuld worden in Educator. Dit vereist veel handelingen en afhankelijkheid van verschillende systemen. De docenten willen dit formulier gedigitaliseerd hebben en willen dat jullie als SCRUM-team nadenken over hoe je hem/haar zoveel mogelijk tijd kunt besparen. Het zou bijvoorbeeld mooi zijn als er één systeem is dat gebruikt wordt, in plaats van meerdere systemen.",
                },
                new Project
                {
                    ProjectId = id++,
                    FormId = form.FormId,
                    Name = "Systeem student begeleider",
                    Code = "ICT.SE.OSD.PRJCT.V21",
                    Description = "Als student begeleider heb je vaak veel studenten die je moet coachen. Soms is het daardoor lastig overzicht te bewaren: wanneer heb ik een student voor het laatst gesproken, hoe vaak is een student aanwezig bij de colleges, hoe zijn de cijfers van de student, welke problemen loopt hij / zij tegenaan, etc.Ook is vaak niet duidelijk welke leerdoelen de student gedurende de opleiding heeft gehad, iets dat de student begeleider graag makkelijk terug zou willen kunnen zien. De opdracht is om een systeem te ontwikkelen dat meer overzicht biedt voor de student begeleider in de studenten die hij/ zij begeleidt.",
                },
            };

            modelBuilder.Entity<Project>().HasData(projects);

            return projects;
        }
    }
}
#endif
