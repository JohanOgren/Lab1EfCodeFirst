using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab1EfCodeFirst.Migrations
{
    public partial class EmployeeRegisterAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveHistorys");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfRegister",
                table: "LeaveForms",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfRegister",
                table: "LeaveForms");

            migrationBuilder.CreateTable(
                name: "LeaveHistorys",
                columns: table => new
                {
                    LeaveHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeaveFormsLeaveFormID = table.Column<int>(type: "int", nullable: true),
                    MyProperty = table.Column<int>(type: "int", nullable: false)
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
                name: "IX_LeaveHistorys_LeaveFormsLeaveFormID",
                table: "LeaveHistorys",
                column: "LeaveFormsLeaveFormID");
        }
    }
}
