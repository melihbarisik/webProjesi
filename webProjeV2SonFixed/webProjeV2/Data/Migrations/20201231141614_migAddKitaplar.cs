using Microsoft.EntityFrameworkCore.Migrations;

namespace webProjeV2.Data.Migrations
{
    public partial class migAddKitaplar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    KitapId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kitapIsmi = table.Column<string>(maxLength: 100, nullable: false),
                    kitapFiyat = table.Column<double>(nullable: false),
                    kitapResimUrl = table.Column<string>(maxLength: 250, nullable: false),
                    kitapSayfaSayisi = table.Column<int>(nullable: false),
                    kitapAciklama = table.Column<string>(nullable: false),
                    kitapKategori = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.KitapId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitaplar");
        }
    }
}
