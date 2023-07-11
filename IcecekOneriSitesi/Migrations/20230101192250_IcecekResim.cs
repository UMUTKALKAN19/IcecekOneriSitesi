using Microsoft.EntityFrameworkCore.Migrations;

namespace IcecekOneriSitesi.Migrations
{
    public partial class IcecekResim : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IcecekResim",
                table: "Iceceklers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IcecekResim",
                table: "Iceceklers");
        }
    }
}
