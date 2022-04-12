using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1EfCodeFirst.Migrations
{
    public partial class EmployeeForms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employess",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employess", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "LeaveForms",
                columns: table => new
                {
                    LeaveFormID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reason = table.Column<string>(nullable: false),
                    DateOfLeave = table.Column<DateTime>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveForms", x => x.LeaveFormID);
                    table.ForeignKey(
                        name: "FK_LeaveForms_Employess_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employess",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LeaveHistorys",
                columns: table => new
                {
                    LeaveHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MyProperty = table.Column<int>(nullable: false),
                    LeaveFormsLeaveFormID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveHistorys", x => x.LeaveHistoryID);
                    table.ForeignKey(
                        name: "FK_LeaveHistorys_LeaveForms_LeaveFormsLeaveFormID",
                        column: x => x.LeaveFormsLeaveFormID,
                        principalTable: "LeaveForms",
                        principalColumn: "LeaveFormID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveForms_EmployeeID",
                table: "LeaveForms",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveHistorys_LeaveFormsLeaveFormID",
                table: "LeaveHistorys",
                column: "LeaveFormsLeaveFormID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveHistorys");

            migrationBuilder.DropTable(
                name: "LeaveForms");

            migrationBuilder.DropTable(
                name: "Employess");
        }
    }
}
