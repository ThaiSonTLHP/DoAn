using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BatDongSanId.Data.Migrations
{
    public partial class NgayLenBangTin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NgayLenBangTin",
                table: "TinBatDongSan",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayLenBangTin",
                table: "TinBatDongSan");
        }
    }
}
