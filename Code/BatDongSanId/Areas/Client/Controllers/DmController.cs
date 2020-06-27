using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using X.PagedList.Mvc.Core;
using X.PagedList;
using BatDongSanId.Methods;
using Microsoft.Extensions.Configuration;
using BatDongSanId.Areas.Client.Models.ListViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using BatDongSanId.Models;

namespace BatDongSanId.Areas.Client.Controllers
{
    [Area("Client")]
    public class DmController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;
        public DmController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }

        public IActionResult TinBan(int? page)
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(layDuLieu.LayTinBDS(0, "All", "Cần bán").ToPagedList(pageNumber, pageSize));
        }

        public IActionResult TinChoThue(int? page)
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(layDuLieu.LayTinBDS(0, "All", "Cho thuê").ToPagedList(pageNumber, pageSize));
        }

        public IActionResult TinMua(int? page)
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(layDuLieu.LayTinBDS(0, "All", "Cần mua").ToPagedList(pageNumber, pageSize));
        }

        public IActionResult TinThue(int? page)
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            return View(layDuLieu.LayTinBDS(0, "All", "Cần thuê").ToPagedList(pageNumber, pageSize));
        }

        public IActionResult ChiTietTinBDS(int id)
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            return View(layDuLieu.ChiTietBDS(id));
        }

        public IActionResult NhaMoiGioi()
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            return View();
        }

        public IActionResult TinTuc()
        {
            return View();
        }

        public IActionResult ChiTietNhaMoiGioi()
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            return View();
        }

        public IActionResult Search(string TinhThanhOption, int LoaiTinOption, int MucGiaOption, int LoaiBDSOption)
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTinBDS = (from t in dbContext.TinBatDongSan
                              join tk in dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                              join lt in dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                              join nd in dbContext.TaiKhoan on t.NguoiDang equals nd.ID
                              join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                              join lbds in dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                              join tt in dbContext.TinhThanh on t.TinhThanh equals tt.ID
                              join qh in dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                              join h in dbContext.Huong on t.Huong equals h.ID
                              where t.LoaiTin == LoaiTinOption 
                              && t.TinhThanh == TinhThanhOption
                              && t.MucGia == MucGiaOption
                              && t.LoaiBatDongSan == LoaiBDSOption
                              select new TinBDSViewModel()
                              {
                                  ID = t.ID,
                                  LienHe = tk.SoDienThoai,
                                  NgayDang = t.NgayDang,
                                  LoaiTin = lt.Ten,
                                  GoiTin = gt.Ten,
                                  PheDuyet = t.TrangThaiDuyet,
                                  NguoiDang = tk.Ten,
                                  LoaiBatDongSan = lbds.Ten,
                                  TinhThanh = tt.Ten,
                                  QuanHuyen = qh.Ten,
                                  Huong = h.Ten,
                                  DienTich = t.DienTich,
                                  Gia = t.Gia,
                                  XacThuc = t.TrangThaiXacNhan == true ? "Xác thực" : "Chưa xác thực",
                                  XacThucBool = t.TrangThaiXacNhan,
                                  TieuDe = t.MoTa.Substring(0, 100) + "...",
                                  DaBan = t.TrangThaiGiaoDich,
                                  MoTa = t.MoTa
                              }).ToList();
            if (listTinBDS.Count() > 0)
            {
                foreach (TinBDSViewModel tin in listTinBDS)
                {
                    tin.Gia = layDuLieu.GiaTien(tin.Gia);
                    tin.HinhAnh = layDuLieu.LayHinhAnh(tin.ID, "Tin bất động sản");
                }
            }
            return View(listTinBDS);
        }

        public IActionResult TimKiemNangCao()
        {
            var TinhThanhs = dbContext.TinhThanh.OrderBy(m => m.Ten).ToList();
            var QuanHuyens = dbContext.QuanHuyen.OrderBy(m => m.Ten).ToList();
            var LoaiTinBatDongSans = dbContext.LoaiTinBatDongSan.OrderBy(m => m.ID).ToList();
            var MucGias = dbContext.MucGia.OrderBy(m => m.ID).ToList();
            var LoaiBatDongSans = dbContext.LoaiBatDongSan.OrderBy(m => m.ID).ToList();
            var Huongs = dbContext.Huong.OrderBy(m => m.ID).ToList(); ;
            var MucDienTiches = dbContext.MucDienTich.OrderBy(m => m.ID).ToList();

            //var XacThucs = new List<XacThuc>
            //{
            //    new XacThuc(true, "Đã xác thực"),
            //    new XacThuc(false, "Chưa xác thực")
            //}.ToList();

            //var ThoiGians = new List<ThoiGian>
            //{
            //    new ThoiGian(1, "24 giờ qua"),
            //    new ThoiGian(7, "Tuần qua"),
            //    new ThoiGian(30, "Tháng qua")
            //}.ToList();

            var XacThucs = new List<SelectListItem>();
            XacThucs.Add(new SelectListItem { Text = "Đã xác thực", Value = "true" });
            XacThucs.Add(new SelectListItem { Text = "Chưa xác thực", Value = "false" });

            var ThoiGians = new List<SelectListItem>();
            ThoiGians.Add(new SelectListItem { Text = "24 giờ qua", Value = "1" });
            ThoiGians.Add(new SelectListItem { Text = "Tuần qua", Value = "7" });
            ThoiGians.Add(new SelectListItem { Text = "Tháng qua", Value = "30" });

            ViewBag.TinhThanh = new SelectList(TinhThanhs, "ID", "Ten");
            ViewBag.LoaiTin = new SelectList(LoaiTinBatDongSans, "ID", "Ten");
            ViewBag.MucGia = new SelectList(MucGias, "ID", "Ten");
            ViewBag.LoaiBDS = new SelectList(LoaiBatDongSans, "ID", "Ten");
            ViewBag.Huong = new SelectList(Huongs, "ID", "Ten");
            ViewBag.MucDT = new SelectList(MucDienTiches, "ID", "Ten");
            ViewBag.XacThuc = new SelectList(XacThucs, "Value", "Text");
            ViewBag.ThoiGian = new SelectList(ThoiGians, "Value", "Text");
            return View();
        }


        public IActionResult KetQuaTimKiem(
            string QuanHuyens,
            int LoaiTinBatDongSans,
            int MucGias,
            int LoaiBatDongSans,
            int MucDienTiches,
            int Huongs,
            string XacThucs,
            string ThoiGians)
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTinBDS = (from t in dbContext.TinBatDongSan
                              join tk in dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                              join lt in dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                              join nd in dbContext.TaiKhoan on t.NguoiDang equals nd.ID
                              join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                              join lbds in dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                              join tt in dbContext.TinhThanh on t.TinhThanh equals tt.ID
                              join qh in dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                              join h in dbContext.Huong on t.Huong equals h.ID
                              where t.LoaiTin == LoaiTinBatDongSans
                              && t.QuanHuyen == QuanHuyens
                              && t.MucGia == MucGias
                              && t.LoaiBatDongSan == LoaiBatDongSans
                              && t.MucDienTich == MucDienTiches
                              && h.ID == Huongs
                              && t.TrangThaiXacNhan == Boolean.Parse(XacThucs)
                              && DateTime.Compare(t.NgayLenBangTin.AddDays(int.Parse(ThoiGians)),DateTime.Now) >= 0
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
            if (listTinBDS.Count() > 0)
            {
                foreach (TinBDSViewModel tin in listTinBDS)
                {
                    tin.Gia = layDuLieu.GiaTien(tin.Gia);
                    tin.HinhAnh = layDuLieu.LayHinhAnh(tin.ID, "Tin bất động sản");
                }
            }
            
            return View(listTinBDS);
        }

        public List<TinBDSViewModel> GetListTinBDS(string loaiTin)
        {
            var listTinBDS = (from t in dbContext.TinBatDongSan
                               join lt in dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                               join nd in dbContext.TaiKhoan on t.NguoiDang equals nd.ID
                               join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                               join lbds in dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                               join tt in dbContext.TinhThanh on t.TinhThanh equals tt.ID
                               join qh in dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                               join h in dbContext.Huong on t.Huong equals h.ID
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
            var listTinBDS = (from t in dbContext.TinBatDongSan
                              join lt in dbContext.LoaiTinBatDongSan on t.LoaiBatDongSan equals lt.ID
                              join nd in dbContext.TaiKhoan on t.NguoiDang equals nd.ID
                              join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                              join lbds in dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                              join tt in dbContext.TinhThanh on t.TinhThanh equals tt.ID
                              join qh in dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                              join h in dbContext.Huong on t.Huong equals h.ID
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