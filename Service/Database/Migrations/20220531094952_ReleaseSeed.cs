using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service.Database.Migrations
{
    public partial class ReleaseSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Requirements",
                columns: new[] { "RequirementId", "CriterionId", "Description", "IndicatorId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Bereidt gesprekken niet voor. Koppelt niet terug aan betrokkenen. Maakt geen gebruik van UML of vergelijkbare diagrammen. Verdiept zich niet in het domein. Houdt geen rekening met niet-functionele eisen.", 1, null },
                    { 2, 1, "Bereidt gesprekken enigszins voor en koppelt in enige mate terug aan betrokkenen. Maakt gebruik van hooguit één soort diagram (bijv. domeinmodel of use case diagram). Verdiept zich enigszins in het domein, bijvoorbeeld door het bestuderen van vergelijkbare systemen. Houdt impliciet rekening met niet-functionele eisen.", 2, null },
                    { 3, 1, "Bereidt gesprekken goed voor en koppelt de resultaten terug aan betrokkenen Maakt gebruik van verschillende UML diagrammen om het probleem vanuit verschillende gezichtspunten te benaderen. Kiest de juiste diagrammen voor de context. Verdiept zich uitgebreid in het domein en gebruikt daarvoor verschillende bronnen. Houdt expliciet rekening met niet-functionele eisen.", 3, null },
                    { 4, 2, "De student voert de opdracht uit, echter zonder na te denken over de achterliggende probleemstelling.", 1, null },
                    { 5, 2, "De student is zich bewust van het onderliggende probleem voor de opdracht en legt dit vast.", 2, null },
                    { 6, 2, "De student werkt de business case uit en toont aan dat de gekozen oplossing daarmee in overeenstemming is. De student heeft alternatieven in overweging genomen en besproken met de opdrachtgever.", 3, null },
                    { 7, 3, "Het team is niet actief bezig met de product backlog.", 1, null },
                    { 8, 3, "Tijdens de sprint planning meetings, worden er veelvuldig nieuwe items vastgelegd. ", 2, null },
                    { 9, 3, "Tijdens de sprint planning meetings, worden er veelvuldig nieuwe items vastgelegd. De items worden tijdens en/of na de sprint planning meeting met de product owner besproken en afhankelijk van de prioriteit gedetailleerd.", 3, null },
                    { 10, 4, "Sprintbacklog items worden kort besproken tijdens een sprint planning meeting en op basis daarvan wordt een inschatting gemaakt voor de benodigde inspanning. Als een docent er naar vraagt, blijkt echter dat een ieder zijn eigen interpretatie geeft aan een item.", 1, null },
                    { 11, 4, "Sprintbacklog items worden  besproken tijdens een sprint planning. Diepgang ontbreekt echter nog.", 2, null },
                    { 12, 4, "Zowel product owner als teamleden weten voor ieder item nauwkeurig wat er gerealiseerd gaat worden. Onafhankelijk van elkaar zouden ze tot een vergelijkbare uitwerking komen. Tijdens de sprint planning meeting is er uitgebreid gebruik gemaakt van bijvoorbeeld het white board, om zaken duidelijk te maken, en alternatieven te bespreken. Het kan ook zijn dat items al eerder tot in voldoende detail zijn uitgewerkt, zodat deze minder aandacht behoeven tijdens de meeting.", 3, null },
                    { 13, 5, "Dit gebeurt niet.", 1, null },
                    { 14, 5, "De studenten informeren de product owner middels e-mail. Initiatief voor bespreken van heikele punten ligt nog voor een groot deel bij de product owner.", 2, null },
                    { 15, 5, "De studenten informeren de product owner gedurende de sprints. Verschillende communicatievormen worden gebruikt, zoals bijvoorbeeld telefoon en e-mail. Er is goed overlegd indien een item bijvoorbeeld te veel tijd dreigt te vragen of indien er alternatieven besproken dienen te worden.", 3, null },
                    { 16, 6, "Communicatie is hoofdzakelijk mondeling, tijdens de daarvoor geplande meetings.", 1, null },
                    { 17, 6, "Studenten gebruiken tijdens meetings meerdere zinvolle communicatiemiddelen.", 2, null },
                    { 18, 6, "Studenten gebruiken tijdens meetings meerdere zinvolle communicatiemiddelen en stimuleren elkaar en de product owner om input te geven. Incidenteel worden er demos (bijv. voorstel schermlay-out) voorbereid om advies te kunnen geven.", 3, null },
                    { 19, 7, "De documenten bevatten schrijffouten en zijn moeilijk te volgen.", 1, null },
                    { 20, 7, "De documenten bevatten nauwelijks schrijffouten. De documenten zijn duidelijk.", 2, null },
                    { 21, 7, "De documenten bevatten nauwelijks schrijffouten. De lezer wordt bij de hand genomen, de hoofd- en bijzaken worden heel goed onderscheiden.", 3, null },
                    { 22, 8, "De studenten leggen het initiatief volledig bij de product owner.", 1, null },
                    { 23, 8, "De studenten denken gevraagd en ongevraagd  mee met de product owner. Het team komt met alternatieven voor de product owner.", 2, null },
                    { 24, 8, "De studenten denken gevraagd en ongevraagd mee met de product owner. Alternatieven worden goed uitgelegd zodat de product owner een weloverwogen keuze kan maken. Tijdens sprint planning meetings zijn de studenten goed voorbereid zodat binnen de beschikbare tijd, alternatieven gepresenteerd kunnen worden.", 3, null },
                    { 25, 9, "Het domeinmodel en/of use case diagram ontbreken of zijn van slechte kwaliteit. Essentiele user-stories zijn niet volledig uitgewerkt.", 1, null },
                    { 26, 9, "Het domeinmodel en use case diagram zijn correct, consistent met elkaar, en zonodige opgesplitst in meerdere diagrammen. Alle essentiële user-stories zijn volledig uitgewerkt.", 2, null },
                    { 27, 9, "Een lezer krijgt op basis van het functioneel ontwerp snel inzicht in de geleverde functionaliteit. Het domeinmodel en use case diagram zijn correct, consistent met elkaar, en zonodig opgesplitst in meerdere diagrammen. Alle essentiële user-stories zijn volledig uitgewerkt.Triviale user-stories worden genoemd, maar niet tot in detail uitgewerkt. Waar zinvol is het functioneel ontwerp ondersteunt met activiteitendiagrammen, toestandsdiagrammen en sequentiediagrammen.", 3, null },
                    { 28, 10, "Wordt niet structureel gedaan.", 1, null },
                    { 29, 10, "Wordt structureel gedaan, maar beperkt zich tot hoofdlijnen.", 2, null },
                    { 30, 10, "Wordt structureel gedaan. Na afloop van iedere sprint is het ontwerp ook echt af, dus alle belangrijke tecnische aspecten worden meegenomen en niet uitgesteld tot de laatste sprint.", 3, null },
                    { 31, 11, "Het functioneel ontwerp en het technisch ontwerp zijn niet volledig en/of niet consistent met elkaar.", 1, null },
                    { 32, 11, "Het functioneel ontwerp en het technisch ontwerp zijn volledig en consistent met elkaar.", 2, null },
                    { 33, 11, "Het functioneel ontwerp en het technisch ontwerp zijn volledig en consistent met elkaar. Elementen uit functioneel ontwerp zijn eenvoudig te traceren in het technisch ontwerp, bijvoorbeeld door consistente naamgeving.", 3, null },
                    { 34, 12, "Het ERD is na afloop van een sprint niet consistent met de gerealiseerde database.", 1, null },
                    { 35, 12, "Het ERD is na afloop consistent met de gerealiseerde database. Keuzes voor het db-ontwerp (bijv. een extra index) worden toegelicht.", 2, null },
                    { 36, 12, "Het ERD is na afloop consistent met de gerealiseerde database. Keuzes voor het db-ontwerp (bijv. een extra index) worden toegelicht. De naamgeving van de tabellen en kollomen van de database zijn consistent met de naamgeving zoals gebruikt in het domeinmodel.", 3, null },
                    { 37, 13, "Het technisch ontwerp ondersteunt een ontwikkelaar niet of nauwelijks. Het technisch ontwerp bestaat dan bijvoorbeeld slechts uit een klassendiagram waarin alle klassen en relaties opgesomd worden.", 1, null },
                    { 38, 13, "Het technisch ontwerp laat duidelijk de architectuur van het systeem naar voren komen. Bijvoorbeeld door aan te geven welke klassen in welke systeemlagen zijn opgenomen. Essentiële ontwerpbeslissingen worden uitgelegd en ondersteund met UML-diagrammen.", 2, null },
                    { 39, 13, "Het technisch ontwerp laat duidelijk de architectuur van het systeem naar voren komen. Bijvoorbeeld door aan te geven welke klassen in welke systeemlagen zijn opgenomen. Essentiele ontwerpbeslissingen worden uitgelegd en ondersteund met UML-diagrammen. De lezer wordt bij de hand genomen door het ontwerp eerst op hoofdlijnen te schetsen en daarna in te zoomen op essentiële details.", 3, null },
                    { 40, 14, "Niet gedaan.", 1, null },
                    { 41, 14, "Summier gedaan, bijvoorbeeld slechts een opsomming gegeven van gebruikte tools en frameworks.", 2, null },
                    { 42, 14, "Alles wat een ontwikkelaar snel op weg kan helpen en relatief weinig tijd kost om te beschrijven, is in het ontwerp opgenomen. Denk bijvoorbeeld aan handleidingen voor frameworks waarnaar verwezen wordt, of bijvoorbeeld problemen met frameworks waar het team tegenaan gelopen is en de oplossing daarvoor.", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Requirements",
                columns: new[] { "RequirementId", "CriterionId", "Description", "IndicatorId", "Name" },
                values: new object[,]
                {
                    { 43, 15, "Niet voor alle gerealiseerde items is een testset beschreven.", 1, null },
                    { 44, 15, "Er zijn testscenario’s voor ieder item opgenomen. Er is echter geen rekening gehouden met ‘alle’ mogelijk scenario’s. Vaak wordt voor een item alleen het ‘happy day scenario’ beschreven.", 2, null },
                    { 45, 15, "Voor alle gerealiseerde items is een testset beschreven. Over de testsets is goed nagedacht, alle denkbare scenarios waarop een item problemen zou kunnen geven zijn opgenomen als testgeval. De kwaliteit van het systeem wordt hiermee goed geborgd.", 3, null },
                    { 46, 16, "Geen commentaar in broncode opgenomen.", 1, null },
                    { 47, 16, "Daar waar zinvol, commentaar opgenomen in broncode. Echter niet op consistente wijze.", 2, null },
                    { 48, 16, "Daar waar zinvol, commentaar opgenomen in broncode. Op consistente wijze gedaan.", 3, null },
                    { 49, 17, "Geen code conventies toegepast.", 1, null },
                    { 50, 17, "Code conventies toegepast, echter niet beschreven.", 2, null },
                    { 51, 17, "Code conventeis toegepast en beschreven.", 3, null },
                    { 52, 18, "Keuzes uit het ontwerp zijn niet terug te vinden in broncode.", 1, null },
                    { 53, 18, "Keuzes uit het ontwerp zijn terug te vinden in de broncode, alleen sluiten de gebruikte termen (bijv. klassennamen) niet goed op elkaar aan.", 2, null },
                    { 54, 18, "Keuzes uit het ontwerp zijn volledig en consistent gerealiseerd in broncode.", 3, null },
                    { 55, 19, "Geen testprocedure aanwezig.", 1, null },
                    { 56, 19, "Er is een testprocedure beschreven waarin vastligt wie, wat en wanneer test.", 2, null },
                    { 57, 19, "Testprocedure is uitgebreid beschreven (soorten testen, input voor evt. testers, manier waarop bugs gemeld worden, etcetera)", 3, null },
                    { 58, 20, "Geen testrapportage aanwezig", 1, null },
                    { 59, 20, "Testrapportage is globaal beschreven.", 2, null },
                    { 60, 20, "Uitgebreide testrapportage aanwezig. O.a. duidelijk wie, wat, wanneer getest heeft en welke bugs in welke stadia gevonden zijn.", 3, null },
                    { 61, 21, "Geen unit-testen toegepast, terwijl dit wel zinvol was geweest.", 1, null },
                    { 62, 21, "Incidenteel unit-test toegepast, echter niet voor alle code waarvoor dit zinvol zou zijn geweest.", 2, null },
                    { 63, 21, "Voor alle code waarvoor dit zinvol is, zijn unit-testen toegepast.", 3, null },
                    { 64, 22, "Niet alle namen beschrijven de intentie van de code correct.", 1, null },
                    { 65, 22, "Alle namen in de code beschrijven de intentie van de code, maar niet altijd compleet en ook niet altijd even consistent.", 2, null },
                    { 66, 22, "Alle namen in de code beschrijven de intentie van de code. Namen zijn compleet en consistent.", 3, null },
                    { 67, 23, "Formattering mist of regels zijn te lang om te lezen.", 1, null },
                    { 68, 23, "Inspringen , regelovergangen en het gebruik van haakjes gegeven een inzicht in de beoogde structuur.indentation, maar is niet consitent gedaan.", 2, null },
                    { 69, 23, "Inspringen , regelovergangen en het gebruik van haakjes gegeven een perfect inzicht in de beoogde structuur.", 3, null },
                    { 70, 24, "Methodes bevatten diep geneste code, controle structuren zijn misleidend voor de beoogde functionaliteit.", 1, null },
                    { 71, 24, "De code is eenvoudig en bevat weinig exceptions. De controle structuren en keuzes voor libraries is toepasselijk voor de gewenste functionaliteit.", 2, null },
                    { 72, 24, "De code is eenvoudig en bevat weinig exceptions. De controle structuren en keuzes voor libraries is toepasselijk voor de gewenste functionaliteit. De code laat het gewenste pad duidelijk tot uitdrukking komen.", 3, null },
                    { 73, 25, "De code is geschreven in enkele grote klassen en methodes. Sommige code komt vaker voor (copy paste).", 1, null },
                    { 74, 25, "De indeling in klassen en methodes maakt de code overzichtelijk, maar kan nog verder geoptimaliseerd worden. Dit blijkt bijvoorbeeld tijdens het schrijven van de unit testen.", 2, null },
                    { 75, 25, "De indeling in klassen en methodes maakt de code overzichtelijk en goed testbaar. Methodes voeren een zeer beperkt aantal taken uit. ", 3, null },
                    { 76, 26, "Er wordt een demo gegeven. Voor het publiek wordt niet expliciet  duidelijk gemaakt wat de items voor de sprint waren en wat daarvan al dan niet gerealiseerd is.", 1, null },
                    { 77, 26, "Er wordt een demo gegeven en enigszins duidelijk gemaakt wat de te realiseren items waren en wat daarvan gerealiseerd is.", 2, null },
                    { 78, 26, "Duidelijk overzicht van sprint items en hetgeen daarvan gerealiseerd is. Per item wordt een demo gegeven om aan te tonen dat het item gerealiseerd is.", 3, null },
                    { 79, 27, "De burn down chart wordt niet getoond. De geplande velocity en de gerealiseerde velocity komen niet ter sprake.", 1, null },
                    { 80, 27, "De burn down chart wordt getoond. De geplande en gerealiseerde velocity is duidelijk.", 2, null },
                    { 81, 27, "De geplande velocity wordt vermeld. De burn down chart is correct, wordt getoond en uitgelegd. Het team trekt conclusies.", 3, null },
                    { 82, 28, "Stand-ups worden niet dagelijks uitgevoerd.", 1, null },
                    { 83, 28, "Stand-ups zijn dagelijks uitgevoerd. Bewijslast is mager.", 2, null },
                    { 84, 28, "Stand-ups zijn dagelijks uitgevoerd. Bewijslast is geleverd. Uit de reflecties blijkt dat de studenten het nut van de stand-up goed doorgronden.", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Requirements",
                columns: new[] { "RequirementId", "CriterionId", "Description", "IndicatorId", "Name" },
                values: new object[,]
                {
                    { 85, 29, "Niet beschreven.", 1, null },
                    { 86, 29, "De motivatie voor de keuze voor een bepaald tool is beschreven of de systematiek is beschreven en gemotiveerd, maar niet beide.", 2, null },
                    { 87, 29, "De motivatie voor de keuze voor een bepaald tool is beschreven. Ook de systematiek is beschreven en gemotiveerd.", 3, null },
                    { 88, 30, "Niet beschreven.", 1, null },
                    { 89, 30, "De motivatie voor de keuze voor een bepaald tool is beschreven of de systematiek is beschreven en gemotiveerd, maar niet beide.", 2, null },
                    { 90, 30, "De motivatie voor de keuze voor een bepaald tool is beschreven. Ook de systematiek is beschreven en gemotiveerd.", 3, null },
                    { 91, 31, "Productbacklog items zijn beschreven, maar niet op een consistente wijze. Items zijn niet duidelijk beschreven.", 1, null },
                    { 92, 31, "Productbacklog items zijn consistent beschreven, maar nog niet altijd in voldoende detail om de intentie goed te begrijpen.", 2, null },
                    { 93, 31, "Productbacklog items zijn in voldoende detail en consistent beschreven in de product backlog. De intentie is voor alle betrokkenen goed te begrijpen.", 3, null },
                    { 94, 32, "Er is geen verschil te onderkennen in detaillering.", 1, null },
                    { 95, 32, "Soms zijn items met een hoge prioriteit al verder in detail uitgewerkt. Dit gebeurt echter nog niet structureel.", 2, null },
                    { 96, 32, "Productbacklog items met een hoge prioriteit zijn al duidelijk verder uitgewerkt in vergelijking met items met een lage prioriteit. Dit heeft continue de aandacht van het team.", 3, null },
                    { 97, 33, "Afstemming vind buiten de sprint planning meetings niet plaats. Zelfs tijdens de meetings komt dit nauwelijks aan bod. Soms weet de product owner of teamleden niet wat de bedoeling van een item is of wordt deze verschillend geïnterpreteerd", 1, null },
                    { 98, 33, "Afstemming vind plaats, bijvoorbeeld door na afloop van een meeting een overzicht aan de product owner te versturen. Echte afstemming vind echter niet plaats. Soms interpreteert de product owner een item nog anders dan het team.", 2, null },
                    { 99, 33, "Zowel de product owner als de teamleden weten precies te vertellen wat een item inhoudt. Afstemming van items vind ook buiten de meetings om plaats.", 3, null },
                    { 100, 34, "Bugs worden niet geadministreerd.", 1, null },
                    { 101, 34, "Bugs worden geadministreert, maar het oplossen hiervan heeft niet een duidelijk plaats gekregen in het software ontwikkelproces.", 2, null },
                    { 102, 34, "Bekende bugs worden geadminstreerd (bijvoorbeeld door ze op te nemen in de product backlog) en het oplossen hiervan heeft een plaats gekregen in het software ontwikkelproces. De product owner bepaald de prioriteit van het oplossen van de bugs. Er kan prioriteit gegeven worden aan het toevoegen van nieuwe functionaliteit, boven het oplossen van een bug.", 3, null },
                    { 103, 35, "De retrospective is niet uitgevoerd.", 1, null },
                    { 104, 35, "De retrospective is na afloop van de laatste twee sprints uitgevoerd en heeft (indien nodig) geleid tot aanpassingen op het proces.", 2, null },
                    { 105, 35, "De retrospective is van het begin af aan uitgevoerd en heeft (indien nodig) geleid tot aanpassingen op het proces.", 3, null },
                    { 106, 36, "Er is geen definition of done.", 1, null },
                    { 107, 36, "Er is een standaard definition of done.", 2, null },
                    { 108, 36, "Feedback (bijvoorbeeld verkregen tijdens een retrospective)  is verwerkt in een aangepast definition of done.", 3, null },
                    { 109, 37, "Definition of done wordt niet gevolgd.", 1, null },
                    { 110, 37, "De definition of done wordt strict gevolgt. Tijdens de eerste sprint is dit nog niet helemaal gelukt", 2, null },
                    { 111, 37, "De definition of done wordt van het begin af aan strict gevolgd.", 3, null },
                    { 112, 38, "De student gaat hier niet op in.", 1, null },
                    { 113, 38, "De student reflecteert op de verbeteringen.", 2, null },
                    { 114, 38, "De student reflecteert op de verbeteringen en geeft duidelijk aan wat zijn of haar rol hierin is geweest.", 3, null },
                    { 115, 39, "De student is zijn leerdoelen uit het oog verloren.", 1, null },
                    { 116, 39, "De student is actief met de leerdoelen aan de slag gegaan. ", 2, null },
                    { 117, 39, "De student is actief met de leerdoelen aan de slag gegaan en reflecteerd hier uitgebreid op.", 3, null },
                    { 118, 40, "De student besteed hier geen aandacht aan.", 1, null },
                    { 119, 40, "De student beschrijft zijn professionele ontwikkeling.", 2, null },
                    { 120, 40, "De student beschrijft zijn professionele ontwikkeling. Uit de reflectie blijkt dat de student een project aangrijpt om voor zichzelf stappen te maken op het vlak van persoonlijke ontwikkeling.", 3, null },
                    { 121, 41, "De student besteed hier geen aandacht aan.", 1, null },
                    { 122, 41, "De student is zich bewust van zijn eigen sterktes en zwaktes en beschrijft deze in de reflectie.", 2, null },
                    { 123, 41, "De student is zich bewust van zijn eigen sterktes en zwaktes en beschrijft deze in de reflectie. De student geeft duidelijk aan hoe hij of zij in de toekomst de sterktes optimaal kan inzetten, en hoe hij of zij de zwaktes gaat opvangen en/of zich op deze punten gaat verbeteren.", 3, null },
                    { 124, 42, "Er wordt hoofdzakelijk beschreven wat er is opgeleverd.", 1, null },
                    { 125, 42, "Er wordt beschreven wat er is opgeleverd en wat de bijdrage is geweest van iedere student. Op gemaakte keuzes wordt gereflecteerd. Studenten laten zien dat ze weten wat hun ontwikkelpunten nog zijn. Diepgang en bewijsmateriaal is mager.", 2, null },
                    { 126, 42, "Er wordt een gedetailleerde reflectie opgeleverd, compleet met bewijsmateriaal (zoals bijv. foto’s van meetings met gevuld white board). Op gemaakte keuzes wordt gereflecteerd. Studenten laten zien dat ze weten wat hun ontwikkelpunten nog zijn. De studenten nemen hun eigen handelen kritisch onder de loep. Een docent die niet bij het project betrokken is geweest, kan op basis van de reflectie een gefundeerde, individuele beoordeling geven.", 3, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Requirements",
                keyColumn: "RequirementId",
                keyValue: 126);

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
                table: "Forms",
                keyColumn: "FormId",
                keyValue: 1);
        }
    }
}
