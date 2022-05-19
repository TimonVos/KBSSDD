using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service.Database.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Name", "Number" },
                values: new object[,]
                {
                    { 1, "Durgan LLC", 6 },
                    { 2, "Sauer, Hegmann and Quigley", 4 },
                    { 3, "Mann, Ullrich and Haley", 5 },
                    { 4, "Fadel-Bailey", 5 },
                    { 5, "Renner-Lind", 5 },
                    { 6, "Ward Group", 4 },
                    { 7, "Bailey Group", 1 },
                    { 8, "McDermott-Sanford", 1 },
                    { 9, "Torp, Waters and Keeling", 6 },
                    { 10, "Skiles-Gibson", 3 },
                    { 11, "Kihn-Cartwright", 2 },
                    { 12, "Ryan LLC", 4 },
                    { 13, "Welch-Goldner", 5 },
                    { 14, "Dare LLC", 2 },
                    { 15, "Schinner Inc and Sons", 5 },
                    { 16, "Harris LLC", 1 },
                    { 17, "Quigley Group", 1 },
                    { 18, "Price, Wuckert and Metz", 3 },
                    { 19, "Durgan Inc and Sons", 4 },
                    { 20, "O'Hara, Von and Ferry", 2 },
                    { 21, "Quigley-Friesen", 5 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115000, "Ella Barrows" },
                    { 115002, "Mrs. Marlene Jerde Jr." },
                    { 115005, "Bruce Feil" },
                    { 115013, "Creola Ralph Kreiger DDS" },
                    { 115018, "Dr. Hassie Shields" },
                    { 115025, "Mr. Madonna Philip Osinski" },
                    { 115032, "Gertrude Pollich" },
                    { 115033, "Ms. Izaiah Eichmann" },
                    { 115044, "Taylor McKenzie" },
                    { 115046, "Bret Lavina Wolff Jr." },
                    { 115055, "Prof. Precious Mohr Jr." },
                    { 115056, "Jayce Schoen" },
                    { 115059, "Dr. Candice Ward II" },
                    { 115060, "Raina Quitzon" },
                    { 115064, "Sammie Breitenberg" },
                    { 115066, "Prof. Fredy Conor Block IV" },
                    { 115073, "Bria Gutkowski" },
                    { 115076, "Ardith Johns" },
                    { 115079, "Brennon Kilback V" },
                    { 115087, "Prof. Anya Jordon Kihn" },
                    { 115091, "Mr. Savanah Florida Predovic" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115106, "Megane Schuster" },
                    { 115114, "Jayda Stroman" },
                    { 115115, "Moses Pagac" },
                    { 115124, "Ms. Brook Johns" },
                    { 115125, "Karley Marks" },
                    { 115127, "Susanna Walker" },
                    { 115128, "Danika Crona" },
                    { 115131, "Jayson Hoppe" },
                    { 115133, "Nolan Schamberger" },
                    { 115136, "Oleta Cruickshank" },
                    { 115138, "Antwan Rey Carroll III" },
                    { 115139, "Mrs. Esmeralda Kathleen Huels II" },
                    { 115147, "Prof. Sierra Hyatt" },
                    { 115153, "Efrain Mills" },
                    { 115160, "Miss Kobe Tyson Homenick MD" },
                    { 115165, "Shayna Gerlach MD" },
                    { 115172, "Sedrick Matteo Beier DVM" },
                    { 115176, "Cullen Weissnat" },
                    { 115181, "Lottie Norma Reinger IV" },
                    { 115194, "Deven Bergnaum" },
                    { 115195, "Prof. Lucie Giles Daniel" },
                    { 115196, "Mrs. Mikel Halvorson DVM" },
                    { 115198, "Mrs. Tressa Ambrose Crist" },
                    { 115201, "Jonathan Mosciski" },
                    { 115212, "Hertha Mosciski" },
                    { 115213, "Darron Gislason" },
                    { 115214, "Guadalupe Turner" },
                    { 115216, "Dr. Melisa Conrad Lemke" },
                    { 115218, "Trystan Marvin" },
                    { 115221, "Eleazar Hermann" },
                    { 115225, "Dr. Kristin Kemmer" },
                    { 115228, "Russ Prohaska" },
                    { 115235, "Elton Tyler Prosacco III" },
                    { 115252, "Jennyfer Langosh" },
                    { 115257, "Ms. Gunner Alexanne Gorczany Jr." },
                    { 115259, "Savion Kiehn" },
                    { 115261, "Miss Gilbert Finn Little" },
                    { 115264, "Shaniya Treutel" },
                    { 115281, "Lowell Hodkiewicz" },
                    { 115282, "Sammie DuBuque" },
                    { 115288, "Kendrick Alden Kulas III" },
                    { 115298, "Kenny Trinity Mraz I" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115299, "Hans Doyle DVM" },
                    { 115304, "Reanna Hermann MD" },
                    { 115309, "Woodrow Torphy Jr." },
                    { 115314, "Sasha Willms" },
                    { 115318, "Gerry Heaney IV" },
                    { 115328, "Carmelo Hodkiewicz" },
                    { 115342, "Dax Von" },
                    { 115350, "Bessie Prudence Bartell Jr." },
                    { 115352, "Linnea Upton" },
                    { 115365, "Stephania Hintz" },
                    { 115370, "Ervin Hyatt DVM" },
                    { 115373, "Asha Koss Jr." },
                    { 115375, "Mrs. Oda Franco Morissette MD" },
                    { 115378, "Mona Volkman" },
                    { 115379, "Jaydon Welch" },
                    { 115384, "Jade Breitenberg" },
                    { 115386, "Ms. Brisa Carole Frami III" },
                    { 115390, "Clinton Aufderhar" },
                    { 115408, "Brannon Sporer" }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 1, 115018 },
                    { 1, 115044 },
                    { 1, 115124 },
                    { 1, 115127 },
                    { 1, 115196 },
                    { 1, 115213 },
                    { 1, 115298 },
                    { 2, 115153 },
                    { 2, 115309 },
                    { 3, 115018 },
                    { 3, 115165 },
                    { 4, 115013 },
                    { 4, 115064 },
                    { 4, 115235 },
                    { 5, 115005 },
                    { 5, 115201 },
                    { 5, 115213 },
                    { 5, 115384 },
                    { 6, 115133 },
                    { 6, 115214 },
                    { 7, 115073 },
                    { 7, 115091 },
                    { 7, 115221 },
                    { 7, 115299 },
                    { 7, 115318 },
                    { 7, 115352 },
                    { 7, 115386 },
                    { 8, 115044 },
                    { 8, 115172 },
                    { 9, 115298 },
                    { 9, 115304 },
                    { 9, 115352 },
                    { 10, 115218 },
                    { 10, 115378 },
                    { 11, 115194 },
                    { 11, 115264 },
                    { 11, 115375 },
                    { 12, 115059 },
                    { 12, 115125 },
                    { 12, 115128 },
                    { 12, 115136 },
                    { 12, 115181 }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 12, 115228 },
                    { 13, 115059 },
                    { 13, 115127 },
                    { 13, 115138 },
                    { 13, 115176 },
                    { 13, 115194 },
                    { 13, 115198 },
                    { 13, 115221 },
                    { 13, 115257 },
                    { 14, 115056 },
                    { 14, 115064 },
                    { 14, 115091 },
                    { 14, 115165 },
                    { 14, 115342 },
                    { 15, 115252 },
                    { 15, 115386 },
                    { 16, 115025 },
                    { 16, 115046 },
                    { 16, 115073 },
                    { 16, 115350 },
                    { 17, 115139 },
                    { 17, 115194 },
                    { 17, 115214 },
                    { 17, 115299 },
                    { 18, 115013 },
                    { 18, 115147 },
                    { 18, 115181 },
                    { 18, 115288 },
                    { 18, 115299 },
                    { 18, 115342 },
                    { 19, 115018 },
                    { 19, 115046 },
                    { 20, 115127 },
                    { 20, 115131 },
                    { 20, 115261 },
                    { 20, 115384 },
                    { 21, 115114 },
                    { 21, 115131 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115018 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115044 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115124 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115127 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115196 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115213 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115298 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115153 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115309 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115018 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115165 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115013 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115064 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115235 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 5, 115005 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 5, 115201 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 5, 115213 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 5, 115384 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115133 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115214 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115073 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115091 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115221 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115299 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115318 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115352 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115386 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115044 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115172 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115298 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115304 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115352 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115218 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115378 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115194 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115264 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115375 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115059 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115125 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115128 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115136 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115181 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115228 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115059 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115127 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115138 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115176 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115194 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115198 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115221 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115257 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115056 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115064 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115091 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115165 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115342 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115252 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115386 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115025 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115046 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115073 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115350 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115139 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115194 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115214 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115299 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115013 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115147 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115181 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115288 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115299 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115342 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115018 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115046 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115127 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115131 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115261 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115384 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 21, 115114 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 21, 115131 });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115000);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115002);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115032);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115033);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115055);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115060);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115066);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115076);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115079);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115087);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115106);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115115);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115160);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115195);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115212);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115216);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115225);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115259);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115281);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115282);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115314);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115328);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115365);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115370);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115373);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115379);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115390);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115408);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115005);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115013);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115018);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115025);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115044);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115046);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115056);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115059);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115064);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115073);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115091);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115114);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115124);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115125);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115127);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115128);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115131);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115133);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115136);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115138);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115139);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115147);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115153);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115165);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115172);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115176);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115181);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115194);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115196);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115198);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115201);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115213);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115214);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115218);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115221);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115228);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115235);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115252);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115257);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115261);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115264);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115288);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115298);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115299);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115304);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115309);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115318);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115342);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115350);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115352);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115375);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115378);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115384);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115386);
        }
    }
}
