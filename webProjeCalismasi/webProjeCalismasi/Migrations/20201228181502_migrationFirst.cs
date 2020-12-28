using Microsoft.EntityFrameworkCore.Migrations;

namespace webProjeCalismasi.Migrations
{
    public partial class migrationFirst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryIsmi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    KullaniciId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kullaniciAdi = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    kullaniciSoyAdi = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    kullaniciAdresi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    kullaniciTelNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    kullaniciMailAdresi = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.KullaniciId);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    KitaplarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    kitapIsmi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    kitapFiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    kitapResimUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    kitapSayfaSayisi = table.Column<int>(type: "int", nullable: false),
                    KategoriCategoryId = table.Column<int>(type: "int", nullable: false),
                    KullanıcıKullaniciId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplar", x => x.KitaplarId);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Category_KategoriCategoryId",
                        column: x => x.KategoriCategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Kitaplar_Kullanici_KullanıcıKullaniciId",
                        column: x => x.KullanıcıKullaniciId,
                        principalTable: "Kullanici",
                        principalColumn: "KullaniciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KategoriCategoryId",
                table: "Kitaplar",
                column: "KategoriCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KullanıcıKullaniciId",
                table: "Kitaplar",
                column: "KullanıcıKullaniciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Kullanici");
        }
    }
}
