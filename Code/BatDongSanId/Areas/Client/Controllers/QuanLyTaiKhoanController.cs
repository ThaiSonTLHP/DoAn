using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BatDongSanId.Areas.Client.Controllers
{
    [Area("Client")]
    public class QuanLyTaiKhoanController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public QuanLyTaiKhoanController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult TaiKhoan()
        {
            return View();
        }

        public IActionResult ChiTietTaiKhoan()
        {
            if(HttpContext.Session.GetString("userName") == "")
            {

            }
            var taiKhoan = _dbContext.TaiKhoan.FirstOrDefault(t => t.ID == HttpContext.Session.GetInt32("userID"));
            return View();
        }


        public IActionResult TinDaDang()
        {
            return View();
        }

        public IActionResult TinDaLuu()
        {
            return View();
        }

        public IActionResult QuanLyVi()
        {
            return View();
        }

        public IActionResult XacNhan()
        {
            return View();
        }

        public IActionResult LuuTin()
        {
            return View();
        }
    }
}
