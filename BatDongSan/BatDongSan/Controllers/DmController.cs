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
            var _tinBan = (from t in _dbContext.TinBatDongSan
                           join lt in _dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                           join nd in _dbContext.NguoiDung on t.NguoiDang equals nd.ID
                           join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                           join tt in _dbContext.TinhThanh on t.TinhThanh equals tt.ID
                           join qh in _dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                           join mg in _dbContext.MucGia on t.MucGia equals mg.ID
                           join mdt in _dbContext.MucDienTich on t.MucDienTich equals mdt.ID
                           join h in _dbContext.Huong on t.Huong equals h.ID
                           where lt.Ten == "Bán"
                           select new TinBanViewModel()
                           {
                               LienHe = nd.SoDienThoai,
                               NgayDang = t.NgayDang,
                               LoaiBatDongSan = lbds.Ten,
                               TinhThanh = tt.Ten,
                               QuanHuyen = qh.Ten,
                               Gia = t.Gia,
                               DienTich = t.DienTich,
                               Huong = h.Ten,
                               MoTa = t.MoTa
                           }).ToList();
            return View(_tinBan);
        }

        public IActionResult TinChoThue()
        {
            var _tinBan = (from t in _dbContext.TinBatDongSan
                           join lt in _dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                           join nd in _dbContext.NguoiDung on t.NguoiDang equals nd.ID
                           join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                           join tt in _dbContext.TinhThanh on t.TinhThanh equals tt.ID
                           join qh in _dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                           join mg in _dbContext.MucGia on t.MucGia equals mg.ID
                           join mdt in _dbContext.MucDienTich on t.MucDienTich equals mdt.ID
                           join h in _dbContext.Huong on t.Huong equals h.ID
                           where h.Ten == "Bán"
                           select new TinBanViewModel()
                           {
                               LienHe = nd.SoDienThoai,
                               NgayDang = t.NgayDang,
                               LoaiBatDongSan = lbds.Ten,
                               TinhThanh = tt.Ten,
                               QuanHuyen = qh.Ten,
                               Gia = t.Gia,
                               DienTich = t.DienTich,
                               Huong = h.Ten,
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
                listTimKiem.TinBanViewModels = (from t in _dbContext.TinBatDongSan
                                                join lt in _dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                                                join nd in _dbContext.NguoiDung on t.NguoiDang equals nd.ID
                                                join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                                                join tt in _dbContext.TinhThanh on t.TinhThanh equals tt.ID
                                                join qh in _dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                                                join mg in _dbContext.MucGia on t.MucGia equals mg.ID
                                                join mdt in _dbContext.MucDienTich on t.MucDienTich equals mdt.ID
                                                join h in _dbContext.Huong on t.Huong equals h.ID
                                                where h.Ten == hinhThucOption
                                                && tt.Ten == tinhThanhOption
                                                && lbds.Ten == loaiOption
                                                select new TinBanViewModel()
                                                {
                                                    LienHe = nd.SoDienThoai,
                                                    NgayDang = t.NgayDang,
                                                    LoaiBatDongSan = lbds.Ten,
                                                    TinhThanh = tt.Ten,
                                                    QuanHuyen = qh.Ten,
                                                    Gia = t.Gia,
                                                    DienTich = t.DienTich,
                                                    Huong = h.Ten,
                                                    MoTa = t.MoTa
                                                }).ToList();
            }
            if (hinhThucOption == "Mua" || hinhThucOption == "Thuê")
            {
                listTimKiem.TinMuaViewModels = (from t in _dbContext.TinBatDongSan
                                                join lt in _dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                                                join nd in _dbContext.NguoiDung on t.NguoiDang equals nd.ID
                                                join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                                                join tt in _dbContext.TinhThanh on t.TinhThanh equals tt.ID
                                                join qh in _dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                                                join mg in _dbContext.MucGia on t.MucGia equals mg.ID
                                                join mdt in _dbContext.MucDienTich on t.MucDienTich equals mdt.ID
                                                join h in _dbContext.Huong on t.Huong equals h.ID
                                                where h.Ten == hinhThucOption
                                                && tt.Ten == tinhThanhOption
                                                && lbds.Ten == loaiOption
                                                select new TinMuaViewModel()
                                                {
                                                    LienHe = nd.SoDienThoai,
                                                    NgayDang = t.NgayDang,
                                                    LoaiBatDongSan = lbds.Ten,
                                                    TinhThanh = tt.Ten,
                                                    QuanHuyen = qh.Ten,
                                                    Gia = t.Gia,
                                                    DienTich = t.DienTich,
                                                    Huong = h.Ten,
                                                    MoTa = t.MoTa
                                                }).ToList();
            }
            return View(listTimKiem);
        }
    }
}