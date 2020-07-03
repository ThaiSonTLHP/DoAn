using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Data;
using BatDongSanId.Methods;
using BatDongSanId.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TinTucController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;
        private readonly CheckUser checkUser;
        public TinTucController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
            checkUser = new CheckUser(dbContext);
        }
        public IActionResult Tin()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var tin = (from t in dbContext.TinTuc
                       join tk in dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                       join lt in dbContext.LoaiTinTuc on t.LoaiTinTuc equals lt.ID
                       select new TinTucViewModel() { 
                           ID = t.ID,
                           NguoiDang = tk.Ten,
                           NgayDang = t.NgayDang,
                           LoaiTinTuc = lt.Ten,
                           TieuDe = t.TieuDe
                       }).ToList();

            return View(tin);
        }

        public IActionResult ChiTiet()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            return View();
        }

        public IActionResult VietBai()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            List<LoaiTinTuc> loaiTinTucs = dbContext.LoaiTinTuc.ToList();
            ViewBag.LoaiTinTuc = new SelectList(loaiTinTucs, "ID", "Ten");

            return View();
        }

        [HttpPost]
        public IActionResult VietBai(TinTuc tinTuc)
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var time = DateTime.Now;
            tinTuc.NgayDang = time;
            tinTuc.NguoiDang = HttpContext.Session.GetInt32("userID").GetValueOrDefault();
            dbContext.TinTuc.Add(tinTuc);
            dbContext.SaveChanges();

            var tinVuaThem = dbContext.TinTuc.FirstOrDefault(t => t.NgayDang == time);
            if(tinVuaThem != null)
            {
                int i = 0;
                foreach (var file in Request.Form.Files)
                {
                    HinhAnh img = new HinhAnh();
                    img.Ten = file.FileName;

                    MemoryStream ms = new MemoryStream();
                    file.CopyTo(ms);
                    img.Anh = ms.ToArray();

                    ms.Close();
                    ms.Dispose();

                    img.AnhChinh = i == 0 ? true : false; i++;

                    img.TinTuc = tinVuaThem.ID;

                    dbContext.HinhAnh.Add(img);
                    dbContext.SaveChanges();
                }
            }

            return RedirectToAction("Tin");
        }
    }
}