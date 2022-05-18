﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Service.Database.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "Students",
                columns: table => new
                {
                    Number = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Number);
                });

            migrationBuilder.CreateTable(
                name: "GroupStudent",
                columns: table => new
                {
                    GroupsGroupId = table.Column<int>(type: "int", nullable: false),
                    StudentsNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupStudent", x => new { x.GroupsGroupId, x.StudentsNumber });
                    table.ForeignKey(
                        name: "FK_GroupStudent_Groups_GroupsGroupId",
                        column: x => x.GroupsGroupId,
                        principalTable: "Groups",
                        principalColumn: "GroupId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GroupStudent_Students_StudentsNumber",
                        column: x => x.StudentsNumber,
                        principalTable: "Students",
                        principalColumn: "Number",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "GroupId", "Name", "Number" },
                values: new object[] { 1, "Foo", 1 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Number", "Name" },
                values: new object[] { 116000, "John" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Number", "Name" },
                values: new object[] { 116001, "Jane" });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupsGroupId", "StudentsNumber" },
                values: new object[] { 1, 116000 });

            migrationBuilder.InsertData(
                table: "GroupStudent",
                columns: new[] { "GroupsGroupId", "StudentsNumber" },
                values: new object[] { 1, 116001 });

            migrationBuilder.CreateIndex(
                name: "IX_GroupStudent_StudentsNumber",
                table: "GroupStudent",
                column: "StudentsNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupStudent");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}