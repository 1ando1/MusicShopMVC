using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Shop.Migrations
{
    public partial class UpdateExtraProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExtraProductsId",
                table: "Guitars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ExtraProductsId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 2,
                column: "ExtraProductsId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 3,
                column: "ExtraProductsId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 4,
                column: "ExtraProductsId",
                value: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraProductsId",
                table: "Guitars");
        }
    }
}
