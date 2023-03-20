using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementSystem.Migrations
{
    public partial class mssql : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DOB", "DepartmentId", "Email", "Name", "Phone" },
                values: new object[] { 1, new DateTime(2000, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "joagneann@yahoo.com", "Joagne Fernando", "0976-083-9594" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DOB", "DepartmentId", "Email", "Name", "Phone" },
                values: new object[] { 2, new DateTime(1999, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "charles@gmail.com", "Charles Jimenez", "0956-234-3877" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DOB", "DepartmentId", "Email", "Name", "Phone" },
                values: new object[] { 3, new DateTime(1990, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "janel@yahoo.com", "Janel Cubian", "0932-183-8300" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
