using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Areas.Admin.Models.ViewModel;
using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Data;
using BatDongSanId.Methods;
using BatDongSanId.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TinBDSController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;
        private readonly CheckUser checkUser;

        public TinBDSController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
            checkUser = new CheckUser(dbContext);
        }

        public IActionResult Tin(int loaiTin = 0, int option = 0, string searchString = "")
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            List<TinBDSViewModel> listTin = new List<TinBDSViewModel>();
            if(loaiTin != 0)
            {
                if (loaiTin == 5)
                {
                    listTin = layDuLieu.LayTinBDS();
                }
                else if (loaiTin == 1)
                {
                    listTin = layDuLieu.LayTinBDS(0, "All", "Cần bán");
                }
                else if (loaiTin == 2)
                {
                    listTin = layDuLieu.LayTinBDS(0, "All", "Cho thuê");
                }
                else if (loaiTin == 3)
                {
                    listTin = layDuLieu.LayTinBDS(0, "All", "Cần mua");
                }
                else if (loaiTin == 4)
                {
                    listTin = layDuLieu.LayTinBDS(0, "All", "Cần thuê");
                }
            }

            if(option != 0)
            {
                listTin = layDuLieu.LayTinBDS();
                //id
                if(option == 1)
                {
                    listTin = listTin.Where(t => t.ID.ToString().Contains(searchString)).ToList();
                }
                //ngay dang
                if (option == 2)
                {
                    listTin = listTin.Where(t => t.NgayDang.ToString().Contains(searchString)).ToList();
                }
                //nguoi dang
                if (option == 3)
                {
                    listTin = listTin.Where(t => t.NguoiDang.Contains(searchString)).ToList();
                }
                //mo ta
                if (option == 4)
                {
                    listTin = listTin.Where(t => t.MoTa.Contains(searchString)).ToList();
                }
            }
            return View(listTin);
        }

        public IActionResult ChiTietTin(int id)
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            return View(layDuLieu.ChiTietBDS(id));
        }

        public IActionResult ChoPheDuyet()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTin = layDuLieu.LayTinBDS();
            var listChuaDuyet = new List<TinBDSViewModel>();
            foreach(var tin in listTin)
            {
                if(tin.PheDuyet == false)
                {
                    listChuaDuyet.Add(tin);
                }
            }
            return View(listChuaDuyet);
        }

        public IActionResult ChoXacThuc()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTin = layDuLieu.LayTinBDS();
            var listChuaXacThuc = new List<TinBDSViewModel>();
            foreach (var tin in listTin)
            {
                if (tin.XacThucBool == false)
                {
                    listChuaXacThuc.Add(tin);
                }
            }
            return View(listChuaXacThuc);
        }

        public IActionResult DaGiaoDich(int option = 0, DateTime min = default(DateTime), DateTime max = default(DateTime))
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTin = layDuLieu.LayTinGiaoDich();
            var listGiaoDich = new List<TinBDSViewModel>();
            if(option != 0)
            {
                //all
                if(option == 4)
                {
                    
                }
                //date
                if (option == 1)
                {
                    listTin = listTin.Where(t => t.NgayXacNhan.Date == DateTime.Now.Date).ToList();
                }
                //month
                if (option == 2)
                {
                    listTin = listTin.Where(t => t.NgayXacNhan.Month == DateTime.Now.Month).ToList();
                }
                //year
                if (option == 3)
                {
                    listTin = listTin.Where(t => t.NgayXacNhan.Year == DateTime.Now.Date.Year).ToList();
                }
            }
            if(min != default(DateTime) && max != default(DateTime))
            {
                listTin = listTin.Where(t => DateTime.Compare(t.NgayXacNhan, min) >= 0 && DateTime.Compare(t.NgayXacNhan, max) < 0).ToList();
            }
            return View(listTin);
        }

        public IActionResult PhanHoi()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var phanHoi = (from b in dbContext.BaoCao
                           join t in dbContext.TinBatDongSan on b.Tin equals t.ID
                           join tk in dbContext.TaiKhoan on b.NguoiGui equals tk.ID
                           select new BaoCaoViewModel() {
                               ID = b.ID,
                               Tin = t.MoTa.Substring(0, 80) + "...",
                               NguoiGui = tk.Ten,
                               LyDo = b.LyDo.Substring(0,80) + "...",
                               DaXem = b.DaXem == true ? "Đã xem" : "Chưa xem"
                           }).ToList();
            return View(phanHoi);
        }

        public IActionResult ChiTietPhanHoi(int id)
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            PhanHoiViewModel phanHoiViewModel = new PhanHoiViewModel();
            phanHoiViewModel.phanHoi = dbContext.BaoCao.Find(id);
            phanHoiViewModel.taiKhoanBaoCao = layDuLieu.ChiTietTaiKhoan(phanHoiViewModel.phanHoi.NguoiGui);
            phanHoiViewModel.tinBDSViewModel = layDuLieu.LayTinBDS(phanHoiViewModel.phanHoi.Tin);
            phanHoiViewModel.hinhAnhs = layDuLieu.LayListHinhAnh(phanHoiViewModel.phanHoi.Tin, "Tin bất động sản");
            var tin = dbContext.TinBatDongSan.FirstOrDefault(t => t.ID == phanHoiViewModel.phanHoi.Tin);
            phanHoiViewModel.taiKhoanViewModel = layDuLieu.ChiTietTaiKhoan(tin.NguoiDang);

            var _phanHoi = dbContext.BaoCao.FirstOrDefault(b => b.ID == id);
            _phanHoi.DaXem = true;
            dbContext.BaoCao.Update(_phanHoi);
            dbContext.SaveChanges();

            return View(phanHoiViewModel);
        }


        //------------------------ajax
        public void DuyetTin(int idTin)
        {
            var tin = dbContext.TinBatDongSan.FirstOrDefault(t => t.ID == idTin);
            tin.TrangThaiDuyet = true;
            dbContext.TinBatDongSan.Update(tin);
            dbContext.SaveChanges();
        }

        public void XacThuc(int idTin)
        {
            var tin = dbContext.TinBatDongSan.FirstOrDefault(t => t.ID == idTin);
            tin.TrangThaiXacNhan = true;
            dbContext.TinBatDongSan.Update(tin);
            dbContext.SaveChanges();
        }

        public void XoaPhanHoi(int id)
        {
            var phanHoi = dbContext.BaoCao.FirstOrDefault(t => t.ID == id);
            dbContext.BaoCao.Remove(phanHoi);
            dbContext.SaveChanges();
        }
    }
}
