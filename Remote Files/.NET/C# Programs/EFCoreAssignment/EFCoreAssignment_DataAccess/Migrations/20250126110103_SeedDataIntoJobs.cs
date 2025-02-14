using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataIntoJobs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "EfCore",
                table: "Jobs",
                columns: new[] { "JobId", "JobTitle", "MaxSalary", "MinSalary" },
                values: new object[,]
                {
                    { "CEO", "Chief Executive Officer", 100000, 10000 },
                    { "IT_PROG", "IT Programmer", 100000, 10000 },
                    { "IT_REP", "IT Representative", 100000, 10000 },
                    { "MARK_REP", "Marketing Representative", 100000, 10000 },
                    { "SA_REP", "Sales Representative", 100000, 10000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: "CEO");

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: "IT_PROG");

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: "IT_REP");

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: "MARK_REP");

            migrationBuilder.DeleteData(
                schema: "EfCore",
                table: "Jobs",
                keyColumn: "JobId",
                keyValue: "SA_REP");
        }
    }
}
