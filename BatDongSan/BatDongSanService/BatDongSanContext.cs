using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanService.Models;

namespace BatDongSanService
{
    public class BatDongSanContext : DbContext
    {
        public BatDongSanContext(DbContextOptions<BatDongSanContext> options) : base(options)
        {

        }
        public DbSet<TinTuc> TinTuc { get; set; }
        public DbSet<LoaiTinTuc> LoaiTinTuc { get; set; }
        public DbSet<TkQuanTri> TKQuanTri { get; set; }
        public DbSet<TkNhaMoiGioi> TKNhaMoiGioi { get; set; }
        public DbSet<TkNguoiMua> TKNguoiMua { get; set; }
        public DbSet<TinRao> TinRao { get; set; }
        public DbSet<TinMua> TinMua { get; set; }
        public DbSet<Huong> Huong { get; set; }
        public DbSet<TinhThanh> TinhThanh { get; set; }
        public DbSet<QuanHuyen> QuanHuyen { get; set; }
        public DbSet<HinhThucGiaoDich> HinhThucGiaoDich { get; set; }
        public DbSet<LoaiBatDongSan> LoaiBatDongSan { get; set; }
        public DbSet<LoaiTinRao> LoaiTinRao { get; set; }
        public DbSet<DienTich> DienTich { get; set; }
        public DbSet<MucGia> MucGia { get; set; }
    }
}
