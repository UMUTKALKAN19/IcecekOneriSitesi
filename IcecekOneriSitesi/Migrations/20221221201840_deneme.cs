using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IcecekOneriSitesi.Migrations
{
    public partial class deneme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminKadi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdminSifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Kategorilers",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategoriAdet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorilers", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Mesajlars",
                columns: table => new
                {
                    MesajID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesajGonderen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajBaslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MesajTarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesajlars", x => x.MesajID);
                });

            migrationBuilder.CreateTable(
                name: "Iceceklers",
                columns: table => new
                {
                    IcecekID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IcecekAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcecekMalzeme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcecekTarif = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcecekTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IcecekCesit = table.Column<bool>(type: "bit", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    KategorilerKategoriID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Iceceklers", x => x.IcecekID);
                    table.ForeignKey(
                        name: "FK_Iceceklers_Kategorilers_KategorilerKategoriID",
                        column: x => x.KategorilerKategoriID,
                        principalTable: "Kategorilers",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Yorumlars",
                columns: table => new
                {
                    YorumID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YorumSahip = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YorumTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    YorumOnay = table.Column<bool>(type: "bit", nullable: false),
                    YorumIcerik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcecekID = table.Column<int>(type: "int", nullable: false),
                    IceceklerIcecekID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yorumlars", x => x.YorumID);
                    table.ForeignKey(
                        name: "FK_Yorumlars_Iceceklers_IceceklerIcecekID",
                        column: x => x.IceceklerIcecekID,
                        principalTable: "Iceceklers",
                        principalColumn: "IcecekID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Iceceklers_KategorilerKategoriID",
                table: "Iceceklers",
                column: "KategorilerKategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_IceceklerIcecekID",
                table: "Yorumlars",
                column: "IceceklerIcecekID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Mesajlars");

            migrationBuilder.DropTable(
                name: "Yorumlars");

            migrationBuilder.DropTable(
                name: "Iceceklers");

            migrationBuilder.DropTable(
                name: "Kategorilers");
        }
    }
}
