using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using BatDongSan.Models.ListViewModels;
using BatDongSan.Models.ViewModels;
using BatDongSanService;
using Microsoft.AspNetCore.Mvc;

namespace BatDongSan.Areas.Client.Controllers
{
    [Area("Client")]
    public class DmController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public DmController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View(GetListTinBDS("Cần bán"));
        }

        public IActionResult TinChoThue()
        {
            return View(GetListTinBDS("Cho thuê"));
        }

        public IActionResult TinMua()
        {
            return View(GetListTinBDS("Cần mua"));
        }

        public IActionResult TinThue()
        {
            return View(GetListTinBDS("Cần thuê"));
        }

        public IActionResult ChiTietTinBDS(int id)
        {
            return View(GetTinBDS(id));
        }

        public IActionResult NhaMoiGioi()
        {
            return View();
        }

        public IActionResult ChiTietNhaMoiGioi()
        {
            return View();
        }

        public IActionResult Search(string TinhThanhOption, int LoaiTinOption, int MucGiaOption, int LoaiBDSOption)
        {
            var listTinBDS = (from t in _dbContext.TinBatDongSan
                              join lt in _dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                              join nd in _dbContext.TaiKhoan on t.NguoiDang equals nd.ID
                              join gt in _dbContext.GoiTin on t.GoiTin equals gt.ID
                              join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                              join tt in _dbContext.TinhThanh on t.TinhThanh equals tt.ID
                              join qh in _dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                              join h in _dbContext.Huong on t.Huong equals h.ID
                              where lt.ID == LoaiTinOption 
                              && tt.ID == TinhThanhOption
                              && t.MucGia == MucGiaOption
                              && t.LoaiBatDongSan == LoaiBDSOption
                              select new TinBDSViewModel()
                              {
                                  ID = t.ID,
                                  LoaiTin = lt.Ten,
                                  NguoiDang = nd.Ten,
                                  LienHe = nd.SoDienThoai,
                                  NgayDang = t.NgayDang,
                                  GoiTin = gt.Ten,
                                  LoaiBatDongSan = lbds.Ten,
                                  TinhThanh = tt.Ten,
                                  QuanHuyen = qh.Ten,
                                  Gia = t.Gia.ToString(),
                                  DienTich = t.DienTich.ToString(),
                                  Huong = h.Ten,
                                  MoTa = t.MoTa
                              }).ToList();
            return View(listTinBDS);
        }

        public List<TinBDSViewModel> GetListTinBDS(string loaiTin)
        {
            var listTinBDS = (from t in _dbContext.TinBatDongSan
                               join lt in _dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                               join nd in _dbContext.TaiKhoan on t.NguoiDang equals nd.ID
                               join gt in _dbContext.GoiTin on t.GoiTin equals gt.ID
                               join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                               join tt in _dbContext.TinhThanh on t.TinhThanh equals tt.ID
                               join qh in _dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                               join h in _dbContext.Huong on t.Huong equals h.ID
                               where lt.Ten == loaiTin
                               select new TinBDSViewModel()
                               {
                                   ID = t.ID,
                                   LoaiTin = lt.Ten,
                                   NguoiDang = nd.Ten,
                                   LienHe = nd.SoDienThoai,
                                   NgayDang = t.NgayDang,
                                   GoiTin = gt.Ten,
                                   LoaiBatDongSan = lbds.Ten,
                                   TinhThanh = tt.Ten,
                                   QuanHuyen = qh.Ten,
                                   Gia = t.Gia.ToString(),
                                   DienTich = t.DienTich.ToString(),
                                   Huong = h.Ten,
                                   MoTa = t.MoTa
                               }).ToList();
            return listTinBDS;
        }

        public TinBDSViewModel GetTinBDS(int id)
        {
            var listTinBDS = (from t in _dbContext.TinBatDongSan
                              join lt in _dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                              join nd in _dbContext.TaiKhoan on t.NguoiDang equals nd.ID
                              join gt in _dbContext.GoiTin on t.GoiTin equals gt.ID
                              join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                              join tt in _dbContext.TinhThanh on t.TinhThanh equals tt.ID
                              join qh in _dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                              join h in _dbContext.Huong on t.Huong equals h.ID
                              where t.ID == id
                              select new TinBDSViewModel()
                              {
                                  ID = t.ID,
                                  LoaiTin = lt.Ten,
                                  NguoiDang = nd.Ten,
                                  LienHe = nd.SoDienThoai,
                                  NgayDang = t.NgayDang,
                                  GoiTin = gt.Ten,
                                  LoaiBatDongSan = lbds.Ten,
                                  TinhThanh = tt.Ten,
                                  QuanHuyen = qh.Ten,
                                  Gia = t.Gia.ToString(),
                                  DienTich = t.DienTich.ToString(),
                                  Huong = h.Ten,
                                  MoTa = t.MoTa
                              }).FirstOrDefault();
            return listTinBDS;
        }
    }
}