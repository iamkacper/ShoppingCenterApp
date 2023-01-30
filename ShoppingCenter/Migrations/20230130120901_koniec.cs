using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingCenter.Migrations
{
    /// <inheritdoc />
    public partial class koniec : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9ddfddf-14e6-4203-9de6-b0518b70460d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be250f84-1cc6-4b4f-b459-8d42883d7d8b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "126c195b-2c4a-466e-85fa-e33799c25af5", null, "Admin", "ADMIN" },
                    { "d4624c18-7d03-4ff9-b4df-00f45feafca1", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "126c195b-2c4a-466e-85fa-e33799c25af5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d4624c18-7d03-4ff9-b4df-00f45feafca1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a9ddfddf-14e6-4203-9de6-b0518b70460d", null, "User", "USER" },
                    { "be250f84-1cc6-4b4f-b459-8d42883d7d8b", null, "Admin", "ADMIN" }
                });
        }
    }
}
