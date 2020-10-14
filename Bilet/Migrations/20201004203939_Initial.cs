using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bilet.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Bilet",
                columns: table => new
                {
                    BiletID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    Soyisim = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    Aktivite = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    BiletTarihi = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Bilet", x => x.BiletID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Bilet");
        }
    }
}
