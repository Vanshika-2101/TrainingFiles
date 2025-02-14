using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 41, 17, 759, DateTimeKind.Local).AddTicks(5965));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 41, 17, 759, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 41, 17, 759, DateTimeKind.Local).AddTicks(5979));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 41, 17, 759, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 41, 17, 759, DateTimeKind.Local).AddTicks(5982));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 38, 13, 201, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 38, 13, 201, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 38, 13, 201, DateTimeKind.Local).AddTicks(9177));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 38, 13, 201, DateTimeKind.Local).AddTicks(9178));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 38, 13, 201, DateTimeKind.Local).AddTicks(9180));
        }
    }
}
