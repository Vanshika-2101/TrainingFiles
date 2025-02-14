using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoEmployeeDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "EfCore",
                table: "EmployeeDetails",
                columns: new[] { "EmployeeDetailsId", "AadharNumber", "Address", "EmployeeId" },
                values: new object[,]
                {
                    { 1, "527487659876", "Whitmore", 1 },
                    { 2, "527487659877", "B Mystic Falls", 2 },
                    { 3, "527487659878", "C Mystic Falls", 3 },
                    { 4, "527487659879", "New Orleans", 4 },
                    { 5, "527487659880", "E Mystic Falls", 5 }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "EmployeeDetails",
                keyColumn: "EmployeeDetailsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "EmployeeDetails",
                keyColumn: "EmployeeDetailsId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "EmployeeDetails",
                keyColumn: "EmployeeDetailsId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "EmployeeDetails",
                keyColumn: "EmployeeDetailsId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "EmployeeDetails",
                keyColumn: "EmployeeDetailsId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 2, 13, 846, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 2, 13, 846, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 2, 13, 846, DateTimeKind.Local).AddTicks(8474));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 2, 13, 846, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 2, 13, 846, DateTimeKind.Local).AddTicks(8477));
        }
    }
}
