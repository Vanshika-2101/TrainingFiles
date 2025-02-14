using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoEmployeeProject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "EfCore",
                table: "EmployeeProject",
                columns: new[] { "EmployeeId", "ProjectId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 },
                    { 2, 5 },
                    { 3, 1 },
                    { 4, 3 },
                    { 4, 4 }
                });

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 46, 39, 781, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 46, 39, 781, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 46, 39, 781, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 46, 39, 781, DateTimeKind.Local).AddTicks(2294));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 46, 39, 781, DateTimeKind.Local).AddTicks(2295));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "EmployeeProject",
                keyColumns: new[] { "EmployeeId", "ProjectId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 43, 2, 207, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 43, 2, 207, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 43, 2, 207, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 43, 2, 207, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5,
                column: "HireDate",
                value: new DateTime(2025, 1, 26, 18, 43, 2, 207, DateTimeKind.Local).AddTicks(882));
        }
    }
}
