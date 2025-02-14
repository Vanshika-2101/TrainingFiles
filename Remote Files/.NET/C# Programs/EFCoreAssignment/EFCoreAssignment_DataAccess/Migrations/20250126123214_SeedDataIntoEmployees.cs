using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoEmployees : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "EfCore",
                table: "Employees",
                columns: new[] { "EmployeeId", "CommissionPct", "DepartmentId", "Email", "FirstName", "HireDate", "JobId", "LastName", "ManagerId", "PhoneNumber", "Salary" },
                values: new object[,]
                {
                    { 3, 0.20000000000000001, 3, "caroline@ms", "Caroline", new DateTime(2025, 1, 26, 18, 2, 13, 846, DateTimeKind.Local).AddTicks(8474), "IT_PROG", "Forbes", 3, "515.123.4569", 35000.0 },
                    { 5, 1.0, 1, "elena@ms", "Elena", new DateTime(2025, 1, 26, 18, 2, 13, 846, DateTimeKind.Local).AddTicks(8477), "CEO", "Gilbert", 5, "515.123.4571", 50000.0 },
                    { 2, 0.20000000000000001, 3, "bonnie@ms", "Bonnie", new DateTime(2025, 1, 26, 18, 2, 13, 846, DateTimeKind.Local).AddTicks(8472), "IT_REP", "Bennett", 3, "515.123.4568", 40000.0 },
                    { 4, 0.29999999999999999, 4, "damon@ms", "Damon", new DateTime(2025, 1, 26, 18, 2, 13, 846, DateTimeKind.Local).AddTicks(8476), "MARK_REP", "Salvatore", 5, "515.123.4570", 45000.0 },
                    { 1, 0.10000000000000001, 2, "aaron@ms", "Aaron", new DateTime(2025, 1, 26, 18, 2, 13, 846, DateTimeKind.Local).AddTicks(8462), "SA_REP", "Whitmore", 2, "515.123.4567", 35000.0 }
                });

            migrationBuilder.AddCheckConstraint(
                name: "CK_Employees_Salary",
                schema: "EfCore",
                table: "Employees",
                sql: "Salary > 0");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerId",
                schema: "EfCore",
                table: "Departments",
                column: "ManagerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Employees_ManagerId",
                schema: "EfCore",
                table: "Departments",
                column: "ManagerId",
                principalSchema: "EfCore",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_ManagerId",
                schema: "EfCore",
                table: "Departments");

            migrationBuilder.DropCheckConstraint(
                name: "CK_Employees_Salary",
                schema: "EfCore",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerId",
                schema: "EfCore",
                table: "Departments");

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);
        }
    }
}
