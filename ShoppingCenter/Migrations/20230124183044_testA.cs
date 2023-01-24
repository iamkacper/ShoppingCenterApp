using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingCenter.Migrations
{
    /// <inheritdoc />
    public partial class testA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Items_ItemId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ItemId",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0e7305c7-20b5-46c3-9244-b27f2b970573");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "329a0dd7-9a58-439c-b7d6-799dcecdeb7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42685d7c-30ad-433b-ac5f-5e4e4869fea4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2a29728-1838-4086-a898-97ccbc121ab9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c78d2fe5-c43e-40c0-bb8b-e77e51efb203");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ItemCategoryId",
                keyValue: new Guid("08bf3344-9b77-410f-b313-30980d5673ea"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ItemCategoryId",
                keyValue: new Guid("10ad2415-cf83-4f9d-8acc-44455bb8cb60"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ItemCategoryId",
                keyValue: new Guid("3fabdc8a-1098-465d-b8a6-88d51bc30f80"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ItemCategoryId",
                keyValue: new Guid("5933ebf7-f7ce-46c1-9a34-c3587f26a8d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ItemCategoryId",
                keyValue: new Guid("7499a8ed-40cf-43b6-99a4-44b15de3c713"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ItemCategoryId",
                keyValue: new Guid("7d1fc029-1d5f-4772-9291-06840046f661"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ItemCategoryId",
                keyValue: new Guid("9a450fd7-9321-48cf-8d3f-f09ccbf0eed5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ItemCategoryId",
                keyValue: new Guid("aeaa1ccf-a11d-40a4-8244-1fba5e9414d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ItemCategoryId",
                keyValue: new Guid("b0abc8fd-3430-4e82-80d8-4762755942c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ItemCategoryId",
                keyValue: new Guid("bd414305-8be4-4fd4-b77a-26b3700df732"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ItemCategoryId",
                keyValue: new Guid("be63f0cc-e30b-495e-a6ab-839fb3009e94"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "ItemCategoryId",
                keyValue: new Guid("d6cae0f9-9ecc-4da5-99a0-942c7c1b816a"));

            migrationBuilder.DeleteData(
                table: "ShopCategory",
                keyColumn: "ShopCategoryId",
                keyValue: new Guid("034b55fd-2941-4244-bb02-5a74564629b7"));

            migrationBuilder.DeleteData(
                table: "ShopCategory",
                keyColumn: "ShopCategoryId",
                keyValue: new Guid("9a4e92d2-a381-431e-bb02-a6874026cf65"));

            migrationBuilder.DeleteData(
                table: "ShopCategory",
                keyColumn: "ShopCategoryId",
                keyValue: new Guid("9ddd8d30-9b93-41aa-b63a-d583efcfd700"));

            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "ItemImageName",
                table: "Items",
                newName: "Url");

            migrationBuilder.AddColumn<Guid>(
                name: "ShopId",
                table: "Items",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ItemItemCategory",
                columns: table => new
                {
                    CategoriesItemCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    itemsItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemItemCategory", x => new { x.CategoriesItemCategoryId, x.itemsItemId });
                    table.ForeignKey(
                        name: "FK_ItemItemCategory_Categories_CategoriesItemCategoryId",
                        column: x => x.CategoriesItemCategoryId,
                        principalTable: "Categories",
                        principalColumn: "ItemCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ItemItemCategory_Items_itemsItemId",
                        column: x => x.itemsItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11e91ba9-9a55-44f6-8ff9-d9bbf5ce6797", null, "User", "USER" },
                    { "1bc8f6d0-b437-4272-9fc8-aaa1bce5178a", null, "ClothesShopAdmin", "ClothesShopADMIN" },
                    { "507f88b9-de06-4a15-9281-65258a898b6d", null, "ToysShopAdmin", "ToysShopADMIN" },
                    { "9bf9cd14-5427-4e46-a05a-2af73bcfeec4", null, "SuperAdmin", "SUPERADMIN" },
                    { "e815ca28-8f22-4440-ba58-6f739b3741cb", null, "FoodShopAdmin", "FoodShopADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "AvailabilityItem", "ColorItem", "DescriptionItem", "NameItem", "PriceItem", "ShopId", "SizeItem", "Url" },
                values: new object[] { new Guid("a33dc6c6-fc86-449a-aa40-0a85a05114b6"), 5, null, null, null, 20m, new Guid("b4593455-0c90-4100-8a24-ae26f49a7c8a"), null, null });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "ShopId", "Description", "Level", "ShopName" },
                values: new object[] { new Guid("4a7584ac-4f84-461a-a396-df11b1b4e2fa"), "test", "1", "Testowy" });

            migrationBuilder.InsertData(
                table: "ShopCategory",
                columns: new[] { "ShopCategoryId", "ShopCategoryName", "ShopId" },
                values: new object[,]
                {
                    { new Guid("33073c7c-d781-488b-b0b0-53bdb2e2d5f9"), "ClothesShop", null },
                    { new Guid("9ef783cf-6bc3-45ed-94d1-de66681d69b1"), "FoodShop", null },
                    { new Guid("ddf22316-0986-4709-a0f5-ab3b0d142a79"), "ToysShop", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_ShopId",
                table: "Items",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_ItemItemCategory_itemsItemId",
                table: "ItemItemCategory",
                column: "itemsItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Shop_ShopId",
                table: "Items",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_Shop_ShopId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "ItemItemCategory");

            migrationBuilder.DropIndex(
                name: "IX_Items_ShopId",
                table: "Items");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11e91ba9-9a55-44f6-8ff9-d9bbf5ce6797");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bc8f6d0-b437-4272-9fc8-aaa1bce5178a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "507f88b9-de06-4a15-9281-65258a898b6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bf9cd14-5427-4e46-a05a-2af73bcfeec4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e815ca28-8f22-4440-ba58-6f739b3741cb");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: new Guid("a33dc6c6-fc86-449a-aa40-0a85a05114b6"));

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: new Guid("4a7584ac-4f84-461a-a396-df11b1b4e2fa"));

            migrationBuilder.DeleteData(
                table: "ShopCategory",
                keyColumn: "ShopCategoryId",
                keyValue: new Guid("33073c7c-d781-488b-b0b0-53bdb2e2d5f9"));

            migrationBuilder.DeleteData(
                table: "ShopCategory",
                keyColumn: "ShopCategoryId",
                keyValue: new Guid("9ef783cf-6bc3-45ed-94d1-de66681d69b1"));

            migrationBuilder.DeleteData(
                table: "ShopCategory",
                keyColumn: "ShopCategoryId",
                keyValue: new Guid("ddf22316-0986-4709-a0f5-ab3b0d142a79"));

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Items");

            migrationBuilder.RenameColumn(
                name: "Url",
                table: "Items",
                newName: "ItemImageName");

            migrationBuilder.AddColumn<Guid>(
                name: "ItemId",
                table: "Categories",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0e7305c7-20b5-46c3-9244-b27f2b970573", null, "ClothesShopAdmin", "ClothesShopADMIN" },
                    { "329a0dd7-9a58-439c-b7d6-799dcecdeb7e", null, "SuperAdmin", "SUPERADMIN" },
                    { "42685d7c-30ad-433b-ac5f-5e4e4869fea4", null, "ToysShopAdmin", "ToysShopADMIN" },
                    { "b2a29728-1838-4086-a898-97ccbc121ab9", null, "FoodShopAdmin", "FoodShopADMIN" },
                    { "c78d2fe5-c43e-40c0-bb8b-e77e51efb203", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ItemCategoryId", "ItemCategoryName", "ItemId" },
                values: new object[,]
                {
                    { new Guid("08bf3344-9b77-410f-b313-30980d5673ea"), "LEGO Bricks", null },
                    { new Guid("10ad2415-cf83-4f9d-8acc-44455bb8cb60"), "Trousers", null },
                    { new Guid("3fabdc8a-1098-465d-b8a6-88d51bc30f80"), "Barbie doll", null },
                    { new Guid("5933ebf7-f7ce-46c1-9a34-c3587f26a8d6"), "T-Shirt", null },
                    { new Guid("7499a8ed-40cf-43b6-99a4-44b15de3c713"), "Apple", null },
                    { new Guid("7d1fc029-1d5f-4772-9291-06840046f661"), "Potato", null },
                    { new Guid("9a450fd7-9321-48cf-8d3f-f09ccbf0eed5"), "Hoodie", null },
                    { new Guid("aeaa1ccf-a11d-40a4-8244-1fba5e9414d4"), "Lemon", null },
                    { new Guid("b0abc8fd-3430-4e82-80d8-4762755942c9"), "Shoes", null },
                    { new Guid("bd414305-8be4-4fd4-b77a-26b3700df732"), "Ball", null },
                    { new Guid("be63f0cc-e30b-495e-a6ab-839fb3009e94"), "Teddy Bear", null },
                    { new Guid("d6cae0f9-9ecc-4da5-99a0-942c7c1b816a"), "Orange", null }
                });

            migrationBuilder.InsertData(
                table: "ShopCategory",
                columns: new[] { "ShopCategoryId", "ShopCategoryName", "ShopId" },
                values: new object[,]
                {
                    { new Guid("034b55fd-2941-4244-bb02-5a74564629b7"), "FoodShop", null },
                    { new Guid("9a4e92d2-a381-431e-bb02-a6874026cf65"), "ClothesShop", null },
                    { new Guid("9ddd8d30-9b93-41aa-b63a-d583efcfd700"), "ToysShop", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ItemId",
                table: "Categories",
                column: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Items_ItemId",
                table: "Categories",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "ItemId");
        }
    }
}
