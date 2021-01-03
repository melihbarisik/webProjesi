﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace webProjeV2.Data.Migrations
{
    public partial class migUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DogumTarihi",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "KullaniciAdVeSoyad",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KullaniciCinsiyet",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DogumTarihi",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "KullaniciAdVeSoyad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "KullaniciCinsiyet",
                table: "AspNetUsers");
        }
    }
}
