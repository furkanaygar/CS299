using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilet.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BiletSayisi",
                table: "Tbl_Bilet",
                unicode: false,
                maxLength: 150,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BiletSayisi",
                table: "Tbl_Bilet");
        }
    }
}
