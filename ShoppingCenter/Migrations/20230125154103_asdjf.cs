using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingCenter.Migrations
{
    /// <inheritdoc />
    public partial class asdjf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "ColorItem",
                value: "WHITE");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "AvailabilityItem", "ColorItem", "PriceItem", "SizeItem" },
                values: new object[] { 7, "BLACK", 65m, "M" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "ColorItem", "PriceItem", "SizeItem" },
                values: new object[] { "BLUE WITH PRINT", 79m, "L" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "ColorItem", "NameItem", "PriceItem", "SizeItem" },
                values: new object[] { "Black", "Trousers", 99m, "42" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "ColorItem", "NameItem", "PriceItem", "SizeItem" },
                values: new object[] { "Green", "Jacket", 129m, "44" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "AvailabilityItem", "ColorItem", "DescriptionItem", "NameItem", "PriceItem", "SizeItem", "Url" },
                values: new object[,]
                {
                    { 6, 5, "White", null, "LEGO", 59m, "1000 bricks", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { 7, 5, "White", null, "LEGO", 59m, "S", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { 8, 5, "White", null, "banana", 59m, "S", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { 9, 5, "White", null, "apple", 59m, "S", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" }
                });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 1,
                column: "ShopName",
                value: "Clothes Shop");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "Description", "Level", "ShopName" },
                values: new object[] { "Toys shop, teddy bears, LEGO and many more toys for you!", "1", "Toys Shop" });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "ShopId", "Description", "Level", "ShopName" },
                values: new object[] { 3, "Food shop, vegetables, fruits, fresh juice.", "1", "Toys Shop" });

            migrationBuilder.UpdateData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "ItemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "ItemId",
                value: 3);

            migrationBuilder.InsertData(
                table: "Shop_Items",
                columns: new[] { "Id", "ItemId", "ShopId" },
                values: new object[,]
                {
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 2 },
                    { 7, 7, 2 },
                    { 8, 8, 3 },
                    { 9, 9, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "ColorItem",
                value: "White");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "AvailabilityItem", "ColorItem", "PriceItem", "SizeItem" },
                values: new object[] { 5, "White", 59m, "S" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "ColorItem", "PriceItem", "SizeItem" },
                values: new object[] { "White", 59m, "S" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "ColorItem", "NameItem", "PriceItem", "SizeItem" },
                values: new object[] { "White", "T shirt", 59m, "S" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "ColorItem", "NameItem", "PriceItem", "SizeItem" },
                values: new object[] { "White", "T shirt", 59m, "S" });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 1,
                column: "ShopName",
                value: "ClothesShop");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 2,
                columns: new[] { "Description", "Level", "ShopName" },
                values: new object[] { "Clothes shop, t-shirts, trouser and hoodies!", "0", "ClothesShop" });

            migrationBuilder.UpdateData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 2,
                column: "ItemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 3,
                column: "ItemId",
                value: 1);
        }
    }
}
