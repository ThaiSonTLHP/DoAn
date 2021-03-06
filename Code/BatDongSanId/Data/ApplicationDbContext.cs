﻿using System;
using System.Collections.Generic;
using System.Text;
using BatDongSanId.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BatDongSanId.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<TinTuc> TinTuc { get; set; }
        public DbSet<LoaiTinTuc> LoaiTinTuc { get; set; }
        public DbSet<TaiKhoan> TaiKhoan { get; set; }
        public DbSet<LoaiTaiKhoan> LoaiTaiKhoan { get; set; }
        public DbSet<TinBatDongSan> TinBatDongSan { get; set; }
        public DbSet<HinhAnh> HinhAnh { get; set; }
        public DbSet<Huong> Huong { get; set; }
        public DbSet<TinhThanh> TinhThanh { get; set; }
        public DbSet<QuanHuyen> QuanHuyen { get; set; }
        public DbSet<LoaiTinBatDongSan> LoaiTinBatDongSan { get; set; }
        public DbSet<LoaiBatDongSan> LoaiBatDongSan { get; set; }
        public DbSet<GoiTin> GoiTin { get; set; }
        public DbSet<MucDienTich> MucDienTich { get; set; }
        public DbSet<MucGia> MucGia { get; set; }
        public DbSet<LuuTinBatDongSan> LuuTinBatDongSan { get; set; }
        public DbSet<BaoCao> BaoCao { get; set; }
        public DbSet<CauHinh> CauHinh { get; set; }
    }
}
