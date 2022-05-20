using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.FormId);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupId);
                });

            migrationBuilder.CreateTable(
                name: "Indicators",
                columns: table => new
                {
                    IndicatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Indicators", x => x.IndicatorId);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentNumber = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentNumber);
                });

            migrationBuilder.CreateTable(
                name: "FormIndicators",
                columns: table => new
                {
                    FormId = table.Column<int>(type: "int", nullable: false),
                    IndicatorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormIndicators", x => new { x.FormId, x.IndicatorId });
                    table.ForeignKey(
                        name: "FK_FormIndicators_Forms_FormId",
                        column: x => x.FormId,
                        principalTable: "Forms",
                        principalColumn: "FormId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FormIndicators_Indicators_IndicatorId",
                        column: x => x.IndicatorId,
                        principalTable: "Indicators",
                        principalColumn: "IndicatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GroupStudent",
                columns: table => new
                {
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    StudentNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupStudent", x => new { x.GroupId, x.StudentNumber });
                    table.ForeignKey(
                        name: "FK_GroupStudent_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupStudent_Students_StudentNumber",
                        column: x => x.StudentNumber,
                        principalTable: "Students",
                        principalColumn: "StudentNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormIndicators_IndicatorId",
                table: "FormIndicators",
                column: "IndicatorId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupStudent_StudentNumber",
                table: "GroupStudent",
                column: "StudentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Indicators_Name",
                table: "Indicators",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormIndicators");

            migrationBuilder.DropTable(
                name: "GroupStudent");

            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropTable(
                name: "Indicators");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
