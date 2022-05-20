using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service.Database.Migrations
{
    public partial class DebugSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Name", "Number" },
                values: new object[,]
                {
                    { 1, "Bode LLC", 3 },
                    { 2, "Mraz, Kozey and Ebert", 2 },
                    { 3, "Kunze - Swift", 3 },
                    { 4, "Cruickshank, Wintheiser and Hills", 6 },
                    { 5, "Gutkowski Group", 2 },
                    { 6, "Kohler - Kessler", 1 },
                    { 7, "McDermott - Bode", 6 },
                    { 8, "Kerluke, Stanton and Mayert", 5 },
                    { 9, "Kemmer Group", 3 },
                    { 10, "Jacobi Group", 4 },
                    { 11, "MacGyver - Russel", 2 },
                    { 12, "Johnston and Sons", 3 },
                    { 13, "Luettgen - Howe", 4 },
                    { 14, "Krajcik, Bashirian and Corwin", 4 },
                    { 15, "Quitzon, Thiel and Trantow", 4 },
                    { 16, "Goldner and Sons", 2 },
                    { 17, "Barrows, Zulauf and Donnelly", 6 },
                    { 18, "Pfannerstill - Jenkins", 1 },
                    { 19, "Russel, Ortiz and Schimmel", 5 },
                    { 20, "Jacobi, West and Schimmel", 5 },
                    { 21, "Smitham Group", 5 },
                    { 22, "Mante, Prohaska and Klein", 5 },
                    { 23, "Ruecker - Gerlach", 2 },
                    { 24, "Skiles - Marks", 2 },
                    { 25, "O'Conner, Kassulke and Gorczany", 6 },
                    { 26, "Franecki - Little", 2 },
                    { 27, "Hoeger, Murray and Bradtke", 4 },
                    { 28, "Morissette and Sons", 1 },
                    { 29, "Nader - Weissnat", 4 },
                    { 30, "Cummings - Langosh", 5 },
                    { 31, "Toy LLC", 2 },
                    { 32, "Roberts and Sons", 4 },
                    { 33, "Jacobson Group", 5 },
                    { 34, "Wiegand, Goldner and Hettinger", 5 },
                    { 35, "Kiehn - Schulist", 6 },
                    { 36, "Keeling, Reichel and Lebsack", 5 }
                });

            migrationBuilder.InsertData(
                table: "Indicators",
                columns: new[] { "IndicatorId", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "Lead", 4 },
                    { 2, "HTTP", 4 },
                    { 3, "National", 10 },
                    { 4, "Awesome Steel Chair", 9 },
                    { 5, "Fantastic Granite Pants", 2 },
                    { 6, "Borders", 2 }
                });

            migrationBuilder.InsertData(
                table: "Indicators",
                columns: new[] { "IndicatorId", "Name", "Value" },
                values: new object[,]
                {
                    { 7, "Stravenue", 3 },
                    { 8, "Unbranded Granite Bike", 6 },
                    { 9, "maximize", 4 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115012, "Evangeline Hansen" },
                    { 115018, "Elsa Schinner" },
                    { 115037, "Reggie Kris" },
                    { 115052, "Jaydon Blanda" },
                    { 115055, "Emmie Fay" },
                    { 115068, "Rosemarie Pfeffer" },
                    { 115069, "Nikita Schuppe" },
                    { 115070, "Otis Kohler" },
                    { 115079, "Jacinto Corwin" },
                    { 115080, "Lavonne Buckridge" },
                    { 115081, "Cierra Schiller" },
                    { 115083, "Clifford Senger" },
                    { 115088, "Joshua Wisoky" },
                    { 115091, "Juwan Hintz" },
                    { 115100, "Carmelo Reynolds" },
                    { 115101, "Vanessa Klocko" },
                    { 115103, "Albertha Monahan" },
                    { 115108, "Curt Herman" },
                    { 115112, "Anita Hagenes" },
                    { 115118, "Taurean Hudson" },
                    { 115122, "Stella Erdman" },
                    { 115127, "Webster Lueilwitz" },
                    { 115129, "Alivia Gutkowski" },
                    { 115134, "Dimitri Stamm" },
                    { 115139, "Archibald Purdy" },
                    { 115142, "Hiram Turcotte" },
                    { 115143, "Ashlee Lindgren" },
                    { 115147, "Monica Goodwin" },
                    { 115148, "Eva Block" },
                    { 115154, "Velva Hackett" },
                    { 115163, "Oceane Adams" },
                    { 115170, "Carolanne Runte" },
                    { 115178, "Cletus Nolan" },
                    { 115189, "Rickey Watsica" },
                    { 115192, "Elmira Ratke" },
                    { 115193, "Danielle Nitzsche" },
                    { 115194, "Evangeline Baumbach" },
                    { 115200, "Columbus Legros" },
                    { 115201, "Mathew Fay" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115205, "Zita Beatty" },
                    { 115212, "Enrico Luettgen" },
                    { 115213, "Verda Daniel" },
                    { 115218, "Cristian Rosenbaum" },
                    { 115222, "Destini Mueller" },
                    { 115229, "Helmer Spencer" },
                    { 115233, "Sydnie Murazik" },
                    { 115237, "Breanne Miller" },
                    { 115255, "Ethan Altenwerth" },
                    { 115259, "Jammie Nikolaus" },
                    { 115260, "Modesto Deckow" },
                    { 115261, "Annamarie West" },
                    { 115265, "Katelynn Welch" },
                    { 115266, "Juliana Hane" },
                    { 115275, "Karolann Jacobi" },
                    { 115279, "Raven Spinka" },
                    { 115288, "Oran Wiegand" },
                    { 115292, "Porter Smith" },
                    { 115300, "Jules Braun" },
                    { 115302, "Kenna Gorczany" },
                    { 115312, "Kaleigh Leuschke" },
                    { 115326, "Jess Kessler" },
                    { 115328, "Tyson Haley" },
                    { 115331, "Lexi Hermann" },
                    { 115339, "Eric Dare" },
                    { 115344, "Kayley Schamberger" },
                    { 115345, "Reed Anderson" },
                    { 115348, "Maximo King" },
                    { 115350, "Royce Ledner" },
                    { 115352, "Damien Zieme" },
                    { 115358, "Leonie Nader" },
                    { 115363, "Selmer Grady" },
                    { 115366, "Freeda Lowe" },
                    { 115370, "Alaina Koepp" },
                    { 115382, "Adolph Nader" },
                    { 115410, "Lenny Little" },
                    { 115413, "Ewald Bosco" },
                    { 115419, "Maritza White" },
                    { 115426, "Kassandra Volkman" },
                    { 115433, "Sonny Leannon" },
                    { 115439, "Sincere Doyle" },
                    { 115444, "Margot Wisozk" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115447, "Ila Hudson" },
                    { 115449, "Foster Schmeler" },
                    { 115454, "Luigi Rogahn" },
                    { 115459, "Cleve Mitchell" },
                    { 115460, "Humberto O'Keefe" },
                    { 115464, "Geraldine Hackett" },
                    { 115468, "Kamille Orn" },
                    { 115471, "Lucius Johnson" },
                    { 115476, "Alfonso Schaden" },
                    { 115482, "Rowan Rippin" },
                    { 115483, "Madie Armstrong" },
                    { 115484, "Emmie Pollich" },
                    { 115488, "Judge Stroman" },
                    { 115489, "Emanuel Hand" },
                    { 115491, "Raymond Shanahan" },
                    { 115494, "Monica Rau" },
                    { 115501, "Leo Kling" },
                    { 115503, "Gwen Moen" },
                    { 115506, "Lazaro Murphy" },
                    { 115512, "Howell Legros" },
                    { 115515, "Nathan Runolfsdottir" },
                    { 115517, "Drake Breitenberg" },
                    { 115518, "Madisyn Fahey" },
                    { 115523, "Kody Hagenes" },
                    { 115527, "Isabel Morissette" }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 1, 115018 },
                    { 1, 115083 },
                    { 1, 115192 },
                    { 1, 115237 },
                    { 1, 115352 },
                    { 1, 115439 },
                    { 1, 115459 },
                    { 1, 115460 },
                    { 2, 115222 },
                    { 2, 115358 },
                    { 3, 115265 },
                    { 3, 115449 },
                    { 3, 115527 },
                    { 4, 115129 },
                    { 4, 115205 },
                    { 4, 115344 },
                    { 4, 115426 },
                    { 4, 115460 },
                    { 4, 115471 },
                    { 4, 115494 },
                    { 5, 115080 },
                    { 5, 115134 },
                    { 5, 115194 },
                    { 6, 115139 },
                    { 6, 115194 },
                    { 6, 115212 },
                    { 6, 115460 },
                    { 7, 115350 },
                    { 7, 115494 },
                    { 8, 115122 },
                    { 8, 115129 },
                    { 8, 115143 },
                    { 8, 115205 },
                    { 8, 115233 },
                    { 8, 115482 },
                    { 8, 115503 },
                    { 8, 115515 },
                    { 9, 115103 },
                    { 9, 115112 },
                    { 9, 115476 },
                    { 10, 115200 },
                    { 10, 115468 }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 11, 115070 },
                    { 11, 115108 },
                    { 11, 115122 },
                    { 11, 115194 },
                    { 11, 115459 },
                    { 12, 115080 },
                    { 12, 115112 },
                    { 12, 115255 },
                    { 12, 115265 },
                    { 12, 115449 },
                    { 12, 115491 },
                    { 12, 115527 },
                    { 13, 115080 },
                    { 13, 115154 },
                    { 13, 115275 },
                    { 13, 115288 },
                    { 13, 115449 },
                    { 14, 115292 },
                    { 14, 115382 },
                    { 14, 115501 },
                    { 15, 115055 },
                    { 15, 115068 },
                    { 15, 115083 },
                    { 15, 115103 },
                    { 15, 115233 },
                    { 16, 115134 },
                    { 16, 115143 },
                    { 16, 115275 },
                    { 17, 115143 },
                    { 17, 115237 },
                    { 17, 115261 },
                    { 17, 115339 },
                    { 17, 115363 },
                    { 17, 115366 },
                    { 17, 115484 },
                    { 17, 115523 },
                    { 18, 115143 },
                    { 18, 115218 },
                    { 18, 115350 },
                    { 18, 115410 },
                    { 18, 115449 },
                    { 18, 115527 }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 19, 115103 },
                    { 19, 115233 },
                    { 19, 115261 },
                    { 19, 115302 },
                    { 19, 115413 },
                    { 19, 115517 },
                    { 19, 115518 },
                    { 19, 115523 },
                    { 20, 115237 },
                    { 20, 115433 },
                    { 21, 115259 },
                    { 21, 115312 },
                    { 22, 115447 },
                    { 22, 115489 },
                    { 23, 115192 },
                    { 23, 115255 },
                    { 23, 115454 },
                    { 23, 115503 },
                    { 24, 115080 },
                    { 24, 115178 },
                    { 24, 115212 },
                    { 24, 115339 },
                    { 24, 115370 },
                    { 24, 115488 },
                    { 24, 115512 },
                    { 24, 115517 },
                    { 25, 115069 },
                    { 25, 115101 },
                    { 25, 115108 },
                    { 25, 115118 },
                    { 25, 115142 },
                    { 25, 115358 },
                    { 25, 115501 },
                    { 26, 115052 },
                    { 26, 115081 },
                    { 26, 115091 },
                    { 26, 115100 },
                    { 26, 115112 },
                    { 27, 115052 },
                    { 27, 115129 },
                    { 27, 115255 },
                    { 27, 115370 }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 28, 115127 },
                    { 28, 115213 },
                    { 28, 115444 },
                    { 28, 115460 },
                    { 28, 115512 },
                    { 29, 115079 },
                    { 29, 115112 },
                    { 29, 115178 },
                    { 29, 115339 },
                    { 29, 115459 },
                    { 30, 115080 },
                    { 30, 115484 },
                    { 31, 115100 },
                    { 31, 115108 },
                    { 31, 115143 },
                    { 31, 115471 },
                    { 32, 115139 },
                    { 32, 115194 },
                    { 32, 115468 },
                    { 32, 115483 },
                    { 32, 115506 },
                    { 33, 115139 },
                    { 33, 115143 },
                    { 33, 115426 },
                    { 33, 115464 },
                    { 34, 115052 },
                    { 34, 115255 },
                    { 35, 115148 },
                    { 35, 115170 },
                    { 35, 115192 },
                    { 35, 115201 },
                    { 35, 115260 },
                    { 35, 115261 },
                    { 35, 115410 },
                    { 35, 115506 },
                    { 36, 115091 },
                    { 36, 115288 }
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
                keyValues: new object[] { 1, 115083 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115192 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115237 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115352 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115439 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115459 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115460 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115222 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115358 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115265 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115449 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115527 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115129 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115205 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115344 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115426 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115460 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115471 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115494 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 5, 115080 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 5, 115134 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 5, 115194 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115139 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115194 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115212 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115460 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115350 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115494 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115122 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115129 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115143 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115205 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115233 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115482 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115503 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115515 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115103 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115112 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115476 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115200 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115468 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115070 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115108 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115122 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115194 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115459 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115080 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115112 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115255 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115265 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115449 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115491 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115527 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115080 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115154 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115275 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115288 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115449 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115292 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115382 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115501 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115055 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115068 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115083 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115103 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115233 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115134 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115143 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115275 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115143 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115237 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115261 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115339 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115363 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115366 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115484 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115523 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115143 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115218 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115350 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115410 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115449 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115527 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115103 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115233 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115261 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115302 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115413 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115517 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115518 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115523 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115237 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115433 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 21, 115259 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 21, 115312 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115447 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115489 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 23, 115192 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 23, 115255 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 23, 115454 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 23, 115503 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115080 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115178 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115212 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115339 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115370 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115488 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115512 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115517 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115069 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115101 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115108 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115118 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115142 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115358 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115501 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 26, 115052 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 26, 115081 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 26, 115091 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 26, 115100 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 26, 115112 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 27, 115052 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 27, 115129 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 27, 115255 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 27, 115370 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 28, 115127 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 28, 115213 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 28, 115444 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 28, 115460 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 28, 115512 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 29, 115079 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 29, 115112 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 29, 115178 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 29, 115339 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 29, 115459 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 30, 115080 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 30, 115484 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 31, 115100 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 31, 115108 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 31, 115143 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 31, 115471 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 32, 115139 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 32, 115194 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 32, 115468 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 32, 115483 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 32, 115506 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 33, 115139 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 33, 115143 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 33, 115426 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 33, 115464 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 34, 115052 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 34, 115255 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115148 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115170 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115192 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115201 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115260 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115261 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115410 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115506 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 36, 115091 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 36, 115288 });

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
                table: "Indicators",
                keyColumn: "IndicatorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Indicators",
                keyColumn: "IndicatorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Indicators",
                keyColumn: "IndicatorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Indicators",
                keyColumn: "IndicatorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Indicators",
                keyColumn: "IndicatorId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Indicators",
                keyColumn: "IndicatorId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115012);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115037);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115088);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115147);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115163);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115189);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115193);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115229);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115266);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115279);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115300);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115326);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115328);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115331);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115345);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115348);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115419);

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
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115018);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115052);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115055);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115068);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115069);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115070);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115079);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115080);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115081);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115083);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115091);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115100);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115101);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115103);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115108);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115112);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115118);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115122);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115127);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115129);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115134);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115139);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115142);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115143);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115148);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115154);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115170);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115178);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115192);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115194);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115200);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115201);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115205);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115212);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115213);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115218);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115222);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115233);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115237);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115255);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115259);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115260);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115261);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115265);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115275);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115288);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115292);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115302);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115312);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115339);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115344);

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
                keyValue: 115358);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115363);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115366);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115370);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115382);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115410);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115413);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115426);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115433);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115439);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115444);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115447);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115449);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115454);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115459);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115460);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115464);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115468);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115471);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115476);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115482);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115483);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115484);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115488);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115489);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115491);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115494);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115501);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115503);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115506);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115512);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115515);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115517);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115518);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115523);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115527);
        }
    }
}
