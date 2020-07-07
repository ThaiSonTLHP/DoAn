using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Areas.Admin.Models.ViewModel;
using BatDongSanId.Areas.Client.Controllers;
using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Data;
using BatDongSanId.Methods;
using BatDongSanId.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CauHinhController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;
        private readonly CheckUser checkUser;

        public CauHinhController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
            checkUser = new CheckUser(dbContext);
        }

        public IActionResult Menu()
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var menu = new MenuViewModel();
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

        public IActionResult Logo()
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            return View();
        }

        [HttpPost]
        public IActionResult Logo(MenuViewModel menuViewModel)
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var anh = dbContext.CauHinh.FirstOrDefault(a => a.Ten == "Logo");

            foreach (var file in Request.Form.Files)
            {
                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                anh.Anh = ms.ToArray();
                ms.Close();
                ms.Dispose();
            }

            dbContext.Update(anh);
            dbContext.SaveChanges();

            return RedirectToAction("Logo");
        }

        //------------------danh sach slide
        public IActionResult Slide()
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var slide = new List<SlideViewModel>();
            


            return View();
        }

        //------------------them slide moi
        public IActionResult ThemSlide()
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var count = dbContext.CauHinh.Where(s => s.Ten == "Slide").ToList().Count();
            ViewBag.Count = count;

            return View();
        }

        [HttpPost]
        public IActionResult ThemSlide(SlideViewModel slide)
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var newslide = new CauHinh();
            newslide.Ten = "Slide";
            newslide.TrangThai = true;

            dbContext.CauHinh.Add(newslide);
            dbContext.SaveChanges();

            return RedirectToAction("Slide");
        }

        //------------------sua slide
        public IActionResult SuaSlide(int id)
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var listSlide = dbContext.CauHinh.Where(s => s.Ten == "Slide").ToList();
            int i = 0;
            foreach(var s in listSlide)
            {
                if (s.ID == id) break;
                i++;
            }
            var slide = new SlideViewModel();
            slide.Index = ++i;
            slide.Image = dbContext.CauHinh.Find(id);

            return View(slide);
        }

        [HttpPost]
        public IActionResult SuaSlide(SlideViewModel slide)
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            return RedirectToAction("Slide");
        }



        //----------------------menu phia client
        public IActionResult MenuClient()
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }



            return View();
        }

        public IActionResult ThongTin()
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var menu = new MenuViewModel();
            menu.Fanpage = dbContext.CauHinh.FirstOrDefault(t => t.Ten == "Fanpage");

            return View(menu);
        }

        [HttpPost]
        public IActionResult ThongTin(MenuViewModel menu)
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            if (ModelState.IsValid)
            {
                var fanPage = dbContext.CauHinh.FirstOrDefault(x => x.Ten == "Fanpage");
                fanPage.DuLieuString = menu.Fanpage.DuLieuString;
                dbContext.Update(fanPage);
                dbContext.SaveChanges();
            }

            return RedirectToAction("ThongTin");
        }


        //------------------------ajax
        public string CapNhatMenu(int id)
        {
            var cauHinh = dbContext.CauHinh.Find(id);
            if(cauHinh.TrangThai == true)
            {
                cauHinh.TrangThai = false;
                dbContext.Update(cauHinh);
                dbContext.SaveChanges();
                return "Không";
            }
            else
            {
                cauHinh.TrangThai = true;
                dbContext.Update(cauHinh);
                dbContext.SaveChanges();
                return "Có";
            }
        }
    }
}
