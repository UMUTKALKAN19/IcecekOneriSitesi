using Microsoft.EntityFrameworkCore.Migrations;

namespace IcecekOneriSitesi.Migrations
{
    public partial class kategoriduzenleme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "KategoriAciklama",
                table: "Kategorilers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "KategoriDurum",
                table: "Kategorilers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KategoriAciklama",
                table: "Kategorilers");

            migrationBuilder.DropColumn(
                name: "KategoriDurum",
                table: "Kategorilers");
        }
    }
}
