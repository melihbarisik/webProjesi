using Microsoft.EntityFrameworkCore.Migrations;

namespace webProjeCalismasi.Migrations
{
    public partial class migrationa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Category_KategoriCategoryId",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kullanici_KullanıcıKullaniciId",
                table: "Kitaplar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kullanici",
                table: "Kullanici");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Kullanici",
                newName: "Kullanicilar");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Kategoriler");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kullanicilar",
                table: "Kullanicilar",
                column: "KullaniciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kategoriler",
                table: "Kategoriler",
                column: "CategoryId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kategoriler_KategoriCategoryId",
                table: "Kitaplar");

            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Kullanicilar_KullanıcıKullaniciId",
                table: "Kitaplar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kullanicilar",
                table: "Kullanicilar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Kategoriler",
                table: "Kategoriler");

            migrationBuilder.RenameTable(
                name: "Kullanicilar",
                newName: "Kullanici");

            migrationBuilder.RenameTable(
                name: "Kategoriler",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Kullanici",
                table: "Kullanici",
                column: "KullaniciId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Category_KategoriCategoryId",
                table: "Kitaplar",
                column: "KategoriCategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Kullanici_KullanıcıKullaniciId",
                table: "Kitaplar",
                column: "KullanıcıKullaniciId",
                principalTable: "Kullanici",
                principalColumn: "KullaniciId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
