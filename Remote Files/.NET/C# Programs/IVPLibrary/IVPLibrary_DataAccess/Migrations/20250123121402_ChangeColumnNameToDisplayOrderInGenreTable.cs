using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IVPLibrary_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeColumnNameToDisplayOrderInGenreTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Display",
                table: "Genres");

            migrationBuilder.AddColumn<string>(
                name: "DisplayOrder",
                table: "Genres",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Genres");

            migrationBuilder.AddColumn<int>(
                name: "Display",
                table: "Genres",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
