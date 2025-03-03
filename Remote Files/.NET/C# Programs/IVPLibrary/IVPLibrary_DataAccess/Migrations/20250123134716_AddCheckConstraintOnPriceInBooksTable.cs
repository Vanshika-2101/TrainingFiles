﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IVPLibrary_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddCheckConstraintOnPriceInBooksTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "CK_Books_Price",
                table: "Books",
                sql: "Price > 0");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "CK_Books_Price",
                table: "Books");
        }
    }
}
