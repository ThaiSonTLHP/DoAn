using Microsoft.EntityFrameworkCore.Migrations;

namespace BatDongSanId.Data.Migrations
{
    public partial class LuotXem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LuotXem",
                table: "TinBatDongSan",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LuotXem",
                table: "TinBatDongSan");
        }
    }
}
