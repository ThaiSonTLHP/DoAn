using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BatDongSanId.Data.Migrations
{
    public partial class LuuTinAndAvt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "AnhDaiDien",
                table: "TaiKhoan",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "LuuTinBatDongSan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaiKhoan = table.Column<int>(nullable: false),
                    TinBatDongSan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LuuTinBatDongSan", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LuuTinBatDongSan");

            migrationBuilder.DropColumn(
                name: "AnhDaiDien",
                table: "TaiKhoan");
        }
    }
}
