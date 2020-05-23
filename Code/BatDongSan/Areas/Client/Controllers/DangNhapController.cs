using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using BatDongSanService.ViewModels;
using BatDongSan.Models.ViewModels;
using BatDongSanService;
using BatDongSanService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Mail;

namespace BatDongSan.Areas.Client.Controllers
{
    [Area("Client")]
    public class DangNhapController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public DangNhapController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Login()
        {
            return View(); 
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var _taiKhoan = _dbContext.TaiKhoan.FirstOrDefault(s => s.Email.Equals(username) && s.MatKhau.Equals(password));
            if(_taiKhoan != null && _taiKhoan.XacThuc != false)
            {
                var _loaiTK = _dbContext.LoaiTaiKhoan.FirstOrDefault(l => l.ID.Equals(_taiKhoan.LoaiTaiKhoan));
                HttpContext.Session.SetString("username", _taiKhoan.Ten);
                HttpContext.Session.SetInt32("userID", _taiKhoan.ID);
                if (_loaiTK.Ten == "Nhà môi giới")
                {
                    return RedirectToAction("Successed", "DangNhap");
                }
                else
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return RedirectToAction("Failed");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("userID");
            return RedirectToAction("Index");

            //return RedirectToAction("action", "controller", new { area = "area" });
        }

        public IActionResult Successed()
        {
            return View();
        }

        public IActionResult Failed()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Register()
        {
            List<LoaiTaiKhoan> LoaiTaiKhoanList = _dbContext.LoaiTaiKhoan.ToList();
            ViewBag.LoaiTaiKhoanList = new SelectList(LoaiTaiKhoanList, "ID", "Ten");
            return View();
        }

        [HttpPost]
        public IActionResult Register(TaiKhoanViewModel taiKhoanViewModel)
        {
            if (ModelState.IsValid)
            {
                var taiKhoan = new TaiKhoan();
                taiKhoan.MatKhau = taiKhoanViewModel.MatKhau;
                taiKhoan.Ten = taiKhoanViewModel.Ten;
                taiKhoan.GioiTinh = (taiKhoanViewModel.GioiTinh == "Nam") ? true : false;
                taiKhoan.Email = taiKhoanViewModel.Email;
                taiKhoan.SoDienThoai = taiKhoanViewModel.SoDienThoai;
                taiKhoan.DiaChi = taiKhoanViewModel.DiaChi;
                taiKhoan.SoDuVi = 0;
                taiKhoan.LoaiTaiKhoan = int.Parse(taiKhoanViewModel.LoaiTaiKhoan);
                _dbContext.TaiKhoan.Add(taiKhoan);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(Register));
            }
            return View();
        }


        //create a string MD5
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
    }
}