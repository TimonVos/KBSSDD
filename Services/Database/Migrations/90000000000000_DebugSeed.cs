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
                    { 1, "Labadie, Rolfson and Hahn", 2 },
                    { 2, "Hayes LLC", 6 },
                    { 3, "Ruecker-Mosciski", 2 },
                    { 4, "Wilderman Inc and Sons", 5 },
                    { 5, "DuBuque, Veum and Koepp", 4 },
                    { 6, "Russel, Hoeger and Steuber", 3 },
                    { 7, "Graham, Goldner and Casper", 3 },
                    { 8, "Shanahan-Fritsch", 5 },
                    { 9, "Heaney, Champlin and Keeling", 5 },
                    { 10, "Abbott-Jewess", 2 },
                    { 11, "Mueller, Morissette and Kris", 5 },
                    { 12, "Bernier LLC", 6 },
                    { 13, "Stamm-Runolfsson", 4 },
                    { 14, "Sipes Group", 3 },
                    { 15, "O'Hara, VonRueden and Dare", 3 },
                    { 16, "Trantow, Rosenbaum and Kohler", 6 },
                    { 17, "Hansen, Bernhard and Hammes", 3 },
                    { 18, "Hagenes-Bashirian", 6 },
                    { 19, "Conroy Inc and Sons", 3 },
                    { 20, "Dicki-Mitchell", 2 },
                    { 21, "Gottlieb-Osinski", 1 },
                    { 22, "Heaney LLC", 2 },
                    { 23, "Feest, Howell and Swift", 5 },
                    { 24, "Conroy, Hand and Jewess", 5 },
                    { 25, "Anderson-Goyette", 6 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115007, "Arch Blick III" },
                    { 115012, "Brionna McLaughlin" },
                    { 115018, "Mr. Kattie Blanche Emmerich" },
                    { 115019, "Ms. Elsa Aaron Stamm" },
                    { 115020, "Dr. Eliane Lance Cassin I" },
                    { 115023, "Prof. Dell Gianni Herman V" },
                    { 115039, "Anya Parker" },
                    { 115045, "Deonte Fritsch DDS" },
                    { 115046, "Ursula Margarita Koelpin IV" },
                    { 115047, "Donna Adolfo Larson Jr." },
                    { 115051, "Gus Marks" },
                    { 115052, "Astrid Daniel" },
                    { 115056, "Alva Elmo Gleason II" },
                    { 115057, "Prof. Wilhelm Mariana Legros PhD" },
                    { 115059, "Ms. Clarissa Rowe MD" },
                    { 115065, "Hobart Quigley" },
                    { 115071, "Elwin Bauch" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115076, "Katelin Maggio" },
                    { 115087, "Dominic Hoeger" },
                    { 115088, "Ms. Louvenia Simonis" },
                    { 115089, "Mr. Roslyn Beatty DVM" },
                    { 115091, "Ms. Lambert Ryan" },
                    { 115092, "Cierra Crist" },
                    { 115095, "Wilfredo Magnus Reynolds II" },
                    { 115101, "Kevin Dwight Quigley DVM" },
                    { 115102, "Ms. Queen Alyce Crooks" },
                    { 115103, "Etha Hermiston" },
                    { 115104, "Ms. Jaquelin Wilkinson" },
                    { 115106, "Kiarra Rath" },
                    { 115118, "Dr. Clay Samir Schuppe" },
                    { 115123, "Fiona Kassulke" },
                    { 115125, "Ms. Mariana Alf Walker II" },
                    { 115128, "Mrs. Alex McKenzie I" },
                    { 115134, "Cyrus Hilpert" },
                    { 115140, "Emilie Berge" },
                    { 115144, "Shawna Rowe" },
                    { 115145, "Ms. Jacques Milan Lakin II" },
                    { 115157, "Ms. Guadalupe Pauline Hansen" },
                    { 115158, "Dixie Schoen" },
                    { 115163, "Alanis Olson" },
                    { 115167, "Spencer Cummerata" },
                    { 115172, "Noemie Konopelski" },
                    { 115174, "Koby Walter" },
                    { 115176, "Doyle Block" },
                    { 115181, "Brenda Wunsch" },
                    { 115200, "Alexane Miller DVM" },
                    { 115218, "Mrs. Eve Sonya Becker DDS" },
                    { 115227, "Russ Armstrong" },
                    { 115230, "Rubye Heaney" },
                    { 115231, "Mrs. Gwendolyn Windler" },
                    { 115240, "Serena West" },
                    { 115248, "Mrs. Scotty Edna Runte" },
                    { 115252, "Miss Vickie Paucek" },
                    { 115256, "Domingo Little" },
                    { 115261, "Darien Gibson" },
                    { 115265, "Alessandro Frami" },
                    { 115272, "Kara Marianne Dickinson III" },
                    { 115283, "Prof. Elton Kameron D'Amore DDS" },
                    { 115288, "Mrs. Kaya Cortney Blick V" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115292, "Thaddeus Tia Hand PhD" },
                    { 115294, "Miss Jaida Kian Mante V" },
                    { 115299, "Hilario Kreiger" },
                    { 115302, "Ambrose Murazik III" },
                    { 115303, "Pierre Bruen" },
                    { 115308, "Dominic Nolan" },
                    { 115309, "Devan Kaitlyn Kiehn MD" },
                    { 115314, "Ronaldo Halvorson" },
                    { 115329, "Mrs. Bernard Jimmy Wintheiser MD" },
                    { 115337, "Miss Isidro Gonzalo Pfannerstill" },
                    { 115339, "Teagan Jace Grimes PhD" },
                    { 115342, "Muhammad Sporer" },
                    { 115345, "Myrtie Ritchie" },
                    { 115346, "Chanelle Lindgren" },
                    { 115350, "Louvenia Cole" },
                    { 115353, "Rey Kuphal" },
                    { 115367, "Selena Tate Wehner DDS" },
                    { 115368, "Terrance Kessler" },
                    { 115372, "Hope Kessler" },
                    { 115376, "Elvis Weimann" },
                    { 115380, "Dina Schimmel" },
                    { 115385, "Prof. Icie Bernita Connelly" },
                    { 115395, "Prof. Onie Natasha Corkery Jr." },
                    { 115397, "Prof. Kaycee Marks" },
                    { 115409, "Jazmyne Upton" },
                    { 115414, "Ms. Audra Ward DVM" },
                    { 115418, "Ally Sanford" },
                    { 115435, "Timmy Parisian" },
                    { 115438, "Matilde Christiansen" },
                    { 115442, "Antonette Schroeder" },
                    { 115444, "Jaqueline Rodriguez" },
                    { 115448, "Dr. Ludie Efrain Wunsch PhD" }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 1, 115052 },
                    { 1, 115056 },
                    { 1, 115118 },
                    { 1, 115134 },
                    { 1, 115145 },
                    { 1, 115157 },
                    { 1, 115339 },
                    { 1, 115350 },
                    { 2, 115020 },
                    { 2, 115047 },
                    { 2, 115088 },
                    { 2, 115103 },
                    { 2, 115118 },
                    { 2, 115125 },
                    { 2, 115292 },
                    { 2, 115367 },
                    { 3, 115007 },
                    { 3, 115140 },
                    { 3, 115283 },
                    { 3, 115303 },
                    { 3, 115367 },
                    { 3, 115385 },
                    { 4, 115039 },
                    { 4, 115047 },
                    { 4, 115200 },
                    { 4, 115218 },
                    { 4, 115292 },
                    { 4, 115409 },
                    { 4, 115418 },
                    { 5, 115288 },
                    { 5, 115438 },
                    { 6, 115023 },
                    { 6, 115059 },
                    { 6, 115089 },
                    { 6, 115303 },
                    { 6, 115368 },
                    { 6, 115385 },
                    { 7, 115045 },
                    { 7, 115056 },
                    { 7, 115104 },
                    { 7, 115230 },
                    { 7, 115372 }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 8, 115007 },
                    { 8, 115076 },
                    { 8, 115088 },
                    { 8, 115163 },
                    { 8, 115218 },
                    { 8, 115303 },
                    { 8, 115342 },
                    { 9, 115118 },
                    { 9, 115128 },
                    { 9, 115134 },
                    { 9, 115172 },
                    { 9, 115231 },
                    { 9, 115256 },
                    { 9, 115292 },
                    { 9, 115353 },
                    { 10, 115046 },
                    { 10, 115091 },
                    { 10, 115167 },
                    { 10, 115380 },
                    { 10, 115385 },
                    { 10, 115409 },
                    { 11, 115012 },
                    { 11, 115018 },
                    { 11, 115145 },
                    { 11, 115283 },
                    { 11, 115302 },
                    { 12, 115018 },
                    { 12, 115218 },
                    { 12, 115314 },
                    { 12, 115350 },
                    { 12, 115353 },
                    { 13, 115071 },
                    { 13, 115240 },
                    { 13, 115329 },
                    { 13, 115350 },
                    { 13, 115397 },
                    { 14, 115101 },
                    { 14, 115395 },
                    { 15, 115012 },
                    { 15, 115057 },
                    { 15, 115299 },
                    { 15, 115418 }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 16, 115125 },
                    { 16, 115385 },
                    { 17, 115051 },
                    { 17, 115227 },
                    { 17, 115248 },
                    { 17, 115385 },
                    { 17, 115435 },
                    { 18, 115134 },
                    { 18, 115174 },
                    { 18, 115200 },
                    { 18, 115283 },
                    { 18, 115288 },
                    { 18, 115329 },
                    { 18, 115376 },
                    { 18, 115414 },
                    { 19, 115039 },
                    { 19, 115059 },
                    { 19, 115174 },
                    { 19, 115227 },
                    { 19, 115252 },
                    { 19, 115292 },
                    { 19, 115302 },
                    { 19, 115329 },
                    { 20, 115007 },
                    { 20, 115134 },
                    { 20, 115376 },
                    { 20, 115409 },
                    { 21, 115056 },
                    { 21, 115144 },
                    { 21, 115218 },
                    { 21, 115395 },
                    { 22, 115076 },
                    { 22, 115102 },
                    { 22, 115174 },
                    { 22, 115248 },
                    { 22, 115292 },
                    { 23, 115176 },
                    { 23, 115418 },
                    { 24, 115007 },
                    { 24, 115039 },
                    { 24, 115103 },
                    { 24, 115157 }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 24, 115283 },
                    { 24, 115302 },
                    { 24, 115303 },
                    { 24, 115337 },
                    { 25, 115018 },
                    { 25, 115023 },
                    { 25, 115051 },
                    { 25, 115181 },
                    { 25, 115265 },
                    { 25, 115367 },
                    { 25, 115368 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115052 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115056 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115118 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115134 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115145 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115157 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115339 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115350 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115020 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115047 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115088 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115103 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115118 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115125 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115292 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115367 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115007 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115140 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115283 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115303 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115367 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115385 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115039 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115047 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115200 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115218 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115292 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115409 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115418 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 5, 115288 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 5, 115438 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115023 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115059 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115089 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115303 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115368 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115385 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115045 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115056 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115104 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115230 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115372 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115007 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115076 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115088 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115163 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115218 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115303 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115342 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115118 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115128 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115134 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115172 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115231 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115256 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115292 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115353 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115046 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115091 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115167 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115380 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115385 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115409 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115012 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115018 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115145 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115283 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115302 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115018 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115218 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115314 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115350 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115353 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115071 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115240 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115329 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115350 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115397 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115101 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115395 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115012 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115057 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115299 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115418 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115125 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115385 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115051 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115227 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115248 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115385 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115435 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115134 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115174 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115200 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115283 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115288 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115329 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115376 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115414 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115039 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115059 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115174 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115227 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115252 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115292 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115302 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115329 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115007 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115134 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115376 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115409 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 21, 115056 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 21, 115144 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 21, 115218 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 21, 115395 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115076 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115102 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115174 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115248 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115292 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 23, 115176 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 23, 115418 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115007 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115039 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115103 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115157 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115283 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115302 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115303 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115337 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115018 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115023 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115051 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115181 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115265 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115367 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115368 });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115019);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115065);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115087);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115092);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115095);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115106);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115123);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115158);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115261);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115272);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115294);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115308);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115309);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115345);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115346);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115442);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115444);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115448);

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
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115007);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115012);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115018);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115020);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115023);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115039);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115045);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115046);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115047);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115051);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115052);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115056);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115057);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115059);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115071);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115076);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115088);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115089);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115091);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115101);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115102);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115103);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115104);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115118);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115125);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115128);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115134);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115140);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115144);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115145);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115157);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115163);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115167);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115172);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115174);

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
                keyValue: 115200);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115218);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115227);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115230);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115231);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115240);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115248);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115252);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115256);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115265);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115283);

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
                keyValue: 115299);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115302);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115303);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115314);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115329);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115337);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115339);

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
                keyValue: 115353);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115367);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115368);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115372);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115376);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115380);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115385);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115395);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115397);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115409);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115414);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115418);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115435);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115438);
        }
    }
}
