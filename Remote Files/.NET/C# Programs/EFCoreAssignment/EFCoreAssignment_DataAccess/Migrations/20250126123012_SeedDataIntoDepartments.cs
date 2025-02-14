using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "EfCore",
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName", "ManagerId" },
                values: new object[,]
                {
                    { 1, "CEO", 5 },
                    { 2, "Sales", 2 },
                    { 3, "IT", 3 },
                    { 4, "Marketing", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Departments",
                keyColumn: "DepartmentId",
                keyValue: 4);
        }
    }
}
