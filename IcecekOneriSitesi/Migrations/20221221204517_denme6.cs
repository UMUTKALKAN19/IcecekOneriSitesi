using Microsoft.EntityFrameworkCore.Migrations;

namespace IcecekOneriSitesi.Migrations
{
    public partial class denme6 : Migration
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
                name: "IceceklerIcecekID",
                table: "Yorumlars");

            migrationBuilder.DropColumn(
                name: "KategorilerKategoriID",
                table: "Iceceklers");

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_IcecekID",
                table: "Yorumlars",
                column: "IcecekID");

            migrationBuilder.CreateIndex(
                name: "IX_Iceceklers_KategoriID",
                table: "Iceceklers",
                column: "KategoriID");

            migrationBuilder.AddForeignKey(
                name: "FK_Iceceklers_Kategorilers_KategoriID",
                table: "Iceceklers",
                column: "KategoriID",
                principalTable: "Kategorilers",
                principalColumn: "KategoriID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlars_Iceceklers_IcecekID",
                table: "Yorumlars",
                column: "IcecekID",
                principalTable: "Iceceklers",
                principalColumn: "IcecekID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iceceklers_Kategorilers_KategoriID",
                table: "Iceceklers");

            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlars_Iceceklers_IcecekID",
                table: "Yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_Yorumlars_IcecekID",
                table: "Yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_Iceceklers_KategoriID",
                table: "Iceceklers");

            migrationBuilder.AddColumn<int>(
                name: "IceceklerIcecekID",
                table: "Yorumlars",
                type: "int",
                nullable: true);

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
