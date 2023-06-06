using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Shop.Migrations
{
    public partial class AddAttributes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Guitars",
                type: "nvarchar(70)",
                maxLength: 70,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Guitars",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Guitars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Color",
                value: "White");

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Color",
                value: "Black");

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Color",
                value: "Brown");

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Color",
                value: "Orange");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Guitars");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Guitars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)",
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Guitars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);
        }
    }
}
