using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BatDongSanId.Data;
using Microsoft.Extensions.Configuration;
using BatDongSanId.Methods;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;
        private readonly CheckUser checkUser;

        public HomeController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
            checkUser = new CheckUser(dbContext);
        }
        public IActionResult Index()
        {
            if (!checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
            {
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var taiKhoan = layDuLieu.ChiTietTaiKhoan(HttpContext.Session.GetInt32("userID").GetValueOrDefault());
            return View(taiKhoan);
        }
    }
}
