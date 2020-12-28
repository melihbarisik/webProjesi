﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webProjeCalismasi.Models;

namespace webProjeCalismasi.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20201228205753_migration6")]
    partial class migration6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("webProjeCalismasi.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryIsmi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CategoryId");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("webProjeCalismasi.Models.Entity.Kullanici", b =>
                {
                    b.Property<int>("KullaniciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("kullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("kullaniciAdresi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("kullaniciMailAdresi")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("kullaniciSoyAdi")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("kullaniciTelNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("KullaniciId");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("webProjeCalismasi.Models.Kitaplar", b =>
                {
                    b.Property<int>("KitaplarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<decimal>("kitapFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("kitapIsmi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("kitapResimUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("kitapSayfaSayisi")
                        .HasColumnType("int");

                    b.HasKey("KitaplarId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Kitaplar");
                });

            modelBuilder.Entity("webProjeCalismasi.Models.Kitaplar", b =>
                {
                    b.HasOne("webProjeCalismasi.Models.Category", "Ka")
                        .WithMany("Kitaplar")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webProjeCalismasi.Models.Entity.Kullanici", "Ku")
                        .WithMany("Kitaplar")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ka");

                    b.Navigation("Ku");
                });

            modelBuilder.Entity("webProjeCalismasi.Models.Category", b =>
                {
                    b.Navigation("Kitaplar");
                });

            modelBuilder.Entity("webProjeCalismasi.Models.Entity.Kullanici", b =>
                {
                    b.Navigation("Kitaplar");
                });
#pragma warning restore 612, 618
        }
    }
}