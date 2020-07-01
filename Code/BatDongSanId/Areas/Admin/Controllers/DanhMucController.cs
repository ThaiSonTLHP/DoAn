using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Areas.Admin.Models.ViewModel;
using BatDongSanId.Data;
using BatDongSanId.Methods;
using BatDongSanId.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DanhMucController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;
        private readonly CheckUser checkUser;

        public DanhMucController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
            checkUser = new CheckUser(dbContext);
        }

        public IActionResult LoaiTinBDS()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var loaiTin = (from t in dbContext.LoaiTinBatDongSan
                              select new LoaiTinBatDongSan()
                              {
                                  ID = t.ID,
                                  Ten = t.Ten
                              }).ToList();
            return View(loaiTin);
        }

        public IActionResult LoaiTinTuc()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var loaiTin = (from t in dbContext.LoaiTinTuc
                           select new LoaiTinTuc()
                           {
                               ID = t.ID,
                               Ten = t.Ten,
                               MoTa = t.MoTa
                           }).ToList();
            return View(loaiTin);
        }

        public IActionResult TinhThanh()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var tinhThanh = (from t in dbContext.TinhThanh
                             select new TinhThanh()
                             {
                                 ID = t.ID,
                                 Ten = t.Ten
                             }).ToList();
            return View(tinhThanh);
        }

        public IActionResult QuanHuyen()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var quanHuyen = (from q in dbContext.QuanHuyen
                             join t in dbContext.TinhThanh on q.TinhThanh equals t.ID
                             select new QuanHuyenViewModel()
                             {
                                 ID = q.ID,
                                 Ten = q.Ten,
                                 TinhThanh = t.Ten
                             }).ToList();
            return View(quanHuyen);
        }

        public IActionResult MucGia()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var mucGia = (from m in dbContext.MucGia
                             select new MucGia()
                             {
                                 ID = m.ID,
                                 Ten = m.Ten,
                                 Min = m.Min,
                                 Max = m.Max
                             }).ToList();
            return View(mucGia);
        }

        public IActionResult MucDienTich()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var mucDienTich = (from m in dbContext.MucDienTich
                             select new MucDienTich()
                             {
                                 ID = m.ID,
                                 Ten = m.Ten,
                                 Min = m.Min,
                                 Max = m.Max
                             }).ToList();
            return View(mucDienTich);
        }

        public IActionResult LoaiBDS()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var loai = (from l in dbContext.LoaiBatDongSan
                             select new LoaiBatDongSan()
                             {
                                 ID = l.ID,
                                 Ten = l.Ten
                             }).ToList();
            return View(loai);
        }

        public IActionResult GoiTin()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var goiTin = (from g in dbContext.GoiTin
                             select new GoiTin()
                             {
                                 ID = g.ID,
                                 Ten = g.Ten,
                                 MucPhi = g.MucPhi
                             }).ToList();
            return View(goiTin);
        }

        public IActionResult Huong()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var huong = (from h in dbContext.Huong
                             select new Huong()
                             {
                                 ID = h.ID,
                                 Ten = h.Ten
                             }).ToList();
            return View(huong);
        }

        public IActionResult LoaiTaiKhoan()
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                {
                    return RedirectToAction("Index", "Home");
                }
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            var loai = (from l in dbContext.LoaiTaiKhoan
                         select new LoaiTaiKhoan()
                         {
                             ID = l.ID,
                             Ten = l.Ten,
                             ChucNang = l.ChucNang
                         }).ToList();
            return View(loai);
        }
    }
}
