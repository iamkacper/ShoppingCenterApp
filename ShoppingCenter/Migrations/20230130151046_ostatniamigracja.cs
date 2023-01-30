using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingCenter.Migrations
{
    /// <inheritdoc />
    public partial class ostatniamigracja : Migration
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
                name: "Items",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameItem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SizeItem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceItem = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionItem = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    ShopName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "269aa160-a485-44c7-a3b4-adfb737fe9df", null, "Admin", "ADMIN" },
                    { "8cc27179-b50a-4fcc-8ad2-8a95b7a6ea02", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "ColorItem", "DescriptionItem", "NameItem", "PriceItem", "SizeItem", "Url" },
                values: new object[,]
                {
                    { 1, "White", "Unisex t-shirt", "T shirt", 49m, "S", "https://sklep.lahtipro.pl/1355-thickbox_default/koszulka-t-shirt-bawelniana-biala-lahti-pro-l40204.jpg" },
                    { 2, "Black", "Unisex t-shirt", "T shirt", 49m, "M", "https://sklep.lahtipro.pl/1281-large_default/koszulka-t-shirt-bawelniana-czarna-lahtipro-l40205.jpg" },
                    { 3, "Blue with print", "T-shirt for men", "T shirt", 89m, "L", "https://duzylolek.pl/userdata/public/gfx/6120/koszulka-t-shirt-duze-rozmiary-3XL-4XL-5XL-Adamo-modna-wygodna-dla-mezczyzn-plus-size-napisy-6XL-7XL-8XL-9XL-10XL-12XL.jpg" },
                    { 4, "Black", "Trousers for men", "Trousers", 89m, "42", "https://image-resizing.booztcdn.com/selected-homme/sel16051390_cblack_v179099.webp?has_grey=1&has_webp=0&size=w1300" },
                    { 5, "Green", "Jacket for men", "Jacket", 399m, "L", "https://dankyshop.pl/wp-content/uploads/2022/12/2-1.png" },
                    { 6, null, "Brick for children from 12 years of age", "LEGO", 3159m, "7541 bricks", "https://prod-api.mediaexpert.pl/api/images/gallery_500_500/thumbnails/images/27/2746003/LEGO-Star-Wars-Sokol-Millennium-75192-pudelko-zestaw.jpg" },
                    { 7, null, "Brick for children from 12 years of ag.", "LEGO", 389m, "834 bricks", "https://m.media-amazon.com/images/I/611NGqFr1JL._AC_SX522_.jpg" },
                    { 8, null, "A great gift for a child", "TEDDY BEAR", 39m, "60cm", "https://target.scene7.com/is/image/Target/GUEST_27556c59-356f-44c0-9142-0bf4465e116c?wid=488&hei=488&fmt=pjpeg" },
                    { 9, null, "A great gift for a child", "TEDDY BEAR", 99m, "120cm", "https://cdn.shopify.com/s/files/1/0073/4740/4882/products/IMG_0476_0e28708a-6fc1-4c8a-afb1-43ce0924b52d_2592x.jpg?v=1630514970" },
                    { 10, null, "A great gift for a girl", "DOLL", 189m, "40cm", "https://image.ceneostatic.pl/data/article_picture/31/d6/7d6d-6663-4ca2-96de-f3ca303412c6_large.png" },
                    { 11, null, "A great gift for a future footballer", "PLUSH BALL", 56m, "M", "https://a.allegroimg.com/s1024/0cbed4/dfcc714144feb7d863cacfa4b2c9" },
                    { 12, null, "Healthy, not sprayed", "Banana", 2m, null, "https://media.istockphoto.com/id/619046500/pl/zdj%C4%99cie/banany.jpg?s=612x612&w=0&k=20&c=44UgqVhiRpE94HbvM2-3i3VrZnRS_cLYdYOroV8LTIo=" },
                    { 13, null, "From a Polish orchard", "Apple", 1m, null, "https://images.pexels.com/photos/102104/pexels-photo-102104.jpeg" },
                    { 14, null, "From a Polish orchard", "Apple juice", 5m, null, "https://wspolceznatura.pl/userdata/public/gfx/2125/Sok-Jablkowy-Tloczony-Premium-4x5l.jpg" },
                    { 15, null, "From Poland", "Potato", 21m, null, "https://www.poradnia.pl/images/stories/artykuly/ziemniak.jpg" },
                    { 16, null, "From Poland", "Tomato", 23m, null, "https://profit.sklepkupiec.pl/17852-thickbox_default/pomidor-import.jpg" },
                    { 17, null, "From Poland", "Pumpkin", 16m, null, "https://www.carrefour.pl/images/product/org/dynia-wazona-nlctjl.jpg" },
                    { 18, "Brown", "Coat for men", "Coat", 689m, "M", "https://img01.ztat.net/article/spp-media-p1/6e81c667c70f3155b0851ea7f7ce6d1b/c82119333c6242c18428763270c25a17.jpg?imwidth=1800&filter=packshot" }
                });

            migrationBuilder.InsertData(
                table: "Shop",
                columns: new[] { "ShopId", "Description", "Email", "Level", "ShopName", "Url" },
                values: new object[,]
                {
                    { 1, "Clothes shop, t-shirts, trouser and hoodies!", "ClothesShop@gmail.com", "0", "Clothes Shop", "https://img.freepik.com/darmowe-wektory/recznie-rysowane-logo-sklepu-odziezowego_23-2149499592.jpg?w=2000" },
                    { 2, "Toys shop, teddy bears, LEGO and many more toys for you!", "ToysShop@gmail.com", "1", "Toys Shop", "https://st2.depositphotos.com/3687485/6431/v/950/depositphotos_64314213-stock-illustration-abstract-bear-toy-vector-logo.jpg" },
                    { 3, "Food shop, vegetables, fruits, fresh juice.", "FoodShop@gmail.com", "1", "Food Shop", "https://st4.depositphotos.com/12678588/23473/v/600/depositphotos_234736640-stock-illustration-food-logo-with-smile-label.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Shop_Items",
                columns: new[] { "Id", "ItemId", "ShopId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 2 },
                    { 7, 7, 2 },
                    { 8, 8, 2 },
                    { 9, 9, 2 },
                    { 10, 10, 2 },
                    { 11, 11, 2 },
                    { 12, 12, 3 },
                    { 13, 13, 3 },
                    { 14, 14, 3 },
                    { 15, 15, 3 },
                    { 16, 16, 3 },
                    { 17, 17, 3 },
                    { 18, 18, 1 }
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
                name: "IX_Shop_Items_ItemId",
                table: "Shop_Items",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_Items_ShopId",
                table: "Shop_Items",
                column: "ShopId");
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
                name: "Shop_Items");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Shop");
        }
    }
}
