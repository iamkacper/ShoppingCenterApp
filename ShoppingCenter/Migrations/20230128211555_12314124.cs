using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingCenter.Migrations
{
    /// <inheritdoc />
    public partial class _12314124 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShopName",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 1,
                column: "Url",
                value: "https://img.freepik.com/darmowe-wektory/recznie-rysowane-logo-sklepu-odziezowego_23-2149499592.jpg?w=2000");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 2,
                column: "Url",
                value: "https://st2.depositphotos.com/3687485/6431/v/950/depositphotos_64314213-stock-illustration-abstract-bear-toy-vector-logo.jpg");

            migrationBuilder.UpdateData(
                table: "Shop",
                keyColumn: "ShopId",
                keyValue: 3,
                column: "Url",
                value: "https://st4.depositphotos.com/12678588/23473/v/600/depositphotos_234736640-stock-illustration-food-logo-with-smile-label.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Shop");

            migrationBuilder.AlterColumn<string>(
                name: "ShopName",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
