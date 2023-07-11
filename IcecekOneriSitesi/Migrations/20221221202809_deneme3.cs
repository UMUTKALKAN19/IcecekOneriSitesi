using Microsoft.EntityFrameworkCore.Migrations;

namespace IcecekOneriSitesi.Migrations
{
    public partial class deneme3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iceceklers_Kategorilers_KategorilerKategoriID",
                table: "Iceceklers");

            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlars_Iceceklers_IceceklerIcecekID",
                table: "Yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_Yorumlars_IceceklerIcecekID",
                table: "Yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_Iceceklers_KategorilerKategoriID",
                table: "Iceceklers");

            migrationBuilder.DropColumn(
                name: "IcecekID",
                table: "Yorumlars");

            migrationBuilder.DropColumn(
                name: "IceceklerIcecekID",
                table: "Yorumlars");

            migrationBuilder.DropColumn(
                name: "KategoriID",
                table: "Iceceklers");

            migrationBuilder.DropColumn(
                name: "KategorilerKategoriID",
                table: "Iceceklers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IcecekID",
                table: "Yorumlars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IceceklerIcecekID",
                table: "Yorumlars",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KategoriID",
                table: "Iceceklers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "KategorilerKategoriID",
                table: "Iceceklers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_IceceklerIcecekID",
                table: "Yorumlars",
                column: "IceceklerIcecekID");

            migrationBuilder.CreateIndex(
                name: "IX_Iceceklers_KategorilerKategoriID",
                table: "Iceceklers",
                column: "KategorilerKategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Iceceklers_Kategorilers_KategorilerKategoriID",
                table: "Iceceklers",
                column: "KategorilerKategoriID",
                principalTable: "Kategorilers",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlars_Iceceklers_IceceklerIcecekID",
                table: "Yorumlars",
                column: "IceceklerIcecekID",
                principalTable: "Iceceklers",
                principalColumn: "IcecekID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
