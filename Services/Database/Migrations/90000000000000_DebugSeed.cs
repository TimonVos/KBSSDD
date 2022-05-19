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
                    { 1, "Champlin, Franecki and Leannon", 4 },
                    { 2, "Bogisich, Hahn and Metz", 1 },
                    { 3, "Howell Group", 5 },
                    { 4, "Breitenberg Inc and Sons", 2 },
                    { 5, "Herzog, Brekke and Bahringer", 5 },
                    { 6, "Auer-Pouros", 2 },
                    { 7, "Treutel LLC", 2 },
                    { 8, "Denesik, Wintheiser and Trantow", 1 },
                    { 9, "Cruickshank LLC", 6 },
                    { 10, "Schultz Inc and Sons", 2 },
                    { 11, "Stokes-Heller", 4 },
                    { 12, "Rosenbaum Group", 5 },
                    { 13, "Langosh Group", 6 },
                    { 14, "Hettinger Group", 4 },
                    { 15, "Wunsch-Bailey", 6 },
                    { 16, "Shanahan, Lakin and Klocko", 3 },
                    { 17, "Herzog-Sawayn", 5 },
                    { 18, "Jacobson, Hauck and Schimmel", 4 },
                    { 19, "Rodriguez Group", 4 },
                    { 20, "Muller-Konopelski", 4 },
                    { 21, "Schowalter-Barton", 2 },
                    { 22, "Swaniawski, Grant and Abernathy", 5 },
                    { 23, "Larson, Collier and Bergstrom", 5 },
                    { 24, "Wisoky, D'Amore and Lowe", 4 },
                    { 25, "Huels, Fay and Bayer", 5 },
                    { 26, "Deckow Group", 5 },
                    { 27, "Bernhard, Schultz and Stracke", 5 },
                    { 28, "Cormier Group", 4 },
                    { 29, "Rice, Gottlieb and Jaskolski", 1 },
                    { 30, "Kautzer Group", 6 },
                    { 31, "Bradtke, Schuppe and Mann", 2 },
                    { 32, "Keeling-Waters", 4 },
                    { 33, "McCullough-Yost", 4 },
                    { 34, "Zulauf-Feeney", 3 },
                    { 35, "Mohr, Cronin and Hagenes", 4 },
                    { 36, "Crooks Inc and Sons", 6 },
                    { 37, "Heaney, Schaefer and Grimes", 1 },
                    { 38, "Harvey-Breitenberg", 2 },
                    { 39, "Durgan, Mertz and Schmidt", 1 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115001, "Dejah Quitzon" },
                    { 115004, "Nigel Thiel" },
                    { 115007, "Bettye Jacobs" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115009, "Hudson Hilpert" },
                    { 115012, "Billie Hahn" },
                    { 115023, "Ms. Jadyn Jamar Ratke" },
                    { 115027, "Johan Heidenreich Sr." },
                    { 115032, "Elmore Waters" },
                    { 115034, "Miss Dock Rocky Lubowitz Sr." },
                    { 115036, "Myles Ryleigh Christiansen PhD" },
                    { 115043, "Demario Heidenreich" },
                    { 115045, "Jerrell Hodkiewicz I" },
                    { 115047, "Korbin Maggio" },
                    { 115058, "Glen Harris" },
                    { 115076, "Omer O'Hara" },
                    { 115079, "Nat Pattie Cruickshank I" },
                    { 115089, "Vesta Von" },
                    { 115095, "Ms. Kattie Wilkinson" },
                    { 115096, "Mr. Veda Cartwright Sr." },
                    { 115107, "Prof. Vallie Kenna Gutkowski II" },
                    { 115108, "Isai Champlin" },
                    { 115113, "Taya Leffler" },
                    { 115121, "Mrs. Gust Schmitt" },
                    { 115125, "Marcelle Durgan" },
                    { 115129, "Andrew Schulist PhD" },
                    { 115130, "Natalia Donnelly" },
                    { 115138, "Vaughn Stracke" },
                    { 115141, "Dr. Dianna Ziemann" },
                    { 115143, "Sienna Ziemann" },
                    { 115144, "Constantin Aisha Kerluke Jr." },
                    { 115154, "Edgardo Heathcote" },
                    { 115161, "Ms. Timmy Schneider" },
                    { 115165, "Ms. Malachi Brenden Fadel Sr." },
                    { 115166, "Emily Jakubowski Jr." },
                    { 115169, "Prof. Karianne Mason Harber" },
                    { 115170, "Floy Bartell" },
                    { 115180, "Emiliano Mosciski" },
                    { 115185, "Savannah Anderson" },
                    { 115194, "Korbin Roberts" },
                    { 115200, "Mr. Fausto Davis" },
                    { 115204, "Dr. Filomena Prohaska DVM" },
                    { 115211, "Isabel Metz" },
                    { 115212, "Prof. Allene Timothy McClure DDS" },
                    { 115215, "Andres Stokes" },
                    { 115216, "Loyce Casper V" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115220, "Claudine Feil" },
                    { 115221, "Emilie Bode" },
                    { 115225, "Delia Cummerata" },
                    { 115233, "Joanny Lindgren Sr." },
                    { 115234, "Prof. Toby O'Keefe DDS" },
                    { 115235, "Lauryn Altenwerth" },
                    { 115246, "Dayne Metz" },
                    { 115248, "Karli Ratke" },
                    { 115253, "Kenya White" },
                    { 115255, "Isobel Pollich" },
                    { 115256, "Ms. Brenna Roosevelt West II" },
                    { 115261, "Mylene Ledner" },
                    { 115264, "Dr. Devante O'Reilly" },
                    { 115266, "Mr. Mazie Dibbert" },
                    { 115269, "Graciela Bayer" },
                    { 115270, "Ms. Allan Llewellyn Krajcik I" },
                    { 115272, "Sean Schuster" },
                    { 115279, "Mrs. Ashlynn Herman" },
                    { 115285, "Ms. Cathrine Garett Walter DVM" },
                    { 115286, "Prof. Earline Grant" },
                    { 115293, "Mrs. Craig Boyle IV" },
                    { 115302, "Daren Rau" },
                    { 115305, "Jordi Padberg" },
                    { 115306, "Dorothy Roberts" },
                    { 115307, "Ms. Kennith Justina Casper" },
                    { 115315, "Miss Luna Nola Herzog III" },
                    { 115317, "Zachary Bogisich" },
                    { 115324, "Mrs. Javon Witting" },
                    { 115329, "Orion Hauck" },
                    { 115334, "Harry Langworth DVM" },
                    { 115336, "Alfonzo Dayana O'Conner V" },
                    { 115341, "Karina Cormier" },
                    { 115344, "Margarett Metz" },
                    { 115349, "Brain Braun" },
                    { 115354, "Alysha Rowe" },
                    { 115357, "Gilberto Metz" },
                    { 115359, "Amara Marquardt" },
                    { 115365, "Cydney Tillman" },
                    { 115368, "Daija Bahringer" },
                    { 115372, "Minerva Williamson" },
                    { 115378, "Mrs. Gerry Orin Hamill" },
                    { 115390, "Ms. Shanel Morar II" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115397, "Mr. Arlo Funk" },
                    { 115401, "Vernie Parker" },
                    { 115413, "Dejuan Klein" },
                    { 115414, "Prof. Megane Funk" },
                    { 115422, "Prof. Gerda Josue Durgan Jr." },
                    { 115425, "Ms. Zachariah Hoeger" },
                    { 115430, "Rosemary Sanford" },
                    { 115437, "Marlene Rippin" },
                    { 115441, "Mrs. Judge Bode" },
                    { 115444, "Lyric Bernier" },
                    { 115454, "Prof. Alison Littel" },
                    { 115456, "Barrett Rempel" },
                    { 115457, "Gus Sauer" },
                    { 115466, "Madonna Murray" },
                    { 115475, "Miss Hiram Claudia Zboncak" },
                    { 115482, "Okey Kutch" },
                    { 115483, "Columbus Emard" },
                    { 115486, "Gabe Schaefer" },
                    { 115494, "Matt Weimann" },
                    { 115498, "Velda Hortense Murazik IV" },
                    { 115500, "Ms. Mattie Aidan Turner II" },
                    { 115508, "Edwina Schoen" },
                    { 115537, "Miss Noemie Hodkiewicz" },
                    { 115538, "Prof. Lynn Torrey Sawayn DDS" },
                    { 115540, "Berry Schultz" },
                    { 115542, "Davon Connelly" },
                    { 115554, "Jerald Larson" },
                    { 115563, "Loyal Streich" },
                    { 115566, "Annamarie Howe" },
                    { 115573, "Birdie McGlynn" },
                    { 115585, "Mrs. Rosemary Osborne Rogahn" },
                    { 115587, "Prof. Kamron Graham V" },
                    { 115588, "Mr. Frederic Taya Legros" },
                    { 115598, "Marquis Rohan" },
                    { 115599, "Mrs. Bella Lauren Wiza IV" },
                    { 115609, "Evans Parker" },
                    { 115612, "Pete Catherine Bruen V" },
                    { 115613, "Mr. Jayson Virgie Mitchell" },
                    { 115614, "Marcelle Rice" },
                    { 115619, "Lucious Ebert" },
                    { 115620, "Robin Friesen" },
                    { 115631, "Aryanna Will" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115638, "Julie Kutch" },
                    { 115644, "Damon Smith" },
                    { 115650, "Vilma Ziemann V" },
                    { 115663, "Aubree Gusikowski" },
                    { 115669, "Baron Toy" },
                    { 115670, "Annamae Torphy" },
                    { 115674, "Hyman Turcotte" },
                    { 115687, "Jordyn Spencer" },
                    { 115703, "Mrs. Myriam Hal Schuster I" },
                    { 115708, "Hank Nicolas" },
                    { 115709, "Mr. Colton Connelly DDS" },
                    { 115711, "Dr. Brando Glenda Casper Jr." },
                    { 115731, "Ms. Mark Hyatt" },
                    { 115732, "Ray Block PhD" },
                    { 115736, "Leone Mueller" },
                    { 115737, "Amani Howell" },
                    { 115741, "Junior Aylin Wintheiser I" },
                    { 115760, "Laisha Bartell" },
                    { 115763, "Frieda Huels" },
                    { 115765, "Dr. Justyn Sheldon Kuhic" },
                    { 115769, "Fabian O'Kon" },
                    { 115770, "Mr. Tanya Morar" },
                    { 115773, "Melany Cartwright MD" },
                    { 115781, "Chaz Gusikowski" },
                    { 115782, "Dr. Michaela Swift DVM" },
                    { 115785, "Narciso Greenfelder" },
                    { 115786, "Dane Smitham" },
                    { 115789, "Ms. Alan McClure" },
                    { 115792, "Marisol Nitzsche" },
                    { 115793, "Dock Friesen" },
                    { 115799, "Lou Morissette" },
                    { 115810, "Elwyn Abshire" },
                    { 115816, "Sanford Fritsch" },
                    { 115823, "Rosalind Russel" },
                    { 115832, "Hester D'Amore" },
                    { 115834, "Miss Laney Parker DDS" },
                    { 115840, "Orpha Hoppe" },
                    { 115846, "Noble Padberg" },
                    { 115855, "Arturo Ziemann" },
                    { 115864, "Faustino Bernier" },
                    { 115868, "Mrs. Kristian Hailie Haley" },
                    { 115873, "Mrs. Marilie Grant Bechtelar" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentNumber", "Name" },
                values: new object[,]
                {
                    { 115874, "Prof. Leslie Jessie Carroll PhD" },
                    { 115879, "Gretchen Jamarcus Carroll II" },
                    { 115882, "Mr. Tyrique Margot Raynor" },
                    { 115883, "Millie Ferry" },
                    { 115887, "Fanny Ullrich" },
                    { 115889, "Mariano Sheridan Corwin III" },
                    { 115896, "Titus Kuvalis" },
                    { 115899, "Miss Ocie Jakubowski IV" },
                    { 115903, "Alexanne Stamm" },
                    { 115906, "Flo Genesis Collier PhD" },
                    { 115909, "Anthony Bartell" }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 1, 115058 },
                    { 1, 115341 },
                    { 1, 115401 },
                    { 1, 115425 },
                    { 1, 115457 },
                    { 1, 115483 },
                    { 1, 115554 },
                    { 1, 115846 },
                    { 2, 115307 },
                    { 2, 115444 },
                    { 2, 115899 },
                    { 3, 115023 },
                    { 3, 115269 },
                    { 3, 115609 },
                    { 3, 115670 },
                    { 3, 115711 },
                    { 3, 115769 },
                    { 3, 115873 },
                    { 3, 115903 },
                    { 4, 115194 },
                    { 4, 115248 },
                    { 4, 115413 },
                    { 4, 115873 },
                    { 5, 115095 },
                    { 5, 115264 },
                    { 5, 115770 },
                    { 6, 115317 },
                    { 6, 115401 },
                    { 6, 115425 },
                    { 6, 115482 },
                    { 7, 115001 },
                    { 7, 115027 },
                    { 7, 115096 },
                    { 7, 115154 },
                    { 7, 115246 },
                    { 7, 115272 },
                    { 7, 115315 },
                    { 7, 115482 },
                    { 8, 115036 },
                    { 8, 115058 },
                    { 8, 115349 },
                    { 8, 115500 }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 8, 115566 },
                    { 8, 115614 },
                    { 8, 115864 },
                    { 9, 115138 },
                    { 9, 115211 },
                    { 9, 115264 },
                    { 9, 115306 },
                    { 9, 115765 },
                    { 10, 115089 },
                    { 10, 115141 },
                    { 10, 115293 },
                    { 10, 115305 },
                    { 10, 115401 },
                    { 10, 115770 },
                    { 11, 115007 },
                    { 11, 115058 },
                    { 11, 115079 },
                    { 11, 115108 },
                    { 11, 115889 },
                    { 12, 115166 },
                    { 12, 115220 },
                    { 12, 115221 },
                    { 12, 115466 },
                    { 12, 115494 },
                    { 12, 115508 },
                    { 12, 115554 },
                    { 12, 115573 },
                    { 13, 115336 },
                    { 13, 115855 },
                    { 14, 115306 },
                    { 14, 115414 },
                    { 14, 115486 },
                    { 14, 115731 },
                    { 15, 115007 },
                    { 15, 115169 },
                    { 15, 115261 },
                    { 15, 115542 },
                    { 16, 115125 },
                    { 16, 115235 },
                    { 16, 115810 },
                    { 16, 115896 },
                    { 17, 115045 }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 17, 115058 },
                    { 17, 115185 },
                    { 17, 115454 },
                    { 17, 115846 },
                    { 18, 115012 },
                    { 18, 115154 },
                    { 18, 115253 },
                    { 18, 115494 },
                    { 18, 115598 },
                    { 18, 115816 },
                    { 19, 115004 },
                    { 19, 115185 },
                    { 19, 115269 },
                    { 19, 115286 },
                    { 19, 115475 },
                    { 19, 115619 },
                    { 19, 115741 },
                    { 19, 115879 },
                    { 20, 115154 },
                    { 20, 115264 },
                    { 20, 115482 },
                    { 20, 115770 },
                    { 20, 115899 },
                    { 21, 115211 },
                    { 21, 115264 },
                    { 21, 115736 },
                    { 21, 115883 },
                    { 22, 115121 },
                    { 22, 115141 },
                    { 22, 115279 },
                    { 22, 115365 },
                    { 22, 115500 },
                    { 22, 115588 },
                    { 22, 115614 },
                    { 22, 115674 },
                    { 23, 115007 },
                    { 23, 115113 },
                    { 23, 115422 },
                    { 23, 115540 },
                    { 23, 115619 },
                    { 23, 115840 },
                    { 24, 115143 }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 24, 115540 },
                    { 24, 115588 },
                    { 25, 115248 },
                    { 25, 115789 },
                    { 26, 115095 },
                    { 26, 115154 },
                    { 26, 115357 },
                    { 26, 115430 },
                    { 26, 115650 },
                    { 26, 115879 },
                    { 27, 115154 },
                    { 27, 115215 },
                    { 27, 115344 },
                    { 27, 115444 },
                    { 27, 115585 },
                    { 28, 115004 },
                    { 28, 115212 },
                    { 28, 115840 },
                    { 28, 115864 },
                    { 29, 115036 },
                    { 29, 115096 },
                    { 29, 115113 },
                    { 29, 115315 },
                    { 29, 115483 },
                    { 29, 115889 },
                    { 30, 115125 },
                    { 30, 115269 },
                    { 30, 115359 },
                    { 30, 115483 },
                    { 30, 115663 },
                    { 30, 115709 },
                    { 30, 115769 },
                    { 31, 115194 },
                    { 31, 115270 },
                    { 31, 115563 },
                    { 31, 115566 },
                    { 31, 115792 },
                    { 31, 115882 },
                    { 32, 115009 },
                    { 32, 115095 },
                    { 32, 115220 },
                    { 32, 115773 }
                });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupId", "StudentNumber" },
                values: new object[,]
                {
                    { 32, 115785 },
                    { 32, 115906 },
                    { 33, 115225 },
                    { 33, 115253 },
                    { 33, 115256 },
                    { 33, 115307 },
                    { 33, 115799 },
                    { 33, 115834 },
                    { 33, 115887 },
                    { 34, 115165 },
                    { 34, 115687 },
                    { 34, 115711 },
                    { 34, 115903 },
                    { 35, 115045 },
                    { 35, 115256 },
                    { 35, 115269 },
                    { 35, 115619 },
                    { 35, 115864 },
                    { 36, 115234 },
                    { 36, 115425 },
                    { 37, 115269 },
                    { 37, 115354 },
                    { 37, 115359 },
                    { 37, 115542 },
                    { 37, 115883 },
                    { 38, 115001 },
                    { 38, 115108 },
                    { 38, 115703 },
                    { 38, 115816 },
                    { 39, 115266 },
                    { 39, 115422 },
                    { 39, 115466 },
                    { 39, 115874 },
                    { 39, 115896 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115058 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115341 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115401 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115425 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115457 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115483 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115554 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 1, 115846 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115307 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115444 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 2, 115899 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115023 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115269 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115609 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115670 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115711 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115769 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115873 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 3, 115903 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115194 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115248 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115413 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 4, 115873 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 5, 115095 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 5, 115264 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 5, 115770 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115317 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115401 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115425 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 6, 115482 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115001 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115027 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115096 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115154 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115246 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115272 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115315 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 7, 115482 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115036 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115058 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115349 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115500 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115566 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115614 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 8, 115864 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115138 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115211 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115264 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115306 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 9, 115765 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115089 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115141 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115293 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115305 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115401 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 10, 115770 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115007 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115058 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115079 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115108 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 11, 115889 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115166 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115220 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115221 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115466 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115494 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115508 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115554 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 12, 115573 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115336 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 13, 115855 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115306 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115414 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115486 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 14, 115731 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115007 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115169 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115261 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 15, 115542 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115125 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115235 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115810 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 16, 115896 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115045 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115058 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115185 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115454 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 17, 115846 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115012 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115154 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115253 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115494 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115598 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 18, 115816 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115004 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115185 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115269 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115286 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115475 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115619 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115741 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 19, 115879 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115154 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115264 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115482 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115770 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 20, 115899 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 21, 115211 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 21, 115264 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 21, 115736 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 21, 115883 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115121 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115141 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115279 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115365 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115500 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115588 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115614 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 22, 115674 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 23, 115007 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 23, 115113 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 23, 115422 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 23, 115540 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 23, 115619 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 23, 115840 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115143 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115540 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 24, 115588 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115248 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 25, 115789 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 26, 115095 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 26, 115154 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 26, 115357 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 26, 115430 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 26, 115650 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 26, 115879 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 27, 115154 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 27, 115215 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 27, 115344 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 27, 115444 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 27, 115585 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 28, 115004 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 28, 115212 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 28, 115840 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 28, 115864 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 29, 115036 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 29, 115096 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 29, 115113 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 29, 115315 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 29, 115483 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 29, 115889 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 30, 115125 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 30, 115269 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 30, 115359 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 30, 115483 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 30, 115663 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 30, 115709 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 30, 115769 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 31, 115194 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 31, 115270 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 31, 115563 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 31, 115566 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 31, 115792 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 31, 115882 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 32, 115009 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 32, 115095 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 32, 115220 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 32, 115773 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 32, 115785 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 32, 115906 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 33, 115225 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 33, 115253 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 33, 115256 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 33, 115307 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 33, 115799 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 33, 115834 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 33, 115887 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 34, 115165 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 34, 115687 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 34, 115711 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 34, 115903 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115045 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115256 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115269 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115619 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 35, 115864 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 36, 115234 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 36, 115425 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 37, 115269 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 37, 115354 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 37, 115359 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 37, 115542 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 37, 115883 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 38, 115001 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 38, 115108 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 38, 115703 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 38, 115816 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 39, 115266 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 39, 115422 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 39, 115466 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 39, 115874 });

            migrationBuilder.DeleteData(
                table: "GroupStudent",
                keyColumns: new[] { "GroupId", "StudentNumber" },
                keyValues: new object[] { 39, 115896 });

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115032);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115034);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115043);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115047);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115076);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115107);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115129);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115130);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115144);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115161);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115170);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115180);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115200);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115204);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115216);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115233);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115255);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115285);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115302);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115324);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115329);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115334);

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
                keyValue: 115378);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115390);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115397);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115437);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115441);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115456);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115498);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115537);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115538);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115587);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115599);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115612);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115613);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115620);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115631);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115638);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115644);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115669);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115708);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115732);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115737);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115760);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115763);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115781);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115782);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115786);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115793);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115823);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115832);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115868);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115909);

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
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "GroupId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115001);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115004);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115007);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115009);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115012);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115023);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115027);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115036);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115045);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115058);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115079);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115089);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115095);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115096);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115108);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115113);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115121);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115125);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115138);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115141);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115143);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115154);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115165);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115166);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115169);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115185);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115194);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115211);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115212);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115215);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115220);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115221);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115225);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115234);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115235);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115246);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115248);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115253);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115256);

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
                keyValue: 115266);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115269);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115270);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115272);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115279);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115286);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115293);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115305);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115306);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115307);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115315);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115317);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115336);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115341);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115344);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115349);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115354);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115357);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115359);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115365);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115401);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115413);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115414);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115422);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115425);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115430);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115444);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115454);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115457);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115466);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115475);

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
                keyValue: 115486);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115494);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115500);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115508);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115540);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115542);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115554);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115563);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115566);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115573);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115585);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115588);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115598);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115609);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115614);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115619);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115650);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115663);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115670);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115674);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115687);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115703);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115709);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115711);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115731);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115736);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115741);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115765);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115769);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115770);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115773);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115785);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115789);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115792);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115799);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115810);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115816);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115834);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115840);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115846);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115855);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115864);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115873);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115874);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115879);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115882);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115883);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115887);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115889);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115896);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115899);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115903);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentNumber",
                keyValue: 115906);
        }
    }
}
