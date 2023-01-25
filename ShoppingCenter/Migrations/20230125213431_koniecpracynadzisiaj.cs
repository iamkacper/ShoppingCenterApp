using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCenter.Migrations
{
    /// <inheritdoc />
    public partial class koniecpracynadzisiaj : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailabilityItem",
                table: "Items");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                column: "DescriptionItem",
                value: "Unisex t-shirt");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                column: "DescriptionItem",
                value: "Unisex t-shirt");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                column: "DescriptionItem",
                value: "T-shirt for men");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                column: "DescriptionItem",
                value: "Trousers for men");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                column: "DescriptionItem",
                value: "Jacket for men");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                column: "DescriptionItem",
                value: "Brick for children from 12 years of age.");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                column: "DescriptionItem",
                value: "Brick for children from 12 years of age.");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                column: "DescriptionItem",
                value: "A great gift for a child");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                column: "DescriptionItem",
                value: "A great gift for a child");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10,
                column: "DescriptionItem",
                value: "A great gift for a girl");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11,
                column: "DescriptionItem",
                value: "A great gift for a future footballer");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                column: "DescriptionItem",
                value: "Healthy, not sprayed");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                column: "DescriptionItem",
                value: "From a Polish orchard");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                column: "DescriptionItem",
                value: "From a Polish orchard");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                column: "DescriptionItem",
                value: "From Poland");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                column: "DescriptionItem",
                value: "From Poland");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                column: "DescriptionItem",
                value: "From Poland");

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                column: "DescriptionItem",
                value: "Coat for men");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvailabilityItem",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 1,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 2,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 3,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 4,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 5,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 6,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 7,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 8,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 9,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 10,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 11,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 12,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 13,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 14,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 15,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 16,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 17,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ItemId",
                keyValue: 18,
                columns: new[] { "AvailabilityItem", "DescriptionItem" },
                values: new object[] { 0, null });
        }
    }
}
