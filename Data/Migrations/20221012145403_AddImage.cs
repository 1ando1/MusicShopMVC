using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Shop.Migrations
{
    public partial class AddImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            

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
                name: "ImagePath",
                table: "Guitars",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImagePath",
                value: "https://www.muztorg.ru/files/1dd/71t/qsp/928/gsw/4cw/soo/88c/c/1dd71tqsp928gsw4cwsoo88cc.jpg");

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImagePath",
                value: "https://www.muztorg.ru/files/1le/qe7/pgx/f6s/0s0/w40/og4/84s/w/1leqe7pgxf6s0s0w40og484sw.jpg");

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImagePath",
                value: "https://www.muztorg.ru/files/1rt/y8s/dbm/vhc/ks4/swg/4s4/o88/8/1rty8sdbmvhcks4swg4s4o888.jpeg");

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImagePath",
                value: "https://www.muztorg.ru/files/2rp/kok/xui/58g/gcw/04k/484/cg0/k/2rpkokxui58ggcw04k484cg0k.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Guitars");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Guitars",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Guitars",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://www.muztorg.ru/files/5tz/ng5/xpf/ows/k0g/gso/04c/0og/c/5tzng5xpfowsk0ggso04c0ogc.jpg");

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://www.muztorg.ru/files/5tz/ng5/xpf/ows/k0g/gso/04c/0og/c/5tzng5xpfowsk0ggso04c0ogc.jpg");

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://www.muztorg.ru/files/5tz/ng5/xpf/ows/k0g/gso/04c/0og/c/5tzng5xpfowsk0ggso04c0ogc.jpg");

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://www.muztorg.ru/files/5tz/ng5/xpf/ows/k0g/gso/04c/0og/c/5tzng5xpfowsk0ggso04c0ogc.jpg");
        }
    }
}
