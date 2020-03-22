using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BatDongSan.Models;
using BatDongSan.Models.ViewModels;
using BatDongSan.Models.ListViewModels;
using BatDongSanService;

namespace BatDongSan.Controllers
{
    public class TrangChuController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public TrangChuController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            TrangChuListViewModel _trangChu = new TrangChuListViewModel();
            var tinBanViewModels = (from t in _dbContext.TinRao
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
            var tinMuaViewModels = (from t in _dbContext.TinMua
                                    join h in _dbContext.HinhThucGiaoDich on t.HinhThucGiaoDichId equals h.Id
                                    join nm in _dbContext.TKNguoiMua on t.NguoiMuaId equals nm.Id
                                    join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSanId equals lbds.Id
                                    join tt in _dbContext.TinhThanh on t.TinhThanhId equals tt.Id
                                    join qh in _dbContext.QuanHuyen on t.TinhThanhId equals qh.Id
                                    join hg in _dbContext.Huong on t.TinhThanhId equals hg.Id
                                    where h.Ten == "Mua"
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
            var tinVIPViewModels = (from t in _dbContext.TinRao
                                    join lt in _dbContext.LoaiTinRao on t.LoaiTinRaoId equals lt.Id
                                    join h in _dbContext.HinhThucGiaoDich on t.HinhThucGiaoDichId equals h.Id
                                    join nmg in _dbContext.TKNhaMoiGioi on t.NhaMoiGioiId equals nmg.Id
                                    join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSanId equals lbds.Id
                                    join tt in _dbContext.TinhThanh on t.TinhThanhId equals tt.Id
                                    join qh in _dbContext.QuanHuyen on t.TinhThanhId equals qh.Id
                                    join hg in _dbContext.Huong on t.TinhThanhId equals hg.Id
                                    where lt.Ten == "Vip"
                                    select new TinVIPViewModel()
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
            var nhaMoiGioiViewModels = (from t in _dbContext.TKNhaMoiGioi
                                        select new NhaMoiGioiViewModel()
                                        {
                                            TenNhaMoiGioi = t.TenNhaMoiGioi,
                                            SoGiaoDich = t.SoGiaoDich,
                                            DanhGia = t.DanhGia,
                                            SoDienThoai = t.SoDienThoai
                                        }).ToList();
            _trangChu.TinBanViewModels = tinBanViewModels;
            _trangChu.TinMuaViewModels = tinMuaViewModels;
            _trangChu.TinVIPViewModels = tinVIPViewModels;
            _trangChu.NhaMoiGioiViewModels = nhaMoiGioiViewModels;
            return View(_trangChu);
        }
    }
}
