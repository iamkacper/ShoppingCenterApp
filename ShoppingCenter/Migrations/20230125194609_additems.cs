using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ShoppingCenter.Migrations
{
    /// <inheritdoc />
    public partial class additems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "AvailabilityItem", "PriceItem", "Url" },
                values: new object[] { 0, 49m, "https://sklep.lahtipro.pl/1355-thickbox_default/koszulka-t-shirt-bawelniana-biala-lahti-pro-l40204.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "AvailabilityItem", "PriceItem", "Url" },
                values: new object[] { 0, 49m, "https://sklep.lahtipro.pl/1281-large_default/koszulka-t-shirt-bawelniana-czarna-lahtipro-l40205.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "AvailabilityItem", "PriceItem", "Url" },
                values: new object[] { 0, 89m, "https://duzylolek.pl/userdata/public/gfx/6120/koszulka-t-shirt-duze-rozmiary-3XL-4XL-5XL-Adamo-modna-wygodna-dla-mezczyzn-plus-size-napisy-6XL-7XL-8XL-9XL-10XL-12XL.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "AvailabilityItem", "PriceItem", "Url" },
                values: new object[] { 0, 89m, "https://image-resizing.booztcdn.com/selected-homme/sel16051390_cblack_v179099.webp?has_grey=1&has_webp=0&size=w1300" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "AvailabilityItem", "PriceItem", "SizeItem", "Url" },
                values: new object[] { 0, 399m, "L", "https://dankyshop.pl/wp-content/uploads/2022/12/2-1.png" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "AvailabilityItem", "ColorItem", "PriceItem", "SizeItem", "Url" },
                values: new object[] { 0, null, 3159m, "7541 bricks", "https://prod-api.mediaexpert.pl/api/images/gallery_500_500/thumbnails/images/27/2746003/LEGO-Star-Wars-Sokol-Millennium-75192-pudelko-zestaw.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                columns: new[] { "AvailabilityItem", "ColorItem", "PriceItem", "SizeItem", "Url" },
                values: new object[] { 0, null, 389m, "834", "https://m.media-amazon.com/images/I/611NGqFr1JL._AC_SX522_.jpg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                columns: new[] { "AvailabilityItem", "ColorItem", "NameItem", "PriceItem", "SizeItem", "Url" },
                values: new object[] { 0, null, "TEDDY BEAR", 39m, "60cm", "https://target.scene7.com/is/image/Target/GUEST_27556c59-356f-44c0-9142-0bf4465e116c?wid=488&hei=488&fmt=pjpeg" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                columns: new[] { "AvailabilityItem", "ColorItem", "NameItem", "PriceItem", "SizeItem", "Url" },
                values: new object[] { 0, null, "TEDDY BEAR", 99m, "120cm", "https://cdn.shopify.com/s/files/1/0073/4740/4882/products/IMG_0476_0e28708a-6fc1-4c8a-afb1-43ce0924b52d_2592x.jpg?v=1630514970" });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ItemId", "AvailabilityItem", "ColorItem", "DescriptionItem", "NameItem", "PriceItem", "SizeItem", "Url" },
                values: new object[,]
                {
                    { 10, 0, null, null, "DOLL", 189m, "40cm", "https://image.ceneostatic.pl/data/article_picture/31/d6/7d6d-6663-4ca2-96de-f3ca303412c6_large.png" },
                    { 11, 0, null, null, "PLUSH BALL", 56m, "M", "https://a.allegroimg.com/s1024/0cbed4/dfcc714144feb7d863cacfa4b2c9" },
                    { 12, 0, null, null, "Banana", 2m, null, "https://media.istockphoto.com/id/619046500/pl/zdj%C4%99cie/banany.jpg?s=612x612&w=0&k=20&c=44UgqVhiRpE94HbvM2-3i3VrZnRS_cLYdYOroV8LTIo=" },
                    { 13, 0, null, null, "Apple", 1m, null, "https://images.pexels.com/photos/102104/pexels-photo-102104.jpeg" },
                    { 14, 0, null, null, "Apple juice", 5m, null, "https://wspolceznatura.pl/userdata/public/gfx/2125/Sok-Jablkowy-Tloczony-Premium-4x5l.jpg" },
                    { 15, 0, null, null, "Potato", 21m, null, "https://www.poradnia.pl/images/stories/artykuly/ziemniak.jpg" },
                    { 16, 0, null, null, "Tomato", 23m, null, "https://profit.sklepkupiec.pl/17852-thickbox_default/pomidor-import.jpg" },
                    { 17, 0, null, null, "Pumpkin", 16m, null, "https://www.carrefour.pl/images/product/org/dynia-wazona-nlctjl.jpg" },
                    { 18, 0, "Brown", null, "Coat", 689m, "M", "https://img01.ztat.net/article/spp-media-p1/6e81c667c70f3155b0851ea7f7ce6d1b/c82119333c6242c18428763270c25a17.jpg?imwidth=1800&filter=packshot" }
                });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 3,
                column: "ShopName",
                value: "Food Shop");

            migrationBuilder.UpdateData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "ShopId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 9,
                column: "ShopId",
                value: 2);

            migrationBuilder.InsertData(
                table: "Shop_Items",
                columns: new[] { "Id", "ItemId", "ShopId" },
                values: new object[,]
                {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "AvailabilityItem", "PriceItem", "Url" },
                values: new object[] { 5, 59m, "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "AvailabilityItem", "PriceItem", "Url" },
                values: new object[] { 7, 65m, "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "AvailabilityItem", "PriceItem", "Url" },
                values: new object[] { 5, 79m, "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "AvailabilityItem", "PriceItem", "Url" },
                values: new object[] { 5, 99m, "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "AvailabilityItem", "PriceItem", "SizeItem", "Url" },
                values: new object[] { 5, 129m, "44", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "AvailabilityItem", "ColorItem", "PriceItem", "SizeItem", "Url" },
                values: new object[] { 5, "White", 59m, "1000 bricks", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                columns: new[] { "AvailabilityItem", "ColorItem", "PriceItem", "SizeItem", "Url" },
                values: new object[] { 5, "White", 59m, "S", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                columns: new[] { "AvailabilityItem", "ColorItem", "NameItem", "PriceItem", "SizeItem", "Url" },
                values: new object[] { 5, "White", "banana", 59m, "S", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                columns: new[] { "AvailabilityItem", "ColorItem", "NameItem", "PriceItem", "SizeItem", "Url" },
                values: new object[] { 5, "White", "apple", 59m, "S", "https://images.pexels.com/photos/639024/pexels-photo-639024.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1" });

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 3,
                column: "ShopName",
                value: "Toys Shop");

            migrationBuilder.UpdateData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 8,
                column: "ShopId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Shop_Items",
                keyColumn: "Id",
                keyValue: 9,
                column: "ShopId",
                value: 3);
        }
    }
}
