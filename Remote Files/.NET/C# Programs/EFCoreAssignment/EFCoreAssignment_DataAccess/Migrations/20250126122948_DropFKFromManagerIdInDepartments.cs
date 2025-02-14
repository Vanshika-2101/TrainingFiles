using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DropFKFromManagerIdInDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Employees_ManagerId",
                schema: "EfCore",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerId",
                schema: "EfCore",
                table: "Departments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
