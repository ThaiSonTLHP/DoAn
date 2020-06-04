using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BatDongSanId.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoiTin",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    MucPhi = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoiTin", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "HinhAnh",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    Anh = table.Column<byte[]>(nullable: true),
                    AnhChinh = table.Column<bool>(nullable: false),
                    TinBatDongSan = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HinhAnh", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Huong",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huong", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiBatDongSan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiBatDongSan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTaiKhoan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    ChucNang = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTaiKhoan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTinBatDongSan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTinBatDongSan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LoaiTinTuc",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    MoTa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiTinTuc", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MucDienTich",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MucDienTich", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MucGia",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ten = table.Column<string>(nullable: true),
                    Min = table.Column<double>(nullable: false),
                    Max = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MucGia", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "QuanHuyen",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Ten = table.Column<string>(nullable: true),
                    Loai = table.Column<string>(nullable: true),
                    TinhThanh = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanHuyen", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TaiKhoan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatKhau = table.Column<string>(nullable: true),
                    Ten = table.Column<string>(nullable: true),
                    GioiTinh = table.Column<bool>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    SoDienThoai = table.Column<string>(nullable: true),
                    DiaChi = table.Column<string>(nullable: true),
                    LoaiTaiKhoan = table.Column<int>(nullable: false),
                    SoDuVi = table.Column<double>(nullable: false),
                    XacThuc = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaiKhoan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TinBatDongSan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaiTin = table.Column<int>(nullable: false),
                    NgayDang = table.Column<DateTime>(nullable: false),
                    TrangThaiGiaoDich = table.Column<bool>(nullable: false),
                    TrangThaiDuyet = table.Column<bool>(nullable: false),
                    TrangThaiXacNhan = table.Column<bool>(nullable: false),
                    NguoiDang = table.Column<int>(nullable: false),
                    GoiTin = table.Column<int>(nullable: false),
                    LoaiBatDongSan = table.Column<int>(nullable: false),
                    TinhThanh = table.Column<string>(nullable: true),
                    QuanHuyen = table.Column<string>(nullable: true),
                    Gia = table.Column<string>(nullable: true),
                    MucGia = table.Column<int>(nullable: false),
                    DienTich = table.Column<string>(nullable: true),
                    MucDienTich = table.Column<int>(nullable: false),
                    Huong = table.Column<int>(nullable: false),
                    MoTa = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinBatDongSan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TinhThanh",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Ten = table.Column<string>(nullable: true),
                    Loai = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhThanh", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TinTuc",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TieuDe = table.Column<string>(nullable: true),
                    NgayDang = table.Column<DateTime>(nullable: false),
                    NguoiDang = table.Column<int>(nullable: false),
                    NoiDung = table.Column<string>(nullable: true),
                    LoaiTinTuc = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinTuc", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoiTin");

            migrationBuilder.DropTable(
                name: "HinhAnh");

            migrationBuilder.DropTable(
                name: "Huong");

            migrationBuilder.DropTable(
                name: "LoaiBatDongSan");

            migrationBuilder.DropTable(
                name: "LoaiTaiKhoan");

            migrationBuilder.DropTable(
                name: "LoaiTinBatDongSan");

            migrationBuilder.DropTable(
                name: "LoaiTinTuc");

            migrationBuilder.DropTable(
                name: "MucDienTich");

            migrationBuilder.DropTable(
                name: "MucGia");

            migrationBuilder.DropTable(
                name: "QuanHuyen");

            migrationBuilder.DropTable(
                name: "TaiKhoan");

            migrationBuilder.DropTable(
                name: "TinBatDongSan");

            migrationBuilder.DropTable(
                name: "TinhThanh");

            migrationBuilder.DropTable(
                name: "TinTuc");
        }
    }
}
