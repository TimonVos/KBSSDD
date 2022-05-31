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
            var competences = SeedCompetences(modelBuilder, form);
            var criteria = SeedCriteria(modelBuilder, competences);
            SeedRequirements(modelBuilder, criteria, indicators);
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

        private List<Criterion> SeedCriteria(ModelBuilder modelBuilder, List<Competence> competences, int id = 1)
        {
            var analyzeId = competences[0].CompetenceId;
            var advizeId = competences[1].CompetenceId;
            var designId = competences[2].CompetenceId;
            var realizeId = competences[3].CompetenceId;
            var manageId = competences[4].CompetenceId;
            var professionalDevelopmentId = competences[5].CompetenceId;

            var criteria = new List<Criterion>
            {
                #region Analyze

                new Criterion
                {
                    CriterionId = id++,
                    Name = "Methodische requirement analyse",
                    CompetenceId = analyzeId,
                    Description = "Alle gerealiseerde sprint backlog items zijn terug te vinden in het functioneel ontwerp. Denk onder andere aan een bijgewerkt domeinmodel  en use case diagram. De uitgewerkte backlog items zijn in het functioneel ontwerp terug te vinden als uitgewerkte user-stories. Waar zinvol is het functioneel ontwerp ondersteunt met activiteitendiagrammen, toestandsdiagrammen en sequentiediagrammen.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Afgestemde BC",
                    CompetenceId = analyzeId,
                    Description = "De business case (de rechtvaardiging van het project, de probleemstelling, de opdracht) is beschreven en afgestemd met de opdrachtgever.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Continu aangevulde PBL",
                    CompetenceId = analyzeId,
                    Description = "De productbacklog wordt continue aangevuld met items die tijdens de analyse (bijvoorbeeld tijdens sprint planning meetings) van het op te lossen ‘probleem’, naar voren komen.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Gedetailleerde BLI",
                    CompetenceId = analyzeId,
                    Description = "Sprintbacklog items zijn tot in voldoende detail geanalyseerd en systematisch uitgewerkt. (Voldoende detail = Gemaakte keuzes worden door alle belanghebbenden begrepen). Hulpmiddelen daarbij zijn o.a.: Userstories incl. scherm/interactie/navigatie-ontwerp, Domeinmodel, Usecase/Userstory diagram.",
                },

                #endregion

                #region Advize

                new Criterion
                {
                    CriterionId = id++,
                    Name = "Geïnformeerde PO",
                    CompetenceId = advizeId,
                    Description = "De product owner is gedurende alle sprints tijdig en volledig geinformeerd.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Communicatievormen",
                    CompetenceId = advizeId,
                    Description = "Er zijn geschikte communicatievormen gekozen en daadwerkelijk toegepast met als doel adviezen te geven.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Correct Nederlands",
                    CompetenceId = advizeId,
                    Description = "Alle documenten zijn geschreven in correct Nederlands, zijn helder en duidelijk. ",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Meedenken met PO",
                    CompetenceId = advizeId,
                    Description = "Het scrum team denkt mee met de product owner (denk aan sprint planning). Het scrum team komt bijvoorbeeld met alternatieven voor wensen van de productowner die minder tijd kosten om te implementeren.",
                },

                #endregion

                #region Design

                new Criterion
                {
                    CriterionId = id++,
                    Name = "BLI in FO",
                    CompetenceId = designId,
                    Description = "Alle gerealiseerde sprint backlog items zijn terug te vinden in het functioneel ontwerp. Denk onder andere aan een bijgewerkt domeinmodel en use case diagram. De uitgewerkte backlog items zijn in het functioneel ontwerp terug te vinden als uitgewerkte user-stories. Waar zinvol is het functioneel ontwerp ondersteunt met activiteitendiagrammen, toestandsdiagrammen en sequentiediagrammen.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Bijwerken van ontwerp",
                    CompetenceId = designId,
                    Description = "Tijdens elke sprint wordt het ontwerp bijgewerkt. Denk bijvoorbeeld aan het toevoegen en/of uitbreiden van klassen in de verschillende klassendiagrammen. Belangrijke technische aspecten worden uitgelegd en ondersteund door (UML-)diagrammen.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Consistent FO en TO",
                    CompetenceId = designId,
                    Description = "Het functioneel ontwerp en het technisch ontwerp zijn volledig consistent met elkaar.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Bijgewerkt ERD",
                    CompetenceId = designId,
                    Description = "Tijdens elke sprint wordt het ERD bijgewerkt (indien van toepassing). Keuzes voor het db-ontwerp (bijv. een extra index) worden toegelicht. De naamgeving van de tabellen en kollomen van de database zijn consistent met de naamgeving zoals gebruikt in het domeinmodel" },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Toegelicht TO",
                    CompetenceId = designId,
                    Description = "De gevolgde architectuur en ontwerpkeuzes zijn in het technisch ontwerp toegelicht en gemotiveerd.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Zelfstandig ontwerp",
                    CompetenceId = designId,
                    Description = "In het ontwerp is alle benodige informatie opgenomen om een nieuw teamlid snel op weg te helpen met het realiseren van de software. Naast de eerder genoemde aspecten kun je daarbij ook denken aan het vermelden van gebruikte tools, frameworks en verwijzingingen naar bruikbaar studiemateriaal.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Testset voor ieder BLI",
                    CompetenceId = designId,
                    Description = "Voor ieder gerealiseerd item is een uitgebreide testset beschreven, waarmee de kwaliteit van de gerealiseerde software aangetoond kan worden.",
                },

                #endregion

                #region Realize

                new Criterion
                {
                    CriterionId = id++,
                    Name = "Comments",
                    CompetenceId = realizeId,
                    Description = "Alle broncode is op consistente wijze van commentaar voorzien.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Coding conventions",
                    CompetenceId = realizeId,
                    Description = "Code coventies zijn beschreven en nageleefd.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Consistentie",
                    CompetenceId = realizeId,
                    Description = "De code is consistent  met het opgestelde ontwerp.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Testprocedure",
                    CompetenceId = realizeId,
                    Description = "Er is een testprocedure beschreven waarin o.a. vastligt wie, wat en wanneer test.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Testrapportage",
                    CompetenceId = realizeId,
                    Description = "De student rapporteert over unit-testen en overige testen.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Unit tests",
                    CompetenceId = realizeId,
                    Description = "Waar zinvol, zijn unit-testen toegepast.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Self-documenting code",
                    CompetenceId = realizeId,
                    Description = "Alle namen in de code gebruiken een consistente vocabulair. Namen in de code beschrijven de intentie van de code.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Formatting",
                    CompetenceId = realizeId,
                    Description = "Formattering geeft een perfect inzicht in de beoogde structuur.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Refactoring",
                    CompetenceId = realizeId,
                    Description = "De code in methodes is voor de gewenste functionaliteit eenvoudig van opzet.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Scalability",
                    CompetenceId = realizeId,
                    Description = "De code is modulair opgezet en daardoor makkelijk te onderhouden, te lezen en te unit testen.",
                },

                #endregion

                #region Manage

                new Criterion
                {
                    CriterionId = id++,
                    Name = "Opgenomen items in SR",
                    CompetenceId = manageId,
                    Description = "Tijdens elke Sprint Review wordt duidelijk aangegeven welke items in de sprint opgenomen zijn en welke items daarvan wel dan wel niet zijn gerealiseerd. Per gerealiseerd item wordt een demo gegeven.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Besproken BDC in SR",
                    CompetenceId = manageId,
                    Description = "Tijdens elke Sprint Review wordt de burn down chart besproken. Wat was de geplande velocity en waar is het team op uitgekomen?",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Daily standup",
                    CompetenceId = manageId,
                    Description = "Scrum stand-ups worden dagelijks en getimeboxed (bijv. max 15 minuten) uitgevoerd en zijn navolgbaar (foto’s, reflectie) voor de assessoren.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Tool voor BLI",
                    CompetenceId = manageId,
                    Description = "Er is een geschikte tool en systematiek geselecteerd voor het managen van de product backlog items. Dit wordt in het reflectieverslag besproken.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Version control system",
                    CompetenceId = manageId,
                    Description = "Er is een geschikte tool en systematiek geselecteerd voor het samenwerken aan en het beheren van de broncode. Dit wordt in het reflectieverslag besproken.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Gedetaileerde BLI",
                    CompetenceId = manageId,
                    Description = "Productbacklog items zijn in voldoende detail en consistent beschreven in de product backlog..",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Geprioriteerde BLI",
                    CompetenceId = manageId,
                    Description = "Productbacklog items met een hoge prioriteit zijn al duidelijk verder uitgewerkt in vergelijking met items met een lage prioriteit.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Afgestemde PBL en SBL",
                    CompetenceId = manageId,
                    Description = "Zowel productbacklog items als sprintbacklog items zijn volledig afgestemd met de productowner.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Bug tracking",
                    CompetenceId = manageId,
                    Description = "Bekende bugs worden geadminstreerd (bijvoorbeeld door ze op te nemen in de product backlog) en het oplossen hiervan heeft een plaats gekregen in het software ontwikkelproces",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Retro",
                    CompetenceId = manageId,
                    Description = "De retrospective is uitgevoerd en heeft (indien nodig) geleid tot aanpassingen op het proces.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "DoD",
                    CompetenceId = manageId,
                    Description = "De Definition of Done is tot in voldoende detail uitgewerkt. (DoD bevat minimaal: Code Conventies, Testscenario’s, Documentatie-eisen, Acceptatiecriteria van de Product Owner)",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Increment",
                    CompetenceId = manageId,
                    Description = "Er wordt na elke sprint een ready to release softwareproduct (overeenkomstig definition of done)  increment opgeleverd.",
                },

                #endregion

                #region Professional development

                new Criterion
                {
                    CriterionId = id++,
                    Name = "Reflectie op verbeteringspunten",
                    CompetenceId = professionalDevelopmentId,
                    Description = "Er is een gedetailleerde reflectie op de verbeterpunten uit de Retrospective beschreven. (Per student beschreven in ‘Professionele Ontwikkeling’)",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Leerdoelen",
                    CompetenceId = professionalDevelopmentId,
                    Description = "Bij aanvang zijn realistische vakinhoudelijke en persoonlijke professionele leerdoelen SMART geformuleerd. (Per student beschreven in ‘Professionele Ontwikkeling’). De student is hier actief mee aan de gang gegaan.",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Professionele Ontwikkeling",
                    CompetenceId = professionalDevelopmentId,
                    Description = "Het werken aan professionele ontwikkeling  en de resultaten hiervan zijn aan de hand van concrete voorbeelden geïllustreerd. (Per student beschreven in ‘Professionele Ontwikkeling’)",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Sterktes en zwaktes",
                    CompetenceId = professionalDevelopmentId,
                    Description = "Er is inzicht in de eigen sterktes en zwaktes. (Per student beschreven in ‘Professionele Ontwikkeling’)",
                },
                new Criterion
                {
                    CriterionId = id++,
                    Name = "Reflectie",
                    CompetenceId = professionalDevelopmentId,
                    Description = "Er is een gedetailleerde reflectie op alle hier genoemde competenties. De reflectie is per groep, waarbij de bijdrage van de individuele student goed naar voren komt.",
                },

                #endregion
            };

            modelBuilder.Entity<Criterion>().HasData(criteria);

            return criteria;
        }

        private List<Requirement> SeedRequirements(ModelBuilder modelBuilder, List<Criterion> criteria, List<Indicator> indicators, int id = 1)
        {
            #region Indicators

            var developmentPointId = indicators[0].IndicatorId;
            var competentId = indicators[1].IndicatorId;
            var exemplarId = indicators[2].IndicatorId;

            #endregion

            #region Requirements

            #region Analyze

            var analyzeId1 = criteria[0].CriterionId;
            var analyzeId2 = criteria[1].CriterionId;
            var analyzeId3 = criteria[2].CriterionId;
            var analyzeId4 = criteria[3].CriterionId;

            #endregion

            #region Advize

            var advizeId1 = criteria[4].CriterionId;
            var advizeId2 = criteria[5].CriterionId;
            var advizeId3 = criteria[6].CriterionId;
            var advizeId4 = criteria[7].CriterionId;

            #endregion

            #region Design

            var designId1 = criteria[8].CriterionId;
            var designId2 = criteria[9].CriterionId;
            var designId3 = criteria[10].CriterionId;
            var designId4 = criteria[11].CriterionId;
            var designId5 = criteria[12].CriterionId;
            var designId6 = criteria[13].CriterionId;
            var designId7 = criteria[14].CriterionId;

            #endregion

            #region Realize

            var realizeId1 = criteria[15].CriterionId;
            var realizeId2 = criteria[16].CriterionId;
            var realizeId3 = criteria[17].CriterionId;
            var realizeId4 = criteria[18].CriterionId;
            var realizeId5 = criteria[19].CriterionId;
            var realizeId6 = criteria[20].CriterionId;
            var realizeId7 = criteria[21].CriterionId;
            var realizeId8 = criteria[22].CriterionId;
            var realizeId9 = criteria[23].CriterionId;
            var realizeId10 = criteria[24].CriterionId;

            #endregion

            #region Manage

            var manageId1 = criteria[25].CriterionId;
            var manageId2 = criteria[26].CriterionId;
            var manageId3 = criteria[27].CriterionId;
            var manageId4 = criteria[28].CriterionId;
            var manageId5 = criteria[29].CriterionId;
            var manageId6 = criteria[30].CriterionId;
            var manageId7 = criteria[31].CriterionId;
            var manageId8 = criteria[32].CriterionId;
            var manageId9 = criteria[33].CriterionId;
            var manageId10 = criteria[34].CriterionId;
            var manageId11 = criteria[35].CriterionId;
            var manageId12 = criteria[36].CriterionId;

            #endregion

            #region Professional development

            var professionalDevelopmentId1 = criteria[37].CriterionId;
            var professionalDevelopmentId2 = criteria[38].CriterionId;
            var professionalDevelopmentId3 = criteria[39].CriterionId;
            var professionalDevelopmentId4 = criteria[40].CriterionId;
            var professionalDevelopmentId5 = criteria[41].CriterionId;

            #endregion

            #endregion

            var requirements = new List<Requirement>
            {

                #region Analyze

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = analyzeId1,
                    IndicatorId = developmentPointId,
                    Description = "Bereidt gesprekken niet voor. Koppelt niet terug aan betrokkenen. Maakt geen gebruik van UML of vergelijkbare diagrammen. Verdiept zich niet in het domein. Houdt geen rekening met niet-functionele eisen.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = analyzeId1,
                    IndicatorId = competentId,
                    Description = "Bereidt gesprekken enigszins voor en koppelt in enige mate terug aan betrokkenen. Maakt gebruik van hooguit één soort diagram (bijv. domeinmodel of use case diagram). Verdiept zich enigszins in het domein, bijvoorbeeld door het bestuderen van vergelijkbare systemen. Houdt impliciet rekening met niet-functionele eisen.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = analyzeId1,
                    IndicatorId = exemplarId,
                    Description = "Bereidt gesprekken goed voor en koppelt de resultaten terug aan betrokkenen Maakt gebruik van verschillende UML diagrammen om het probleem vanuit verschillende gezichtspunten te benaderen. Kiest de juiste diagrammen voor de context. Verdiept zich uitgebreid in het domein en gebruikt daarvoor verschillende bronnen. Houdt expliciet rekening met niet-functionele eisen.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = analyzeId2,
                    IndicatorId = developmentPointId,
                    Description = "De student voert de opdracht uit, echter zonder na te denken over de achterliggende probleemstelling.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = analyzeId2,
                    IndicatorId = competentId,
                    Description = "De student is zich bewust van het onderliggende probleem voor de opdracht en legt dit vast.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = analyzeId2,
                    IndicatorId = exemplarId,
                    Description = "De student werkt de business case uit en toont aan dat de gekozen oplossing daarmee in overeenstemming is. De student heeft alternatieven in overweging genomen en besproken met de opdrachtgever.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = analyzeId3,
                    IndicatorId = developmentPointId,
                    Description = "Het team is niet actief bezig met de product backlog.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = analyzeId3,
                    IndicatorId = competentId,
                    Description = "Tijdens de sprint planning meetings, worden er veelvuldig nieuwe items vastgelegd. ",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = analyzeId3,
                    IndicatorId = exemplarId,
                    Description = "Tijdens de sprint planning meetings, worden er veelvuldig nieuwe items vastgelegd. De items worden tijdens en/of na de sprint planning meeting met de product owner besproken en afhankelijk van de prioriteit gedetailleerd.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = analyzeId4,
                    IndicatorId = developmentPointId,
                    Description = "Sprintbacklog items worden kort besproken tijdens een sprint planning meeting en op basis daarvan wordt een inschatting gemaakt voor de benodigde inspanning. Als een docent er naar vraagt, blijkt echter dat een ieder zijn eigen interpretatie geeft aan een item.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = analyzeId4,
                    IndicatorId = competentId,
                    Description = "Sprintbacklog items worden  besproken tijdens een sprint planning. Diepgang ontbreekt echter nog.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = analyzeId4,
                    IndicatorId = exemplarId,
                    Description = "Zowel product owner als teamleden weten voor ieder item nauwkeurig wat er gerealiseerd gaat worden. Onafhankelijk van elkaar zouden ze tot een vergelijkbare uitwerking komen. Tijdens de sprint planning meeting is er uitgebreid gebruik gemaakt van bijvoorbeeld het white board, om zaken duidelijk te maken, en alternatieven te bespreken. Het kan ook zijn dat items al eerder tot in voldoende detail zijn uitgewerkt, zodat deze minder aandacht behoeven tijdens de meeting.",
                },

                #endregion

                #region Advize

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = advizeId1,
                    IndicatorId = developmentPointId,
                    Description = "Dit gebeurt niet.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = advizeId1,
                    IndicatorId = competentId,
                    Description = "De studenten informeren de product owner middels e-mail. Initiatief voor bespreken van heikele punten ligt nog voor een groot deel bij de product owner.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = advizeId1,
                    IndicatorId = exemplarId,
                    Description = "De studenten informeren de product owner gedurende de sprints. Verschillende communicatievormen worden gebruikt, zoals bijvoorbeeld telefoon en e-mail. Er is goed overlegd indien een item bijvoorbeeld te veel tijd dreigt te vragen of indien er alternatieven besproken dienen te worden.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = advizeId2,
                    IndicatorId = developmentPointId,
                    Description = "Communicatie is hoofdzakelijk mondeling, tijdens de daarvoor geplande meetings.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = advizeId2,
                    IndicatorId = competentId,
                    Description = "Studenten gebruiken tijdens meetings meerdere zinvolle communicatiemiddelen.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = advizeId2,
                    IndicatorId = exemplarId,
                    Description = "Studenten gebruiken tijdens meetings meerdere zinvolle communicatiemiddelen en stimuleren elkaar en de product owner om input te geven. Incidenteel worden er demos (bijv. voorstel schermlay-out) voorbereid om advies te kunnen geven.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = advizeId3,
                    IndicatorId = developmentPointId,
                    Description = "De documenten bevatten schrijffouten en zijn moeilijk te volgen.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = advizeId3,
                    IndicatorId = competentId,
                    Description = "De documenten bevatten nauwelijks schrijffouten. De documenten zijn duidelijk.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = advizeId3,
                    IndicatorId = exemplarId,
                    Description = "De documenten bevatten nauwelijks schrijffouten. De lezer wordt bij de hand genomen, de hoofd- en bijzaken worden heel goed onderscheiden.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = advizeId4,
                    IndicatorId = developmentPointId,
                    Description = "De studenten leggen het initiatief volledig bij de product owner.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = advizeId4,
                    IndicatorId = competentId,
                    Description = "De studenten denken gevraagd en ongevraagd  mee met de product owner. Het team komt met alternatieven voor de product owner.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = advizeId4,
                    IndicatorId = exemplarId,
                    Description = "De studenten denken gevraagd en ongevraagd mee met de product owner. Alternatieven worden goed uitgelegd zodat de product owner een weloverwogen keuze kan maken. Tijdens sprint planning meetings zijn de studenten goed voorbereid zodat binnen de beschikbare tijd, alternatieven gepresenteerd kunnen worden.",
                },

                #endregion

                #region Design

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId1,
                    IndicatorId = developmentPointId,
                    Description = "Het domeinmodel en/of use case diagram ontbreken of zijn van slechte kwaliteit. Essentiele user-stories zijn niet volledig uitgewerkt.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId1,
                    IndicatorId = competentId,
                    Description = "Het domeinmodel en use case diagram zijn correct, consistent met elkaar, en zonodige opgesplitst in meerdere diagrammen. Alle essentiële user-stories zijn volledig uitgewerkt.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId1,
                    IndicatorId = exemplarId,
                    Description = "Een lezer krijgt op basis van het functioneel ontwerp snel inzicht in de geleverde functionaliteit. Het domeinmodel en use case diagram zijn correct, consistent met elkaar, en zonodig opgesplitst in meerdere diagrammen. Alle essentiële user-stories zijn volledig uitgewerkt.Triviale user-stories worden genoemd, maar niet tot in detail uitgewerkt. Waar zinvol is het functioneel ontwerp ondersteunt met activiteitendiagrammen, toestandsdiagrammen en sequentiediagrammen.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId2,
                    IndicatorId = developmentPointId,
                    Description = "Wordt niet structureel gedaan.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId2,
                    IndicatorId = competentId,
                    Description = "Wordt structureel gedaan, maar beperkt zich tot hoofdlijnen.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId2,
                    IndicatorId = exemplarId,
                    Description = "Wordt structureel gedaan. Na afloop van iedere sprint is het ontwerp ook echt af, dus alle belangrijke tecnische aspecten worden meegenomen en niet uitgesteld tot de laatste sprint.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId3,
                    IndicatorId = developmentPointId,
                    Description = "Het functioneel ontwerp en het technisch ontwerp zijn niet volledig en/of niet consistent met elkaar.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId3,
                    IndicatorId = competentId,
                    Description = "Het functioneel ontwerp en het technisch ontwerp zijn volledig en consistent met elkaar.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId3,
                    IndicatorId = exemplarId,
                    Description = "Het functioneel ontwerp en het technisch ontwerp zijn volledig en consistent met elkaar. Elementen uit functioneel ontwerp zijn eenvoudig te traceren in het technisch ontwerp, bijvoorbeeld door consistente naamgeving.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId4,
                    IndicatorId = developmentPointId,
                    Description = "Het ERD is na afloop van een sprint niet consistent met de gerealiseerde database.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId4,
                    IndicatorId = competentId,
                    Description = "Het ERD is na afloop consistent met de gerealiseerde database. Keuzes voor het db-ontwerp (bijv. een extra index) worden toegelicht.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId4,
                    IndicatorId = exemplarId,
                    Description = "Het ERD is na afloop consistent met de gerealiseerde database. Keuzes voor het db-ontwerp (bijv. een extra index) worden toegelicht. De naamgeving van de tabellen en kollomen van de database zijn consistent met de naamgeving zoals gebruikt in het domeinmodel.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId5,
                    IndicatorId = developmentPointId,
                    Description = "Het technisch ontwerp ondersteunt een ontwikkelaar niet of nauwelijks. Het technisch ontwerp bestaat dan bijvoorbeeld slechts uit een klassendiagram waarin alle klassen en relaties opgesomd worden.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId5,
                    IndicatorId = competentId,
                    Description = "Het technisch ontwerp laat duidelijk de architectuur van het systeem naar voren komen. Bijvoorbeeld door aan te geven welke klassen in welke systeemlagen zijn opgenomen. Essentiële ontwerpbeslissingen worden uitgelegd en ondersteund met UML-diagrammen.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId5,
                    IndicatorId = exemplarId,
                    Description = "Het technisch ontwerp laat duidelijk de architectuur van het systeem naar voren komen. Bijvoorbeeld door aan te geven welke klassen in welke systeemlagen zijn opgenomen. Essentiele ontwerpbeslissingen worden uitgelegd en ondersteund met UML-diagrammen. De lezer wordt bij de hand genomen door het ontwerp eerst op hoofdlijnen te schetsen en daarna in te zoomen op essentiële details.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId6,
                    IndicatorId = developmentPointId,
                    Description = "Niet gedaan.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId6,
                    IndicatorId = competentId,
                    Description = "Summier gedaan, bijvoorbeeld slechts een opsomming gegeven van gebruikte tools en frameworks.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId6,
                    IndicatorId = exemplarId,
                    Description = "Alles wat een ontwikkelaar snel op weg kan helpen en relatief weinig tijd kost om te beschrijven, is in het ontwerp opgenomen. Denk bijvoorbeeld aan handleidingen voor frameworks waarnaar verwezen wordt, of bijvoorbeeld problemen met frameworks waar het team tegenaan gelopen is en de oplossing daarvoor.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId7,
                    IndicatorId = developmentPointId,
                    Description = "Niet voor alle gerealiseerde items is een testset beschreven.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId7,
                    IndicatorId = competentId,
                    Description = "Er zijn testscenario’s voor ieder item opgenomen. Er is echter geen rekening gehouden met ‘alle’ mogelijk scenario’s. Vaak wordt voor een item alleen het ‘happy day scenario’ beschreven.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = designId7,
                    IndicatorId = exemplarId,
                    Description = "Voor alle gerealiseerde items is een testset beschreven. Over de testsets is goed nagedacht, alle denkbare scenarios waarop een item problemen zou kunnen geven zijn opgenomen als testgeval. De kwaliteit van het systeem wordt hiermee goed geborgd.",
                },

                #endregion

                #region Realize

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId1,
                    IndicatorId = developmentPointId,
                    Description = "Geen commentaar in broncode opgenomen.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId1,
                    IndicatorId = competentId,
                    Description = "Daar waar zinvol, commentaar opgenomen in broncode. Echter niet op consistente wijze.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId1,
                    IndicatorId = exemplarId,
                    Description = "Daar waar zinvol, commentaar opgenomen in broncode. Op consistente wijze gedaan.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId2,
                    IndicatorId = developmentPointId,
                    Description = "Geen code conventies toegepast.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId2,
                    IndicatorId = competentId,
                    Description = "Code conventies toegepast, echter niet beschreven.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId2,
                    IndicatorId = exemplarId,
                    Description = "Code conventeis toegepast en beschreven.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId3,
                    IndicatorId = developmentPointId,
                    Description = "Keuzes uit het ontwerp zijn niet terug te vinden in broncode.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId3,
                    IndicatorId = competentId,
                    Description = "Keuzes uit het ontwerp zijn terug te vinden in de broncode, alleen sluiten de gebruikte termen (bijv. klassennamen) niet goed op elkaar aan.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId3,
                    IndicatorId = exemplarId,
                    Description = "Keuzes uit het ontwerp zijn volledig en consistent gerealiseerd in broncode.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId4,
                    IndicatorId = developmentPointId,
                    Description = "Geen testprocedure aanwezig.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId4,
                    IndicatorId = competentId,
                    Description = "Er is een testprocedure beschreven waarin vastligt wie, wat en wanneer test.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId4,
                    IndicatorId = exemplarId,
                    Description = "Testprocedure is uitgebreid beschreven (soorten testen, input voor evt. testers, manier waarop bugs gemeld worden, etcetera)",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId5,
                    IndicatorId = developmentPointId,
                    Description = "Geen testrapportage aanwezig",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId5,
                    IndicatorId = competentId,
                    Description = "Testrapportage is globaal beschreven.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId5,
                    IndicatorId = exemplarId,
                    Description = "Uitgebreide testrapportage aanwezig. O.a. duidelijk wie, wat, wanneer getest heeft en welke bugs in welke stadia gevonden zijn.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId6,
                    IndicatorId = developmentPointId,
                    Description = "Geen unit-testen toegepast, terwijl dit wel zinvol was geweest.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId6,
                    IndicatorId = competentId,
                    Description = "Incidenteel unit-test toegepast, echter niet voor alle code waarvoor dit zinvol zou zijn geweest.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId6,
                    IndicatorId = exemplarId,
                    Description = "Voor alle code waarvoor dit zinvol is, zijn unit-testen toegepast.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId7,
                    IndicatorId = developmentPointId,
                    Description = "Niet alle namen beschrijven de intentie van de code correct.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId7,
                    IndicatorId = competentId,
                    Description = "Alle namen in de code beschrijven de intentie van de code, maar niet altijd compleet en ook niet altijd even consistent.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId7,
                    IndicatorId = exemplarId,
                    Description = "Alle namen in de code beschrijven de intentie van de code. Namen zijn compleet en consistent.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId8,
                    IndicatorId = developmentPointId,
                    Description = "Formattering mist of regels zijn te lang om te lezen.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId8,
                    IndicatorId = competentId,
                    Description = "Inspringen , regelovergangen en het gebruik van haakjes gegeven een inzicht in de beoogde structuur.indentation, maar is niet consitent gedaan.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId8,
                    IndicatorId = exemplarId,
                    Description = "Inspringen , regelovergangen en het gebruik van haakjes gegeven een perfect inzicht in de beoogde structuur.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId9,
                    IndicatorId = developmentPointId,
                    Description = "Methodes bevatten diep geneste code, controle structuren zijn misleidend voor de beoogde functionaliteit.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId9,
                    IndicatorId = competentId,
                    Description = "De code is eenvoudig en bevat weinig exceptions. De controle structuren en keuzes voor libraries is toepasselijk voor de gewenste functionaliteit.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId9,
                    IndicatorId = exemplarId,
                    Description = "De code is eenvoudig en bevat weinig exceptions. De controle structuren en keuzes voor libraries is toepasselijk voor de gewenste functionaliteit. De code laat het gewenste pad duidelijk tot uitdrukking komen.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId10,
                    IndicatorId = developmentPointId,
                    Description = "De code is geschreven in enkele grote klassen en methodes. Sommige code komt vaker voor (copy paste).",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId10,
                    IndicatorId = competentId,
                    Description = "De indeling in klassen en methodes maakt de code overzichtelijk, maar kan nog verder geoptimaliseerd worden. Dit blijkt bijvoorbeeld tijdens het schrijven van de unit testen.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = realizeId10,
                    IndicatorId = exemplarId,
                    Description = "De indeling in klassen en methodes maakt de code overzichtelijk en goed testbaar. Methodes voeren een zeer beperkt aantal taken uit. ",
                },

                #endregion

                #region Manage

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId1,
                    IndicatorId = developmentPointId,
                    Description = "Er wordt een demo gegeven. Voor het publiek wordt niet expliciet  duidelijk gemaakt wat de items voor de sprint waren en wat daarvan al dan niet gerealiseerd is.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId1,
                    IndicatorId = competentId,
                    Description = "Er wordt een demo gegeven en enigszins duidelijk gemaakt wat de te realiseren items waren en wat daarvan gerealiseerd is.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId1,
                    IndicatorId = exemplarId,
                    Description = "Duidelijk overzicht van sprint items en hetgeen daarvan gerealiseerd is. Per item wordt een demo gegeven om aan te tonen dat het item gerealiseerd is.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId2,
                    IndicatorId = developmentPointId,
                    Description = "De burn down chart wordt niet getoond. De geplande velocity en de gerealiseerde velocity komen niet ter sprake.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId2,
                    IndicatorId = competentId,
                    Description = "De burn down chart wordt getoond. De geplande en gerealiseerde velocity is duidelijk.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId2,
                    IndicatorId = exemplarId,
                    Description = "De geplande velocity wordt vermeld. De burn down chart is correct, wordt getoond en uitgelegd. Het team trekt conclusies.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId3,
                    IndicatorId = developmentPointId,
                    Description = "Stand-ups worden niet dagelijks uitgevoerd.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId3,
                    IndicatorId = competentId,
                    Description = "Stand-ups zijn dagelijks uitgevoerd. Bewijslast is mager.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId3,
                    IndicatorId = exemplarId,
                    Description = "Stand-ups zijn dagelijks uitgevoerd. Bewijslast is geleverd. Uit de reflecties blijkt dat de studenten het nut van de stand-up goed doorgronden.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId4,
                    IndicatorId = developmentPointId,
                    Description = "Niet beschreven.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId4,
                    IndicatorId = competentId,
                    Description = "De motivatie voor de keuze voor een bepaald tool is beschreven of de systematiek is beschreven en gemotiveerd, maar niet beide.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId4,
                    IndicatorId = exemplarId,
                    Description = "De motivatie voor de keuze voor een bepaald tool is beschreven. Ook de systematiek is beschreven en gemotiveerd.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId5,
                    IndicatorId = developmentPointId,
                    Description = "Niet beschreven.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId5,
                    IndicatorId = competentId,
                    Description = "De motivatie voor de keuze voor een bepaald tool is beschreven of de systematiek is beschreven en gemotiveerd, maar niet beide.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId5,
                    IndicatorId = exemplarId,
                    Description = "De motivatie voor de keuze voor een bepaald tool is beschreven. Ook de systematiek is beschreven en gemotiveerd.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId6,
                    IndicatorId = developmentPointId,
                    Description = "Productbacklog items zijn beschreven, maar niet op een consistente wijze. Items zijn niet duidelijk beschreven.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId6,
                    IndicatorId = competentId,
                    Description = "Productbacklog items zijn consistent beschreven, maar nog niet altijd in voldoende detail om de intentie goed te begrijpen.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId6,
                    IndicatorId = exemplarId,
                    Description = "Productbacklog items zijn in voldoende detail en consistent beschreven in de product backlog. De intentie is voor alle betrokkenen goed te begrijpen.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId7,
                    IndicatorId = developmentPointId,
                    Description = "Er is geen verschil te onderkennen in detaillering.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId7,
                    IndicatorId = competentId,
                    Description = "Soms zijn items met een hoge prioriteit al verder in detail uitgewerkt. Dit gebeurt echter nog niet structureel.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId7,
                    IndicatorId = exemplarId,
                    Description = "Productbacklog items met een hoge prioriteit zijn al duidelijk verder uitgewerkt in vergelijking met items met een lage prioriteit. Dit heeft continue de aandacht van het team.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId8,
                    IndicatorId = developmentPointId,
                    Description = "Afstemming vind buiten de sprint planning meetings niet plaats. Zelfs tijdens de meetings komt dit nauwelijks aan bod. Soms weet de product owner of teamleden niet wat de bedoeling van een item is of wordt deze verschillend geïnterpreteerd",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId8,
                    IndicatorId = competentId,
                    Description = "Afstemming vind plaats, bijvoorbeeld door na afloop van een meeting een overzicht aan de product owner te versturen. Echte afstemming vind echter niet plaats. Soms interpreteert de product owner een item nog anders dan het team.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId8,
                    IndicatorId = exemplarId,
                    Description = "Zowel de product owner als de teamleden weten precies te vertellen wat een item inhoudt. Afstemming van items vind ook buiten de meetings om plaats.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId9,
                    IndicatorId = developmentPointId,
                    Description = "Bugs worden niet geadministreerd.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId9,
                    IndicatorId = competentId,
                    Description = "Bugs worden geadministreert, maar het oplossen hiervan heeft niet een duidelijk plaats gekregen in het software ontwikkelproces.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId9,
                    IndicatorId = exemplarId,
                    Description = "Bekende bugs worden geadminstreerd (bijvoorbeeld door ze op te nemen in de product backlog) en het oplossen hiervan heeft een plaats gekregen in het software ontwikkelproces. De product owner bepaald de prioriteit van het oplossen van de bugs. Er kan prioriteit gegeven worden aan het toevoegen van nieuwe functionaliteit, boven het oplossen van een bug.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId10,
                    IndicatorId = developmentPointId,
                    Description = "De retrospective is niet uitgevoerd.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId10,
                    IndicatorId = competentId,
                    Description = "De retrospective is na afloop van de laatste twee sprints uitgevoerd en heeft (indien nodig) geleid tot aanpassingen op het proces.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId10,
                    IndicatorId = exemplarId,
                    Description = "De retrospective is van het begin af aan uitgevoerd en heeft (indien nodig) geleid tot aanpassingen op het proces.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId11,
                    IndicatorId = developmentPointId,
                    Description = "Er is geen definition of done.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId11,
                    IndicatorId = competentId,
                    Description = "Er is een standaard definition of done.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId11,
                    IndicatorId = exemplarId,
                    Description = "Feedback (bijvoorbeeld verkregen tijdens een retrospective)  is verwerkt in een aangepast definition of done.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId12,
                    IndicatorId = developmentPointId,
                    Description = "Definition of done wordt niet gevolgd.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId12,
                    IndicatorId = competentId,
                    Description = "De definition of done wordt strict gevolgt. Tijdens de eerste sprint is dit nog niet helemaal gelukt",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = manageId12,
                    IndicatorId = exemplarId,
                    Description = "De definition of done wordt van het begin af aan strict gevolgd.",
                },

                #endregion

                #region Professional development

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId1,
                    IndicatorId = developmentPointId,
                    Description = "De student gaat hier niet op in.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId1,
                    IndicatorId = competentId,
                    Description = "De student reflecteert op de verbeteringen.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId1,
                    IndicatorId = exemplarId,
                    Description = "De student reflecteert op de verbeteringen en geeft duidelijk aan wat zijn of haar rol hierin is geweest.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId2,
                    IndicatorId = developmentPointId,
                    Description = "De student is zijn leerdoelen uit het oog verloren.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId2,
                    IndicatorId = competentId,
                    Description = "De student is actief met de leerdoelen aan de slag gegaan. ",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId2,
                    IndicatorId = exemplarId,
                    Description = "De student is actief met de leerdoelen aan de slag gegaan en reflecteerd hier uitgebreid op.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId3,
                    IndicatorId = developmentPointId,
                    Description = "De student besteed hier geen aandacht aan.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId3,
                    IndicatorId = competentId,
                    Description = "De student beschrijft zijn professionele ontwikkeling.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId3,
                    IndicatorId = exemplarId,
                    Description = "De student beschrijft zijn professionele ontwikkeling. Uit de reflectie blijkt dat de student een project aangrijpt om voor zichzelf stappen te maken op het vlak van persoonlijke ontwikkeling.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId4,
                    IndicatorId = developmentPointId,
                    Description = "De student besteed hier geen aandacht aan.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId4,
                    IndicatorId = competentId,
                    Description = "De student is zich bewust van zijn eigen sterktes en zwaktes en beschrijft deze in de reflectie.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId4,
                    IndicatorId = exemplarId,
                    Description = "De student is zich bewust van zijn eigen sterktes en zwaktes en beschrijft deze in de reflectie. De student geeft duidelijk aan hoe hij of zij in de toekomst de sterktes optimaal kan inzetten, en hoe hij of zij de zwaktes gaat opvangen en/of zich op deze punten gaat verbeteren.",
                },

                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId5,
                    IndicatorId = developmentPointId,
                    Description = "Er wordt hoofdzakelijk beschreven wat er is opgeleverd.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId5,
                    IndicatorId = competentId,
                    Description = "Er wordt beschreven wat er is opgeleverd en wat de bijdrage is geweest van iedere student. Op gemaakte keuzes wordt gereflecteerd. Studenten laten zien dat ze weten wat hun ontwikkelpunten nog zijn. Diepgang en bewijsmateriaal is mager.",
                },
                new Requirement
                {
                    RequirementId = id++,
                    CriterionId = professionalDevelopmentId5,
                    IndicatorId = exemplarId,
                    Description = "Er wordt een gedetailleerde reflectie opgeleverd, compleet met bewijsmateriaal (zoals bijv. foto’s van meetings met gevuld white board). Op gemaakte keuzes wordt gereflecteerd. Studenten laten zien dat ze weten wat hun ontwikkelpunten nog zijn. De studenten nemen hun eigen handelen kritisch onder de loep. Een docent die niet bij het project betrokken is geweest, kan op basis van de reflectie een gefundeerde, individuele beoordeling geven.",
                },

                #endregion
            };

            modelBuilder.Entity<Requirement>().HasData(requirements);

            return requirements;
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
