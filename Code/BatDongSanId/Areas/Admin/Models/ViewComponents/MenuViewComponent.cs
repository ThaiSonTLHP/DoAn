using BatDongSanId.Areas.Admin.Models.ViewModel;
using BatDongSanId.Data;
using BatDongSanId.Methods;
using BatDongSanId.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Admin.Models.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;

        public MenuViewComponent(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            MenuViewModel menu = new MenuViewModel();
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            menu.Logo = await dbContext.CauHinh.FirstOrDefaultAsync(x => x.Ten == "Logo");
            string anhBase64Data = Convert.ToBase64String(menu.Logo.Anh);
            menu.Logo.DuLieuString = string.Format("data:image/jpg;base64,{0}", anhBase64Data);
            menu.TaiKhoan = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "TaiKhoan");
            menu.DanhSachTaiKhoan = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "DanhSachTaiKhoan");
            menu.LoaiTaiKhoan = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "LoaiTaiKhoan");

            menu.TinBatDongSan = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "TinBatDongSan");
            menu.TatCa = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "TatCa");
            menu.ChuaDuyet = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "ChuaDuyet");
            menu.ChuaXacThuc = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "ChuaXacThuc");
            menu.DaGiaoDich = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "DaGiaoDich");
            menu.PhanHoi = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "PhanHoi");

            menu.TinTuc = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "TinTuc");
            menu.SubTinTuc = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "SubTinTuc");
            menu.VietBai = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "VietBai");

            menu.DanhMuc = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "DanhMuc");
            menu.LoaiTinBDS = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "LoaiTinBDS");
            menu.LoaiTinTuc = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "LoaiTinTuc");
            menu.TinhThanh = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "TinhThanh");
            menu.QuanHuyen = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "QuanHuyen");
            menu.MucGia = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "MucGia");
            menu.MucDienTich = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "MucDienTich");
            menu.LoaiBatDongSan = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "LoaiBatDongSan");
            menu.GoiTin = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "GoiTin");
            menu.Huong = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "Huong");
            return View(menu);
        }
    }
}
