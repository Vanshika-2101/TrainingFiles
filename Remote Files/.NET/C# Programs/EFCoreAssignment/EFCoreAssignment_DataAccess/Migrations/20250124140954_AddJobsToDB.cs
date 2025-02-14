using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddJobsToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobId",
                schema: "EfCore",
                table: "Employees",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Jobs",
                schema: "EfCore",
                columns: table => new
                {
                    JobId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MinSalary = table.Column<int>(type: "int", nullable: false),
                    MaxSalary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.JobId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobId",
                schema: "EfCore",
                table: "Employees",
                column: "JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Jobs_JobId",
                schema: "EfCore",
                table: "Employees",
                column: "JobId",
                principalSchema: "EfCore",
                principalTable: "Jobs",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Jobs_JobId",
                schema: "EfCore",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "Jobs",
                schema: "EfCore");

            migrationBuilder.DropIndex(
                name: "IX_Employees_JobId",
                schema: "EfCore",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "JobId",
                schema: "EfCore",
                table: "Employees");
        }
    }
}
