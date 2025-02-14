using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Re_SeedDataIntoProjects : Migration
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

            migrationBuilder.InsertData(
                schema: "EfCore",
                table: "Projects",
                columns: new[] { "ProjectId", "ProjectName" },
                values: new object[,]
                {
                    { 1, "P001" },
                    { 2, "P002" },
                    { 3, "P003" },
                    { 4, "P004" },
                    { 5, "P005" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Projects",
                keyColumn: "ProjectId",
                keyValue: 5);

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
    }
}
