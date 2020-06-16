using Microsoft.EntityFrameworkCore.Migrations;

namespace BatDongSanId.Data.Migrations
{
    public partial class ThemTestDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TestDB",
                table: "TinTuc",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestDB",
                table: "TinTuc");
        }
    }
}
