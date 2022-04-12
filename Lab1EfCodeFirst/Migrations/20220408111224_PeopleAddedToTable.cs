using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1EfCodeFirst.Migrations
{
    public partial class PeopleAddedToTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: false, defaultValue: "True")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "LeaveForms",
                columns: table => new
                {
                    LeaveFormID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(nullable: false),
                    DateFrom = table.Column<DateTime>(nullable: false),
                    DateTo = table.Column<DateTime>(nullable: false),
                    DateOfRegister = table.Column<DateTime>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveForms", x => x.LeaveFormID);
                    table.ForeignKey(
                        name: "FK_LeaveForms_Employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employee",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeID", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Tony", "Stark" },
                    { 2, "Steven", "Rogers" },
                    { 3, "Clinton", "Barton" },
                    { 4, "Wanda", "Maximoff" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveForms_EmployeeID",
                table: "LeaveForms",
                column: "EmployeeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveForms");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
