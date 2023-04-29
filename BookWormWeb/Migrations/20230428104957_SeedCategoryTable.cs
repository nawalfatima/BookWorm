using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookWormWeb.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDateTime", "DisplayOrder", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 4, 28, 15, 49, 56, 961, DateTimeKind.Local).AddTicks(8464), 1, "Action" },
                    { 2, new DateTime(2023, 4, 28, 15, 49, 56, 961, DateTimeKind.Local).AddTicks(8483), 2, "SciFi" },
                    { 3, new DateTime(2023, 4, 28, 15, 49, 56, 961, DateTimeKind.Local).AddTicks(8485), 3, "Horror" },
                    { 4, new DateTime(2023, 4, 28, 15, 49, 56, 961, DateTimeKind.Local).AddTicks(8487), 4, "Romance" },
                    { 5, new DateTime(2023, 4, 28, 15, 49, 56, 961, DateTimeKind.Local).AddTicks(8489), 5, "Fantasy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
