using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service.Database.Migrations
{
    public partial class ReleaseSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Forms");

            migrationBuilder.InsertData(
                table: "Forms",
                columns: new[] { "FormId", "Name" },
                values: new object[] { 1, "Software Engineering periode 2" });

            migrationBuilder.InsertData(
                table: "Indicators",
                columns: new[] { "IndicatorId", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Ontwikkelpunt", 3.0 },
                    { 2, "Competent", 7.0 },
                    { 3, "Voorbeeldig", 9.0 }
                });

            migrationBuilder.InsertData(
                table: "Competences",
                columns: new[] { "CompetenceId", "Description", "Evidence", "FormId", "Name", "Weight" },
                values: new object[,]
                {
                    { 1, null, "Product Backlog\r\nSprint Backlog\r\nBeschreven Business Case (eventueel als inleiding bij het functioneel ontwerp)\r\nAnder bewijsmateriaal zoals: interviewverslagen, schetsen van UML-diagrammen, foto’s van schetsen op whiteboards\r\nPortfolio: Reflectie op competentie Analyse & Onderzoek", 1, "Analyseren", 0.10000000000000001 },
                    { 2, null, "Sprint review\r\nSprint planning\r\nProduct backlog\r\nSprint backlog\r\nDefinition of Done\r\nPortfolio: Reflectie op competentie Advies en Communicatie", 1, "Adviseren", 0.10000000000000001 },
                    { 3, null, "Het functioneel ontwerp - Usecase/Userstory diagram, Domeinmodel en evt. andere diagrammen\r\nHet technisch ontwerp  – ERD, (UML-)diagrammen\r\nTestscenario’s (evt. in het functioneel ontwerp)\r\nPortfolio: Reflectie op competentie Ontwerp en Architectuur", 1, "Ontwerpen", 0.20000000000000001 },
                    { 4, null, "Broncode\r\nTestscenario’s (evt. in het functioneel ontwerp)\r\nTestprocedure\r\nTestrapportages\r\nTestprocedure\r\nUnit testen\r\nCode conventies\r\nInstallatiehandleiding\r\nPortfolio: Reflectie op competentie Realisatie en Testen ", 1, "Realiseren", 0.29999999999999999 },
                    { 5, null, "Dagelijkse Scrum\r\nSprint review\r\nRetrospective \r\nProduct backlog\r\nSprint backlog\r\nBurn down charts\r\nPortfolio: reflective op competentie management en beheer ", 1, "Beheren", 0.20000000000000001 },
                    { 6, null, "Retrospective\r\nPortfolio: Hoofdstuk 'Professionele ontwikkeling'", 1, "Professionele Ontwikkeling", 0.10000000000000001 }
                });

            migrationBuilder.InsertData(
                table: "FormIndicators",
                columns: new[] { "FormId", "IndicatorId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "ProjectId", "Code", "Description", "FormId", "Name" },
                values: new object[,]
                {
                    { 1, "ICT.SE.OSD.PRJCT.V21", "De docenten beoordelen KBS-projecten en stages met behulp van het assessmentformulier. Dit formulier vult de docent in op papier of in Word door de relevante vakken te markeren. Vervolgens moet de docent zelf het cijfer berekenen (afhankelijk van de weging) en daarna moeten de cijfers handmatig ingevuld worden in Educator. Dit vereist veel handelingen en afhankelijkheid van verschillende systemen. De docenten willen dit formulier gedigitaliseerd hebben en willen dat jullie als SCRUM-team nadenken over hoe je hem/haar zoveel mogelijk tijd kunt besparen. Het zou bijvoorbeeld mooi zijn als er één systeem is dat gebruikt wordt, in plaats van meerdere systemen.", 1, "Beoordelingssysteem" },
                    { 2, "ICT.SE.OSD.PRJCT.V21", "Als student begeleider heb je vaak veel studenten die je moet coachen. Soms is het daardoor lastig overzicht te bewaren: wanneer heb ik een student voor het laatst gesproken, hoe vaak is een student aanwezig bij de colleges, hoe zijn de cijfers van de student, welke problemen loopt hij / zij tegenaan, etc.Ook is vaak niet duidelijk welke leerdoelen de student gedurende de opleiding heeft gehad, iets dat de student begeleider graag makkelijk terug zou willen kunnen zien. De opdracht is om een systeem te ontwikkelen dat meer overzicht biedt voor de student begeleider in de studenten die hij/ zij begeleidt.", 1, "Systeem student begeleider" }
                });

            migrationBuilder.InsertData(
                table: "Criteria",
                columns: new[] { "CriterionId", "CompetenceId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Alle gerealiseerde sprint backlog items zijn terug te vinden in het functioneel ontwerp. Denk onder andere aan een bijgewerkt domeinmodel  en use case diagram. De uitgewerkte backlog items zijn in het functioneel ontwerp terug te vinden als uitgewerkte user-stories. Waar zinvol is het functioneel ontwerp ondersteunt met activiteitendiagrammen, toestandsdiagrammen en sequentiediagrammen.", "Methodische requirement analyse" },
                    { 2, 1, "De business case (de rechtvaardiging van het project, de probleemstelling, de opdracht) is beschreven en afgestemd met de opdrachtgever.", "Afgestemde BC" },
                    { 3, 1, "De productbacklog wordt continue aangevuld met items die tijdens de analyse (bijvoorbeeld tijdens sprint planning meetings) van het op te lossen ‘probleem’, naar voren komen.", "Continu aangevulde PBL" },
                    { 4, 1, "Sprintbacklog items zijn tot in voldoende detail geanalyseerd en systematisch uitgewerkt. (Voldoende detail = Gemaakte keuzes worden door alle belanghebbenden begrepen). Hulpmiddelen daarbij zijn o.a.: Userstories incl. scherm/interactie/navigatie-ontwerp, Domeinmodel, Usecase/Userstory diagram.", "Gedetailleerde BLI" },
                    { 5, 2, "De product owner is gedurende alle sprints tijdig en volledig geinformeerd.", "Geïnformeerde PO" },
                    { 6, 2, "Er zijn geschikte communicatievormen gekozen en daadwerkelijk toegepast met als doel adviezen te geven.", "Communicatievormen" },
                    { 7, 2, "Alle documenten zijn geschreven in correct Nederlands, zijn helder en duidelijk. ", "Correct Nederlands" },
                    { 8, 2, "Het scrum team denkt mee met de product owner (denk aan sprint planning). Het scrum team komt bijvoorbeeld met alternatieven voor wensen van de productowner die minder tijd kosten om te implementeren.", "Meedenken met PO" },
                    { 9, 3, "Alle gerealiseerde sprint backlog items zijn terug te vinden in het functioneel ontwerp. Denk onder andere aan een bijgewerkt domeinmodel en use case diagram. De uitgewerkte backlog items zijn in het functioneel ontwerp terug te vinden als uitgewerkte user-stories. Waar zinvol is het functioneel ontwerp ondersteunt met activiteitendiagrammen, toestandsdiagrammen en sequentiediagrammen.", "BLI in FO" },
                    { 10, 3, "Tijdens elke sprint wordt het ontwerp bijgewerkt. Denk bijvoorbeeld aan het toevoegen en/of uitbreiden van klassen in de verschillende klassendiagrammen. Belangrijke technische aspecten worden uitgelegd en ondersteund door (UML-)diagrammen.", "Bijwerken van ontwerp" },
                    { 11, 3, "Het functioneel ontwerp en het technisch ontwerp zijn volledig consistent met elkaar.", "Consistent FO en TO" },
                    { 12, 3, "Tijdens elke sprint wordt het ERD bijgewerkt (indien van toepassing). Keuzes voor het db-ontwerp (bijv. een extra index) worden toegelicht. De naamgeving van de tabellen en kollomen van de database zijn consistent met de naamgeving zoals gebruikt in het domeinmodel", "Bijgewerkt ERD" },
                    { 13, 3, "De gevolgde architectuur en ontwerpkeuzes zijn in het technisch ontwerp toegelicht en gemotiveerd.", "Toegelicht TO" },
                    { 14, 3, "In het ontwerp is alle benodige informatie opgenomen om een nieuw teamlid snel op weg te helpen met het realiseren van de software. Naast de eerder genoemde aspecten kun je daarbij ook denken aan het vermelden van gebruikte tools, frameworks en verwijzingingen naar bruikbaar studiemateriaal.", "Zelfstandig ontwerp" },
                    { 15, 3, "Voor ieder gerealiseerd item is een uitgebreide testset beschreven, waarmee de kwaliteit van de gerealiseerde software aangetoond kan worden.", "Testset voor ieder BLI" },
                    { 16, 4, "Alle broncode is op consistente wijze van commentaar voorzien.", "Comments" },
                    { 17, 4, "Code coventies zijn beschreven en nageleefd.", "Coding conventions" },
                    { 18, 4, "De code is consistent  met het opgestelde ontwerp.", "Consistentie" },
                    { 19, 4, "Er is een testprocedure beschreven waarin o.a. vastligt wie, wat en wanneer test.", "Testprocedure" },
                    { 20, 4, "De student rapporteert over unit-testen en overige testen.", "Testrapportage" },
                    { 21, 4, "Waar zinvol, zijn unit-testen toegepast.", "Unit tests" },
                    { 22, 4, "Alle namen in de code gebruiken een consistente vocabulair. Namen in de code beschrijven de intentie van de code.", "Self-documenting code" },
                    { 23, 4, "Formattering geeft een perfect inzicht in de beoogde structuur.", "Formatting" },
                    { 24, 4, "De code in methodes is voor de gewenste functionaliteit eenvoudig van opzet.", "Refactoring" },
                    { 25, 4, "De code is modulair opgezet en daardoor makkelijk te onderhouden, te lezen en te unit testen.", "Scalability" },
                    { 26, 5, "Tijdens elke Sprint Review wordt duidelijk aangegeven welke items in de sprint opgenomen zijn en welke items daarvan wel dan wel niet zijn gerealiseerd. Per gerealiseerd item wordt een demo gegeven.", "Opgenomen items in SR" },
                    { 27, 5, "Tijdens elke Sprint Review wordt de burn down chart besproken. Wat was de geplande velocity en waar is het team op uitgekomen?", "Besproken BDC in SR" },
                    { 28, 5, "Scrum stand-ups worden dagelijks en getimeboxed (bijv. max 15 minuten) uitgevoerd en zijn navolgbaar (foto’s, reflectie) voor de assessoren.", "Daily standup" },
                    { 29, 5, "Er is een geschikte tool en systematiek geselecteerd voor het managen van de product backlog items. Dit wordt in het reflectieverslag besproken.", "Tool voor BLI" },
                    { 30, 5, "Er is een geschikte tool en systematiek geselecteerd voor het samenwerken aan en het beheren van de broncode. Dit wordt in het reflectieverslag besproken.", "Version control system" },
                    { 31, 5, "Productbacklog items zijn in voldoende detail en consistent beschreven in de product backlog..", "Gedetaileerde BLI" },
                    { 32, 5, "Productbacklog items met een hoge prioriteit zijn al duidelijk verder uitgewerkt in vergelijking met items met een lage prioriteit.", "Geprioriteerde BLI" },
                    { 33, 5, "Zowel productbacklog items als sprintbacklog items zijn volledig afgestemd met de productowner.", "Afgestemde PBL en SBL" },
                    { 34, 5, "Bekende bugs worden geadminstreerd (bijvoorbeeld door ze op te nemen in de product backlog) en het oplossen hiervan heeft een plaats gekregen in het software ontwikkelproces", "Bug tracking" },
                    { 35, 5, "De retrospective is uitgevoerd en heeft (indien nodig) geleid tot aanpassingen op het proces.", "Retro" },
                    { 36, 5, "De Definition of Done is tot in voldoende detail uitgewerkt. (DoD bevat minimaal: Code Conventies, Testscenario’s, Documentatie-eisen, Acceptatiecriteria van de Product Owner)", "DoD" },
                    { 37, 5, "Er wordt na elke sprint een ready to release softwareproduct (overeenkomstig definition of done)  increment opgeleverd.", "Increment" },
                    { 38, 6, "Er is een gedetailleerde reflectie op de verbeterpunten uit de Retrospective beschreven. (Per student beschreven in ‘Professionele Ontwikkeling’)", "Reflectie op verbeteringspunten" },
                    { 39, 6, "Bij aanvang zijn realistische vakinhoudelijke en persoonlijke professionele leerdoelen SMART geformuleerd. (Per student beschreven in ‘Professionele Ontwikkeling’). De student is hier actief mee aan de gang gegaan.", "Leerdoelen" },
                    { 40, 6, "Het werken aan professionele ontwikkeling  en de resultaten hiervan zijn aan de hand van concrete voorbeelden geïllustreerd. (Per student beschreven in ‘Professionele Ontwikkeling’)", "Professionele Ontwikkeling" },
                    { 41, 6, "Er is inzicht in de eigen sterktes en zwaktes. (Per student beschreven in ‘Professionele Ontwikkeling’)", "Sterktes en zwaktes" },
                    { 42, 6, "Er is een gedetailleerde reflectie op alle hier genoemde competenties. De reflectie is per groep, waarbij de bijdrage van de individuele student goed naar voren komt.", "Reflectie" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Criteria",
                keyColumn: "CriterionId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "FormIndicators",
                keyColumns: new[] { "FormId", "IndicatorId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "FormIndicators",
                keyColumns: new[] { "FormId", "IndicatorId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "FormIndicators",
                keyColumns: new[] { "FormId", "IndicatorId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Competences",
                keyColumn: "CompetenceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Competences",
                keyColumn: "CompetenceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Competences",
                keyColumn: "CompetenceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Competences",
                keyColumn: "CompetenceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Competences",
                keyColumn: "CompetenceId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Competences",
                keyColumn: "CompetenceId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Indicators",
                keyColumn: "IndicatorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Indicators",
                keyColumn: "IndicatorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Indicators",
                keyColumn: "IndicatorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Forms",
                keyColumn: "FormId",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Forms",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
