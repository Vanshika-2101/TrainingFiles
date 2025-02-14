using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IVPLibrary_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddOneToManyRelation_Publisher_Book : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PUblisher_Id",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "PUblisher_Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "PUblisher_Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "PUblisher_Id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "PUblisher_Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "PUblisher_Id",
                value: 3);

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "PUblisher_Id", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Delhi", "IVP Publisher" },
                    { 2, "Mumbai", "AYT Publisher" },
                    { 3, "Bangalore", "Hedge Publisher" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_PUblisher_Id",
                table: "Books",
                column: "PUblisher_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PUblisher_Id",
                table: "Books",
                column: "PUblisher_Id",
                principalTable: "Publishers",
                principalColumn: "PUblisher_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PUblisher_Id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PUblisher_Id",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PUblisher_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PUblisher_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "PUblisher_Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "PUblisher_Id",
                table: "Books");
        }
    }
}
