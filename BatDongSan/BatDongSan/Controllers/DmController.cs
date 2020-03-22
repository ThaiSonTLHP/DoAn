using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSan.Models.ListViewModels;
using BatDongSan.Models.ViewModels;
using BatDongSanService;
using Microsoft.AspNetCore.Mvc;

namespace BatDongSan.Controllers
{
    public class DmController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public DmController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var _tinBan = (from t in _dbContext.TinRao
                           join h in _dbContext.HinhThucGiaoDich on t.HinhThucGiaoDichId equals h.Id
                           join nmg in _dbContext.TKNhaMoiGioi on t.NhaMoiGioiId equals nmg.Id
                           join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSanId equals lbds.Id
                           join tt in _dbContext.TinhThanh on t.TinhThanhId equals tt.Id
                           join qh in _dbContext.QuanHuyen on t.TinhThanhId equals qh.Id
                           join hg in _dbContext.Huong on t.TinhThanhId equals hg.Id
                           where h.Ten == "Bán"
                           select new TinBanViewModel()
                           {
                               LienHe = nmg.SoDienThoai,
                               NgayDang = t.NgayDang,
                               LoaiBatDongSan = lbds.Ten,
                               TinhThanh = tt.Ten,
                               QuanHuyen = qh.Ten,
                               Gia = t.Gia,
                               DienTich = t.DienTich,
                               Huong = hg.Ten,
                               MoTa = t.MoTa
                           }).ToList();
            return View(_tinBan);
        }

        public IActionResult TinChoThue()
        {
            var _tinBan = (from t in _dbContext.TinRao
                           join h in _dbContext.HinhThucGiaoDich on t.HinhThucGiaoDichId equals h.Id
                           join nmg in _dbContext.TKNhaMoiGioi on t.NhaMoiGioiId equals nmg.Id
                           join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSanId equals lbds.Id
                           join tt in _dbContext.TinhThanh on t.TinhThanhId equals tt.Id
                           join qh in _dbContext.QuanHuyen on t.TinhThanhId equals qh.Id
                           join hg in _dbContext.Huong on t.TinhThanhId equals hg.Id
                           where h.Ten == "Bán"
                           select new TinBanViewModel()
                           {
                               LienHe = nmg.SoDienThoai,
                               NgayDang = t.NgayDang,
                               LoaiBatDongSan = lbds.Ten,
                               TinhThanh = tt.Ten,
                               QuanHuyen = qh.Ten,
                               Gia = t.Gia,
                               DienTich = t.DienTich,
                               Huong = hg.Ten,
                               MoTa = t.MoTa
                           }).ToList();
            return View(_tinBan);
        }

        public IActionResult TinMua()
        {
            return View();
        }

        public IActionResult TinThue()
        {
            return View();
        }

        public IActionResult NhaMoiGioi()
        {
            return View();
        }

        public IActionResult Search(string tinhThanhOption, string hinhThucOption, string mucGiaOption, string loaiOption)
        {
            var listTimKiem = new TrangChuListViewModel();
            if (hinhThucOption == "Bán" || hinhThucOption == "Cho Thuê")
            {
                listTimKiem.TinBanViewModels = (from t in _dbContext.TinRao
                                                join h in _dbContext.HinhThucGiaoDich on t.HinhThucGiaoDichId equals h.Id
                                                join nmg in _dbContext.TKNhaMoiGioi on t.NhaMoiGioiId equals nmg.Id
                                                join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSanId equals lbds.Id
                                                join tt in _dbContext.TinhThanh on t.TinhThanhId equals tt.Id
                                                join qh in _dbContext.QuanHuyen on t.TinhThanhId equals qh.Id
                                                join hg in _dbContext.Huong on t.TinhThanhId equals hg.Id
                                                where h.Ten == hinhThucOption
                                                && tt.Ten == tinhThanhOption
                                                && lbds.Ten == loaiOption
                                                select new TinBanViewModel()
                                                {
                                                    LienHe = nmg.SoDienThoai,
                                                    NgayDang = t.NgayDang,
                                                    LoaiBatDongSan = lbds.Ten,
                                                    TinhThanh = tt.Ten,
                                                    QuanHuyen = qh.Ten,
                                                    Gia = t.Gia,
                                                    DienTich = t.DienTich,
                                                    Huong = hg.Ten,
                                                    MoTa = t.MoTa
                                                }).ToList();
            }
            if (hinhThucOption == "Mua" || hinhThucOption == "Thuê")
            {
                listTimKiem.TinMuaViewModels = (from t in _dbContext.TinMua
                                                join h in _dbContext.HinhThucGiaoDich on t.HinhThucGiaoDichId equals h.Id
                                                join nm in _dbContext.TKNguoiMua on t.NguoiMuaId equals nm.Id
                                                join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSanId equals lbds.Id
                                                join tt in _dbContext.TinhThanh on t.TinhThanhId equals tt.Id
                                                join qh in _dbContext.QuanHuyen on t.TinhThanhId equals qh.Id
                                                join hg in _dbContext.Huong on t.TinhThanhId equals hg.Id
                                                where h.Ten == hinhThucOption
                                                && tt.Ten == tinhThanhOption
                                                && lbds.Ten == loaiOption
                                                select new TinMuaViewModel()
                                                {
                                                    LienHe = nm.SoDienThoai,
                                                    NgayDang = t.NgayDang,
                                                    LoaiBatDongSan = lbds.Ten,
                                                    TinhThanh = tt.Ten,
                                                    QuanHuyen = qh.Ten,
                                                    Gia = t.Gia,
                                                    DienTich = t.DienTich,
                                                    Huong = hg.Ten,
                                                    MoTa = t.MoTa
                                                }).ToList();
            }
            return View(listTimKiem);
        }
    }
}