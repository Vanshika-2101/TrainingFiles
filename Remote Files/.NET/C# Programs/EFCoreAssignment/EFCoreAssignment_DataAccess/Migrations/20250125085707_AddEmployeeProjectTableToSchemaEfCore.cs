using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeProjectTableToSchemaEfCore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "EmployeeProject",
                newName: "EmployeeProject",
                newSchema: "EfCore");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "EmployeeProject",
                schema: "EfCore",
                newName: "EmployeeProject");
        }
    }
}
