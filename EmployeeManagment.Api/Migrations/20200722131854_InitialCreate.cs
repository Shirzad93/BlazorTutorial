using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagment.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: false),
                    PhotoPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "IT" },
                    { 2, "HR" },
                    { 3, "Payroll" },
                    { 4, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1993, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Shiroo1@mail.com", "Shiroo1", 0, "Bakoo1", "Images/e1.jpg" },
                    { 2, new DateTime(1993, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Shiroo2@mail.com", "Shiroo2", 0, "Bakoo2", "Images/e2.jpg" },
                    { 3, new DateTime(1993, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Shiroo3@mail.com", "Shiroo3", 0, "Bakoo3", "Images/e3.jpg" },
                    { 4, new DateTime(1993, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Shiroo4@mail.com", "Shiroo4", 0, "Bakoo4", "Images/e4.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
