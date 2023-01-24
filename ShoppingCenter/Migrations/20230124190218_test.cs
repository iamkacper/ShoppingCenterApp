using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingCenter.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0a81847a-248e-40b1-b911-7fb42bf6210a", null, "ClothesShopAdmin", "ClothesShopADMIN" },
                    { "22ceedf8-6ad0-4363-bd18-3c103f9826bf", null, "ToysShopAdmin", "ToysShopADMIN" },
                    { "3fd44251-ebb2-469b-88fc-34e996ec811b", null, "FoodShopAdmin", "FoodShopADMIN" },
                    { "4b740077-5318-4820-a418-87f0394baed4", null, "User", "USER" },
                    { "62411dbc-34b5-46d8-b2a0-9ac41433fc98", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "AvailabilityItem", "ColorItem", "DescriptionItem", "NameItem", "PriceItem", "ShopId", "SizeItem", "Url" },
                values: new object[] { new Guid("af325b81-9e7b-4109-890b-c08a209230c2"), 5, null, null, null, 20m, new Guid("b4593455-0c90-4100-8a24-ae26f49a7c8a"), null, null });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "ShopId", "Description", "Level", "ShopName" },
                values: new object[] { new Guid("3a946751-6532-4c3c-ab8c-1093f2d98d09"), "test", "1", "Testowy" });

            migrationBuilder.InsertData(
                table: "ShopCategory",
                columns: new[] { "ShopCategoryId", "ShopCategoryName", "ShopId" },
                values: new object[,]
                {
                    { new Guid("118230e5-18a6-44f0-aaae-3e8b4d8b5dd0"), "ToysShop", null },
                    { new Guid("773b4a20-e1e6-41f5-a584-c9992ca2b91c"), "ClothesShop", null },
                    { new Guid("da9b8e0e-2276-4fc0-afa2-7dc4785ed853"), "FoodShop", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0a81847a-248e-40b1-b911-7fb42bf6210a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22ceedf8-6ad0-4363-bd18-3c103f9826bf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fd44251-ebb2-469b-88fc-34e996ec811b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b740077-5318-4820-a418-87f0394baed4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62411dbc-34b5-46d8-b2a0-9ac41433fc98");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: new Guid("af325b81-9e7b-4109-890b-c08a209230c2"));

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: new Guid("3a946751-6532-4c3c-ab8c-1093f2d98d09"));

            migrationBuilder.DeleteData(
                table: "ShopCategory",
                keyColumn: "ShopCategoryId",
                keyValue: new Guid("118230e5-18a6-44f0-aaae-3e8b4d8b5dd0"));

            migrationBuilder.DeleteData(
                table: "ShopCategory",
                keyColumn: "ShopCategoryId",
                keyValue: new Guid("773b4a20-e1e6-41f5-a584-c9992ca2b91c"));

            migrationBuilder.DeleteData(
                table: "ShopCategory",
                keyColumn: "ShopCategoryId",
                keyValue: new Guid("da9b8e0e-2276-4fc0-afa2-7dc4785ed853"));

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
        }
    }
}
