using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BatDongSan.Models;
using BatDongSanService;
using BatDongSanId.Data;
using BatDongSanId.Areas.Client.Models.ListViewModels;
using BatDongSanId.Areas.Client.Models.ViewModels;
using Microsoft.Extensions.Configuration;

namespace BatDongSanId.Areas.Client.Controllers
{
    [Area("Client")]
    public class TrangChuController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration configuration;

        public TrangChuController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            this.configuration = configuration;
        }
        public IActionResult Index(/*int? size = 3, int? page*/)
        {
            //if (page == null) page = 1;
            //// 4.1 Toán tử ?? trong C# mô tả nếu page khác null thì lấy giá trị page, còn
            //// nếu page = null thì lấy giá trị 1 cho biến pageNumber.
            //int pageNumber = (page ?? 1);
            TrangChuListViewModel _trangChu = new TrangChuListViewModel();
            var tinBanViewModels = (from t in _dbContext.TinBatDongSan
                                    join lt in _dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                                    join nd in _dbContext.TaiKhoan on t.NguoiDang equals nd.ID
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
                                        Huong = h.Ten,
                                        MoTa = t.MoTa
                                    }).OrderBy(x=>x.ID).ToList();
            var tinMuaViewModels = (from t in _dbContext.TinBatDongSan
                                    join lt in _dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                                    join nd in _dbContext.TaiKhoan on t.NguoiDang equals nd.ID
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
                                        Huong = h.Ten,
                                        MoTa = t.MoTa
                                    }).ToList();
            var tinVIPViewModels = (from t in _dbContext.TinBatDongSan
                                    join lt in _dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                                    join nd in _dbContext.TaiKhoan on t.NguoiDang equals nd.ID
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
                                        Huong = h.Ten,
                                        MoTa = t.MoTa
                                    }).ToList();
            var nhaMoiGioiViewModels = (from t in _dbContext.TaiKhoan
                                        join ltk in _dbContext.LoaiTaiKhoan on t.LoaiTaiKhoan equals ltk.ID
                                        where ltk.Ten == "Nhà môi giới"
                                        select new NhaMoiGioiViewModel()
                                        {
                                            Ten = t.Ten,
                                            Email = t.Email,
                                            SoDienThoai = t.SoDienThoai,
                                            DiaChi = t.DiaChi
                                        }).ToList();
            _trangChu.TinBanViewModels = tinBanViewModels;
            _trangChu.TinMuaViewModels = tinMuaViewModels;
            _trangChu.TinVIPViewModels = tinVIPViewModels;
            _trangChu.NhaMoiGioiViewModels = nhaMoiGioiViewModels;
            //var testKey = configuration["AppSetting:TinBatDongSanTime"];
            return View(_trangChu);
        }
    }
}
