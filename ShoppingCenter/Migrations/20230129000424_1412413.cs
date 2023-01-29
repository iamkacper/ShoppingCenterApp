using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCenter.Migrations
{
    /// <inheritdoc />
    public partial class _1412413 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 1,
                columns: new[] { "Email", "Phone" },
                values: new object[] { "ClothesShop@gmail.com", "15 345 23 44" });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "Email", "Phone" },
                values: new object[] { "ToysShop@gmail.com", "13 12 14 55" });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 3,
                columns: new[] { "Email", "Phone" },
                values: new object[] { "FoodShop@gmail.com", "14 112 33 13" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Shop");
        }
    }
}
