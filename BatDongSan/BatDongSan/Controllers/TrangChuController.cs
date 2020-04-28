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
            var tinBanViewModels = (from t in _dbContext.TinBatDongSan
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
            var tinMuaViewModels = (from t in _dbContext.TinBatDongSan
                                    join lt in _dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                                    join nd in _dbContext.NguoiDung on t.NguoiDang equals nd.ID
                                    join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                                    join tt in _dbContext.TinhThanh on t.TinhThanh equals tt.ID
                                    join qh in _dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                                    join mg in _dbContext.MucGia on t.MucGia equals mg.ID
                                    join mdt in _dbContext.MucDienTich on t.MucDienTich equals mdt.ID
                                    join h in _dbContext.Huong on t.Huong equals h.ID
                                    where lt.Ten == "Mua"
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
            var tinVIPViewModels = (from t in _dbContext.TinBatDongSan
                                    join lt in _dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                                    join nd in _dbContext.NguoiDung on t.NguoiDang equals nd.ID
                                    join gt in _dbContext.GoiTin on t.GoiTin equals gt.ID
                                    join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                                    join tt in _dbContext.TinhThanh on t.TinhThanh equals tt.ID
                                    join qh in _dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                                    join mg in _dbContext.MucGia on t.MucGia equals mg.ID
                                    join mdt in _dbContext.MucDienTich on t.MucDienTich equals mdt.ID
                                    join h in _dbContext.Huong on t.Huong equals h.ID
                                    where gt.Ten == "Tin VIP"
                                    select new TinVIPViewModel()
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
            var nhaMoiGioiViewModels = (from t in _dbContext.NguoiDung
                                        join cv in _dbContext.ChucVu on t.ChucVu equals cv.ID
                                        where cv.Ten == "Nhà môi giới"
                                        select new NhaMoiGioiViewModel()
                                        {
                                            Ten = t.Ten,
                                            SoBaiDang = t.SoBaiDang,
                                            Email = t.Email,
                                            SoDienThoai = t.SoDienThoai,
                                            DiaChi = t.DiaChi
                                        }).ToList();
            _trangChu.TinBanViewModels = tinBanViewModels;
            _trangChu.TinMuaViewModels = tinMuaViewModels;
            _trangChu.TinVIPViewModels = tinVIPViewModels;
            _trangChu.NhaMoiGioiViewModels = nhaMoiGioiViewModels;
            return View(_trangChu);
        }
    }
}
