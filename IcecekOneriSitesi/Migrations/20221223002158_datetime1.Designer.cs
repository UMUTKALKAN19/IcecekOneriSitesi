﻿// <auto-generated />
using System;
using IcecekOneriSitesi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IcecekOneriSitesi.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221223002158_datetime1")]
    partial class datetime1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IcecekOneriSitesi.Models.Admin", b =>
                {
                    b.Property<int>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdminKadi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdminSifre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("IcecekOneriSitesi.Models.Icecek", b =>
                {
                    b.Property<int>("IcecekID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IcecekAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IcecekCesit")
                        .HasColumnType("bit");

                    b.Property<string>("IcecekMalzeme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IcecekTarif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IcecekTarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.HasKey("IcecekID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Iceceklers");
                });

            modelBuilder.Entity("IcecekOneriSitesi.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("KategoriAdet")
                        .HasColumnType("int");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategorilers");
                });

            modelBuilder.Entity("IcecekOneriSitesi.Models.Mesajlar", b =>
                {
                    b.Property<int>("MesajID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MesajBaslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajGonderen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MesajMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("MesajTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("MesajID");

                    b.ToTable("Mesajlars");
                });

            modelBuilder.Entity("IcecekOneriSitesi.Models.Yorum", b =>
                {
                    b.Property<int>("YorumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IcecekID")
                        .HasColumnType("int");

                    b.Property<string>("YorumIcerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YorumMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("YorumOnay")
                        .HasColumnType("bit");

                    b.Property<string>("YorumSahip")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YorumTarih")
                        .HasColumnType("datetime2");

                    b.HasKey("YorumID");

                    b.HasIndex("IcecekID");

                    b.ToTable("Yorumlars");
                });

            modelBuilder.Entity("IcecekOneriSitesi.Models.Icecek", b =>
                {
                    b.HasOne("IcecekOneriSitesi.Models.Kategori", "Kategori")
                        .WithMany("Icecekler")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("IcecekOneriSitesi.Models.Yorum", b =>
                {
                    b.HasOne("IcecekOneriSitesi.Models.Icecek", "Icecek")
                        .WithMany("Yorumlar")
                        .HasForeignKey("IcecekID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Icecek");
                });

            modelBuilder.Entity("IcecekOneriSitesi.Models.Icecek", b =>
                {
                    b.Navigation("Yorumlar");
                });

            modelBuilder.Entity("IcecekOneriSitesi.Models.Kategori", b =>
                {
                    b.Navigation("Icecekler");
                });
#pragma warning restore 612, 618
        }
    }
}