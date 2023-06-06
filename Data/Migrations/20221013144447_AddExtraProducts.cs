using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Shop.Migrations
{
    public partial class AddExtraProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExtraProductId",
                table: "Guitars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ExtraProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraProducts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ExtraProducts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Extra strings" },
                    { 2, "Pack of mediators (5 pieces)" },
                    { 3, "Pack of mediators (15 pieces)" },
                    { 4, "Extra strings + pack of mediators (5 pieces)" },
                    { 5, "Extra strings + pack of mediators (15 pieces)" },
                    { 6, "2 packs of extra strings" },
                    { 7, "5 packs of extra strings" },
                    { 8, "2 packs of extra strings + pack of mediators (5 pieces)" },
                    { 9, "2 packs of extra strings + pack of mediators (15 pieces)" },
                    { 10, "5 packs of extra strings + pack of mediators (5 pieces)" },
                    { 11, "5 packs of extra strings + pack of mediators (15 pieces)" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guitars_ExtraProductId",
                table: "Guitars",
                column: "ExtraProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guitars_ExtraProducts_ExtraProductId",
                table: "Guitars",
                column: "ExtraProductId",
                principalTable: "ExtraProducts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guitars_ExtraProducts_ExtraProductId",
                table: "Guitars");

            migrationBuilder.DropTable(
                name: "ExtraProducts");

            migrationBuilder.DropIndex(
                name: "IX_Guitars_ExtraProductId",
                table: "Guitars");

            migrationBuilder.DropColumn(
                name: "ExtraProductId",
                table: "Guitars");
        }
    }
}
