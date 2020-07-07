using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BatDongSanId.Data.Migrations
{
    public partial class NgayXacNhan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestDB",
                table: "TinTuc");

            migrationBuilder.AddColumn<DateTime>(
                name: "NgayXacNhan",
                table: "TinBatDongSan",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayXacNhan",
                table: "TinBatDongSan");

            migrationBuilder.AddColumn<int>(
                name: "TestDB",
                table: "TinTuc",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
