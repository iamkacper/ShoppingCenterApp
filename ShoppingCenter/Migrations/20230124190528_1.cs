using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingCenter.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "07ee8508-ff88-497c-b2aa-caecd34e663b", null, "ToysShopAdmin", "ToysShopADMIN" },
                    { "968c6212-421a-400c-8f89-870af61d5d7b", null, "FoodShopAdmin", "FoodShopADMIN" },
                    { "a74b1e0a-3dca-4d86-a664-eabb9717a768", null, "ClothesShopAdmin", "ClothesShopADMIN" },
                    { "c1f9862c-85d4-4a26-b652-2cbe012be60b", null, "User", "USER" },
                    { "dc9a7fe1-594b-4d20-8982-d7f91512f888", null, "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "AvailabilityItem", "ColorItem", "DescriptionItem", "NameItem", "PriceItem", "ShopId", "SizeItem", "Url" },
                values: new object[] { new Guid("fd59ab0d-a8c8-4549-82e1-c39fea281b3f"), 5, null, null, null, 20m, new Guid("b4593455-0c90-4100-8a24-ae26f49a7c8a"), null, null });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "ShopId", "Description", "Level", "ShopName" },
                values: new object[] { new Guid("e2a5c13e-533e-47a4-81d7-fad7ddde2073"), "test", "1", "Testowy" });

            migrationBuilder.InsertData(
                table: "ShopCategory",
                columns: new[] { "ShopCategoryId", "ShopCategoryName", "ShopId" },
                values: new object[,]
                {
                    { new Guid("8b061ee3-104f-4734-91b4-73435427beb4"), "ClothesShop", null },
                    { new Guid("a297e5ff-3c24-42c5-b112-2e759e57fa29"), "FoodShop", null },
                    { new Guid("dfc47378-5606-4e17-8c36-2e1082d3a734"), "ToysShop", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07ee8508-ff88-497c-b2aa-caecd34e663b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "968c6212-421a-400c-8f89-870af61d5d7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a74b1e0a-3dca-4d86-a664-eabb9717a768");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1f9862c-85d4-4a26-b652-2cbe012be60b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc9a7fe1-594b-4d20-8982-d7f91512f888");

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: new Guid("fd59ab0d-a8c8-4549-82e1-c39fea281b3f"));

            migrationBuilder.DeleteData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: new Guid("e2a5c13e-533e-47a4-81d7-fad7ddde2073"));

            migrationBuilder.DeleteData(
                table: "ShopCategory",
                keyColumn: "ShopCategoryId",
                keyValue: new Guid("8b061ee3-104f-4734-91b4-73435427beb4"));

            migrationBuilder.DeleteData(
                table: "ShopCategory",
                keyColumn: "ShopCategoryId",
                keyValue: new Guid("a297e5ff-3c24-42c5-b112-2e759e57fa29"));

            migrationBuilder.DeleteData(
                table: "ShopCategory",
                keyColumn: "ShopCategoryId",
                keyValue: new Guid("dfc47378-5606-4e17-8c36-2e1082d3a734"));

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
    }
}
