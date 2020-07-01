using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Data;
using BatDongSanId.Methods;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

            return View();
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

            return View();
        }
    }
}