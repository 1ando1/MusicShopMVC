using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Shop.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Guitars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guitars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "Id", "Name", "Price", "Type" },
                values: new object[,]
                {
                    { 1, "Yamaha F310", 340f, "Western" },
                    { 2, "Rockdale Aurora D1", 130f, "Dreadnought" },
                    { 3, "Crafter D-7", 600f, "Dreadnought" },
                    { 4, "Fender CD", 790f, "Dreadnought" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guitars");
        }
    }
}
