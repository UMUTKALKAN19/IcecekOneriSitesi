using Microsoft.EntityFrameworkCore.Migrations;

namespace IcecekOneriSitesi.Migrations
{
    public partial class iliski2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateIndex(
                name: "IX_Yorumlars_IceceklerIcecekID",
                table: "Yorumlars",
                column: "IceceklerIcecekID");

            migrationBuilder.AddForeignKey(
                name: "FK_Yorumlars_Iceceklers_IceceklerIcecekID",
                table: "Yorumlars",
                column: "IceceklerIcecekID",
                principalTable: "Iceceklers",
                principalColumn: "IcecekID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Yorumlars_Iceceklers_IceceklerIcecekID",
                table: "Yorumlars");

            migrationBuilder.DropIndex(
                name: "IX_Yorumlars_IceceklerIcecekID",
                table: "Yorumlars");

            migrationBuilder.DropColumn(
                name: "IcecekID",
                table: "Yorumlars");

            migrationBuilder.DropColumn(
                name: "IceceklerIcecekID",
                table: "Yorumlars");
        }
    }
}
