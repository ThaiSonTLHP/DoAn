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
using Microsoft.AspNetCore.Http;

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
            TrangChuListViewModel trangChuListViewModel = new TrangChuListViewModel();

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            if (page == null) page = 1;
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            trangChuListViewModel.TinPagedList = layDuLieu.LayTinBDS(0, "All", "Cần bán").ToPagedList(pageNumber, pageSize);
            trangChuListViewModel.TinVIPViewModels = layDuLieu.LayTinBDS(8, "Tin VIP", "All");
            trangChuListViewModel.TinBDSTinhThanhViewModels = layDuLieu.TongTinBDSByTinhThanh();
            return View(trangChuListViewModel);
        }

        public IActionResult TinChoThue(int? page)
        {
            TrangChuListViewModel trangChuListViewModel = new TrangChuListViewModel();

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            if (page == null) page = 1;
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            trangChuListViewModel.TinPagedList = layDuLieu.LayTinBDS(0, "All", "Cho thuê").ToPagedList(pageNumber, pageSize);
            trangChuListViewModel.TinVIPViewModels = layDuLieu.LayTinBDS(8, "Tin VIP", "All");
            trangChuListViewModel.TinBDSTinhThanhViewModels = layDuLieu.TongTinBDSByTinhThanh();
            return View(trangChuListViewModel);
        }

        public IActionResult TinMua(int? page)
        {
            TrangChuListViewModel trangChuListViewModel = new TrangChuListViewModel();

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            if (page == null) page = 1;
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            trangChuListViewModel.TinPagedList = layDuLieu.LayTinBDS(0, "All", "Cần mua").ToPagedList(pageNumber, pageSize);
            trangChuListViewModel.TinVIPViewModels = layDuLieu.LayTinBDS(8, "Tin VIP", "All");
            trangChuListViewModel.TinBDSTinhThanhViewModels = layDuLieu.TongTinBDSByTinhThanh();
            return View(trangChuListViewModel);
        }

        public IActionResult TinThue(int? page)
        {
            TrangChuListViewModel trangChuListViewModel = new TrangChuListViewModel();

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            if (page == null) page = 1;
            int pageSize = 15;
            int pageNumber = (page ?? 1);

            trangChuListViewModel.TinPagedList = layDuLieu.LayTinBDS(0, "All", "Cần thuê").ToPagedList(pageNumber, pageSize);
            trangChuListViewModel.TinVIPViewModels = layDuLieu.LayTinBDS(8, "Tin VIP", "All");
            trangChuListViewModel.TinBDSTinhThanhViewModels = layDuLieu.TongTinBDSByTinhThanh();
            return View(trangChuListViewModel);
        }

        public IActionResult TinVIP(int? page)
        {
            TrangChuListViewModel trangChuListViewModel = new TrangChuListViewModel();

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            trangChuListViewModel.TinPagedList = layDuLieu.LayTinBDS(0, "Tin VIP", "All").ToPagedList(pageNumber, pageSize);
            trangChuListViewModel.TinHOTViewModels = layDuLieu.LayTinBDS(8, "Tin HOT", "All");
            trangChuListViewModel.TinBDSTinhThanhViewModels = layDuLieu.TongTinBDSByTinhThanh();
            return View(trangChuListViewModel);
        }

        public IActionResult TinHOT(int? page)
        {
            TrangChuListViewModel trangChuListViewModel = new TrangChuListViewModel();

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            trangChuListViewModel.TinPagedList = layDuLieu.LayTinBDS(0, "Tin HOT", "All").ToPagedList(pageNumber, pageSize);
            trangChuListViewModel.TinVIPViewModels = layDuLieu.LayTinBDS(8, "Tin VIP", "All");
            trangChuListViewModel.TinBDSTinhThanhViewModels = layDuLieu.TongTinBDSByTinhThanh();
            return View(trangChuListViewModel);
        }

        public IActionResult TinThuong(int? page)
        {
            TrangChuListViewModel trangChuListViewModel = new TrangChuListViewModel();

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            trangChuListViewModel.TinPagedList = layDuLieu.LayTinBDS(0, "Tin thường", "All").ToPagedList(pageNumber, pageSize);
            trangChuListViewModel.TinVIPViewModels = layDuLieu.LayTinBDS(8, "Tin VIP", "All");
            trangChuListViewModel.TinBDSTinhThanhViewModels = layDuLieu.TongTinBDSByTinhThanh();
            return View(trangChuListViewModel);
        }

        public IActionResult TinTinhThanh(int? page, string id)
        {
            TrangChuListViewModel trangChuListViewModel = new TrangChuListViewModel();

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            var tinhThanh = dbContext.TinhThanh.Find(id);
            var listTin = layDuLieu.LayTinBDSByTinhThanh(id);
            pageSize = listTin.Count();
            //listTin = listTin.GetRange(0, listTin.Count() < 8 ? listTin.Count() : 8);
            trangChuListViewModel.TinPagedList = listTin.ToPagedList(pageNumber, pageSize);
            trangChuListViewModel.TinVIPViewModels = layDuLieu.LayTinBDS(8, "Tin VIP", "All");
            trangChuListViewModel.TinBDSTinhThanhViewModels = layDuLieu.TongTinBDSByTinhThanh();
            trangChuListViewModel.TinhThanh = tinhThanh.Ten;
            return View(trangChuListViewModel);
        }

        public IActionResult ChiTietTinBDS(int id)
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var tin = dbContext.TinBatDongSan.FirstOrDefault(t => t.ID == id);
            tin.LuotXem++;
            dbContext.Update(tin);
            dbContext.SaveChanges();
            //HttpContext.Session.SetInt32("ChiTietTinFlag", id);
            return View(layDuLieu.ChiTietBDS(id));
        }

        public IActionResult NhaMoiGioi()
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            return View();
        }

        public IActionResult ChiTietNhaMoiGioi()
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            return View();
        }

        public IActionResult TinTuc(int? page)
        {
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            return View(layDuLieu.LayTinTuc(0).ToPagedList(pageNumber, pageSize));
        }

        public IActionResult ChiTietTinTuc(int id)
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            return View(layDuLieu.LayTinTucId(id));
        }

        public IActionResult Search(int? page, string TinhThanhOption = "", int LoaiTinOption = 0, int MucGiaOption = 0, int LoaiBDSOption = 0)
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            TrangChuListViewModel trangChuListViewModel = new TrangChuListViewModel();
            if (page == null) page = 1;
            int pageSize = 10;
            int pageNumber = (page ?? 1);

            var listTin = dbContext.TinBatDongSan.ToList();

            if (TinhThanhOption != null)
            {
                listTin = listTin.Where(t => t.TinhThanh == TinhThanhOption).ToList();
            }
            if (LoaiTinOption != 0)
            {
                listTin = listTin.Where(t => t.LoaiTin == LoaiTinOption).ToList();
            }
            if (MucGiaOption != 0)
            {
                listTin = listTin.Where(t => t.MucGia == MucGiaOption).ToList();
            }
            if (LoaiBDSOption != 0)
            {
                listTin = listTin.Where(t => t.LoaiBatDongSan == LoaiBDSOption).ToList();
            }

            var listTinBDS = new List<TinBDSViewModel>();
            foreach(var tin in listTin)
            {
                listTinBDS.Add(layDuLieu.LayTinBDS(tin.ID));
            }

            pageSize = listTinBDS.Count();
            //listTin = listTin.GetRange(0, listTin.Count() < 8 ? listTin.Count() : 8);


            var giaTang = listTinBDS.OrderBy(t => t.GiaGoc).ToList();
            var giaGiam = listTinBDS.OrderByDescending(t => t.GiaGoc).ToList();

            var dienTichTang = listTinBDS.OrderBy(t => t.DienTichGoc).ToList();
            var dienTichGiam = listTinBDS.OrderByDescending(t => t.DienTichGoc).ToList();


            //trangChuListViewModel.GiaTang = giaTang.ToPagedList(pageNumber, pageSize);
            //trangChuListViewModel.GiaGiam = giaGiam.ToPagedList(pageNumber, pageSize);
            //trangChuListViewModel.DienTichTang = dienTichTang.ToPagedList(pageNumber, pageSize);
            trangChuListViewModel.TinPagedList = listTinBDS.ToPagedList(pageNumber, pageSize);

            trangChuListViewModel.TinVIPViewModels = layDuLieu.LayTinBDS(8, "Tin VIP", "All");
            trangChuListViewModel.TinBDSTinhThanhViewModels = layDuLieu.TongTinBDSByTinhThanh();
            return View(trangChuListViewModel);
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
            string QuanHuyens = "",
            int LoaiTinBatDongSans = 0,
            int MucGias = 0,
            int LoaiBatDongSans = 0,
            int MucDienTiches = 0,
            int Huongs = 0,
            string XacThucs = "",
            string ThoiGians = "",
            int option = 0,
            string searchString = "")
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTinBDS = new List<TinBDSViewModel>();
            if(option == 0)
            {
                listTinBDS = (from t in dbContext.TinBatDongSan
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
                              && DateTime.Compare(t.NgayLenBangTin.AddDays(int.Parse(ThoiGians)), DateTime.Now) >= 0
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
            }
            else
            {
                //all
                listTinBDS = layDuLieu.LayTinBDS();
                if (option == 1)
                {
                    listTinBDS = listTinBDS.Where(
                        t => t.TinhThanh.Contains(searchString) ||
                        t.QuanHuyen.Contains(searchString) ||
                        t.LoaiTin.Contains(searchString) ||
                        t.LoaiBatDongSan.Contains(searchString) ||
                        t.Gia.Contains(searchString) ||
                        t.DienTich.Contains(searchString) ||
                        t.Huong.Contains(searchString) ||
                        t.NgayDang.ToString().Contains(searchString) ||
                        t.MoTa.Contains(searchString)
                    ).ToList();
                }
                //tinh thanh
                if (option == 2)
                {
                    listTinBDS = listTinBDS.Where(t => t.TinhThanh.Contains(searchString)).ToList();
                }
                //quan huyen
                if (option == 3)
                {
                    listTinBDS = listTinBDS.Where(t => t.QuanHuyen.Contains(searchString)).ToList();
                }
                //loai tin
                if (option == 4)
                {
                    listTinBDS = listTinBDS.Where(t => t.LoaiTin.Contains(searchString)).ToList();
                }
                //loai bat dong san
                if (option == 5)
                {
                    listTinBDS = listTinBDS.Where(t => t.LoaiBatDongSan.Contains(searchString)).ToList();
                }
                //gia
                if (option == 6)
                {
                    listTinBDS = listTinBDS.Where(t => t.Gia.Contains(searchString)).ToList();
                }
                //dien tich
                if (option == 7)
                {
                    listTinBDS = listTinBDS.Where(t => t.DienTich.Contains(searchString)).ToList();
                }
                //huong
                if (option == 8)
                {
                    listTinBDS = listTinBDS.Where(t => t.Huong.Contains(searchString)).ToList();
                }
                //ngay dang
                if (option == 9)
                {
                    listTinBDS = listTinBDS.Where(t => t.NgayDang.ToString().Contains(searchString)).ToList();
                }
                //mo ta
                if (option == 10)
                {
                    listTinBDS = listTinBDS.Where(t => t.MoTa.Contains(searchString)).ToList();
                }
            }
            
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

        //-----------------ajax
        public void BaoCaoTin(int id, int user, string lyDo)
        {
            var baoCao = new BaoCao();
            baoCao.Tin = id;
            baoCao.NguoiGui = user;
            baoCao.LyDo = lyDo;
            baoCao.DaXem = false;
            dbContext.BaoCao.Add(baoCao);
            dbContext.SaveChanges();
        }
    }
}