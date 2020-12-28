using Microsoft.EntityFrameworkCore.Migrations;

namespace webProjeCalismasi.Migrations
{
    public partial class migrationaa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriCategoryId",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullanıcıKullaniciId",
                table: "Kitaplar");

            migrationBuilder.DropIndex(
                name: "IX_Kitaplar_KategoriCategoryId",
                table: "Kitaplar");

            migrationBuilder.DropIndex(
                name: "IX_Kitaplar_KullanıcıKullaniciId",
                table: "Kitaplar");

            migrationBuilder.RenameColumn(
                name: "KullanıcıKullaniciId",
                table: "Kitaplar",
                newName: "KullanıcıId");

            migrationBuilder.RenameColumn(
                name: "KategoriCategoryId",
                table: "Kitaplar",
                newName: "KategoriId");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Kitaplar",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KullaniciId",
                table: "Kitaplar",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_CategoryId",
                table: "Kitaplar",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KullaniciId",
                table: "Kitaplar",
                column: "KullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kategoriler_CategoryId",
                table: "Kitaplar",
                column: "CategoryId",
                principalTable: "Kategoriler",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullaniciId",
                table: "Kitaplar",
                column: "KullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kategoriler_CategoryId",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullaniciId",
                table: "Kitaplar");

            migrationBuilder.DropIndex(
                name: "IX_Kitaplar_CategoryId",
                table: "Kitaplar");

            migrationBuilder.DropIndex(
                name: "IX_Kitaplar_KullaniciId",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "KullaniciId",
                table: "Kitaplar");

            migrationBuilder.RenameColumn(
                name: "KullanıcıId",
                table: "Kitaplar",
                newName: "KullanıcıKullaniciId");

            migrationBuilder.RenameColumn(
                name: "KategoriId",
                table: "Kitaplar",
                newName: "KategoriCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KategoriCategoryId",
                table: "Kitaplar",
                column: "KategoriCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_KullanıcıKullaniciId",
                table: "Kitaplar",
                column: "KullanıcıKullaniciId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriCategoryId",
                table: "Kitaplar",
                column: "KategoriCategoryId",
                principalTable: "Kategoriler",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullanıcıKullaniciId",
                table: "Kitaplar",
                column: "KullanıcıKullaniciId",
                principalTable: "Kullanicilar",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
