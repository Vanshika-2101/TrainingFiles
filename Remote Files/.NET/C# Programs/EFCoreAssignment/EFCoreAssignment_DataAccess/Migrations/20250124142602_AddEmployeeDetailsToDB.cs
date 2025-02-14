using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreAssignment_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeDetailsToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeDetails",
                schema: "EfCore",
                columns: table => new
                {
                    EmployeeDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AadharNumber = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetails", x => x.EmployeeDetailsId);
                    table.ForeignKey(
                        name: "FK_EmployeeDetails_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalSchema: "EfCore",
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_AadharNumber",
                schema: "EfCore",
                table: "EmployeeDetails",
                column: "AadharNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_EmployeeId",
                schema: "EfCore",
                table: "EmployeeDetails",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDetails",
                schema: "EfCore");
        }
    }
}
