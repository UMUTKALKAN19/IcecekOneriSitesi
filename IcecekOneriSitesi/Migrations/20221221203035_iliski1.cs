using Microsoft.EntityFrameworkCore.Migrations;

namespace IcecekOneriSitesi.Migrations
{
    public partial class iliski1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Iceceklers_Kategorilers_KategorilerKategoriID",
                table: "Iceceklers");

            migrationBuilder.DropIndex(
                name: "IX_Iceceklers_KategorilerKategoriID",
                table: "Iceceklers");

            migrationBuilder.DropColumn(
                name: "KategoriID",
                table: "Iceceklers");

            migrationBuilder.DropColumn(
                name: "KategorilerKategoriID",
                table: "Iceceklers");
        }
    }
}
