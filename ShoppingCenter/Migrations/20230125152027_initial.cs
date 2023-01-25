using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingCenter.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ItemCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ItemCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ColorItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvailabilityItem = table.Column<int>(type: "int", nullable: false),
                    PriceItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionItem = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ItemId);
                });

            migrationBuilder.CreateTable(
                name: "Shop",
                columns: table => new
                {
                    ShopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop", x => x.ShopId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomersShoppingCarts",
                columns: table => new
                {
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersShoppingCarts", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_CustomersShoppingCarts_AspNetUsers_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_Transactions_AspNetUsers_CustomerId1",
                        column: x => x.CustomerId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemItemCategory",
                columns: table => new
                {
                    CategoriesItemCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    itemsItemId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Shop_Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShopId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shop_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shop_Items_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "ItemId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Shop_Items_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "ShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShopCategory",
                columns: table => new
                {
                    ShopCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShopCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShopId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCategory", x => x.ShopCategoryId);
                    table.ForeignKey(
                        name: "FK_ShopCategory_Shop_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shop",
                        principalColumn: "ShopId");
                });

            migrationBuilder.CreateTable(
                name: "CustomerShoppingCartItems",
                columns: table => new
                {
                    CustomerShoppingCartItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerShoppingCartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerShoppingCartItems", x => x.CustomerShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_CustomerShoppingCartItems_CustomersShoppingCarts_CustomerShoppingCartId",
                        column: x => x.CustomerShoppingCartId,
                        principalTable: "CustomersShoppingCarts",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerShoppingCartItems_Items_ItemId1",
                        column: x => x.ItemId1,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                });

            migrationBuilder.CreateTable(
                name: "Transaction_Items",
                columns: table => new
                {
                    ItemTransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemId1 = table.Column<int>(type: "int", nullable: true),
                    PriceItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction_Items", x => x.ItemTransactionId);
                    table.ForeignKey(
                        name: "FK_Transaction_Items_Items_ItemId1",
                        column: x => x.ItemId1,
                        principalTable: "Items",
                        principalColumn: "ItemId");
                    table.ForeignKey(
                        name: "FK_Transaction_Items_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "TransactionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "AvailabilityItem", "ColorItem", "DescriptionItem", "NameItem", "PriceItem", "SizeItem", "Url" },
                values: new object[,]
                {
                    { 1, 5, "White", null, "T shirt", 59m, "S", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { 2, 5, "White", null, "T shirt", 59m, "S", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { 3, 5, "White", null, "T shirt", 59m, "S", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { 4, 5, "White", null, "T shirt", 59m, "S", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" },
                    { 5, 5, "White", null, "T shirt", 59m, "S", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "ShopId", "Description", "Level", "ShopName" },
                values: new object[,]
                {
                    { 1, "Clothes shop, t-shirts, trouser and hoodies!", "0", "ClothesShop" },
                    { 2, "Clothes shop, t-shirts, trouser and hoodies!", "0", "ClothesShop" }
                });

            migrationBuilder.InsertData(
                table: "Shop_Items",
                columns: new[] { "Id", "ItemId", "ShopId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 1 },
                    { 3, 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerShoppingCartItems_CustomerShoppingCartId",
                table: "CustomerShoppingCartItems",
                column: "CustomerShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerShoppingCartItems_ItemId1",
                table: "CustomerShoppingCartItems",
                column: "ItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_CustomersShoppingCarts_CustomerId1",
                table: "CustomersShoppingCarts",
                column: "CustomerId1");

            migrationBuilder.CreateIndex(
                name: "IX_ItemItemCategory_itemsItemId",
                table: "ItemItemCategory",
                column: "itemsItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_Items_ItemId",
                table: "Shop_Items",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_Items_ShopId",
                table: "Shop_Items",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopCategory_ShopId",
                table: "ShopCategory",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_Items_ItemId1",
                table: "Transaction_Items",
                column: "ItemId1");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_Items_TransactionId",
                table: "Transaction_Items",
                column: "TransactionId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CustomerId1",
                table: "Transactions",
                column: "CustomerId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CustomerShoppingCartItems");

            migrationBuilder.DropTable(
                name: "ItemItemCategory");

            migrationBuilder.DropTable(
                name: "Shop_Items");

            migrationBuilder.DropTable(
                name: "ShopCategory");

            migrationBuilder.DropTable(
                name: "Transaction_Items");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "CustomersShoppingCarts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Shop");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Transactions");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
