﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Mail;
using System.Net;
using System.Timers;
using System.IO;
using BatDongSanId.Data;
using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.ViewModels;
using BatDongSanId.Models;
using BatDongSanId.Methods;
using Microsoft.EntityFrameworkCore.Internal;

namespace BatDongSanId.Areas.Client.Controllers
{
    [Area("Client")]
    public class DangNhapController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public DangNhapController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("LoginMessage") != null && HttpContext.Session.GetString("LoginMessage") != "")
            {
                ViewBag.LoginMessage = "Vui lòng đăng nhập trước khi đăng tin!";
            }
            else
            {
                ViewBag.LoginMessage = "";
            }
            return View(); 
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var _taiKhoan = dbContext.TaiKhoan.FirstOrDefault(s => s.Email.Equals(username) && s.MatKhau.Equals(password));
            if(_taiKhoan != null && _taiKhoan.XacThuc != false)
            {
                var _loaiTK = dbContext.LoaiTaiKhoan.FirstOrDefault(l => l.ID.Equals(_taiKhoan.LoaiTaiKhoan));
                HttpContext.Session.SetString("username", _taiKhoan.Ten);
                HttpContext.Session.SetString("usertype", _loaiTK.Ten);
                HttpContext.Session.SetInt32("userID", _taiKhoan.ID);

                if (_loaiTK.Ten == "Nhà môi giới")
                {
                    if (HttpContext.Session.GetString("LoginMessage") != null && HttpContext.Session.GetString("LoginMessage") != "")
                    {
                        HttpContext.Session.Remove("LoginMessage");
                        return RedirectToAction("DangTin", "DangTin");
                    }
                    //else if (HttpContext.Session.GetInt32("ChiTietTinFlag") != null)
                    //{
                    //    int? id = HttpContext.Session.GetInt32("ChiTietTinFlag");
                    //    HttpContext.Session.Remove("ChiTietTinFlag");
                    //    return RedirectToAction("ChiTietTinBDS", "Dm", id);
                    //}
                    else
                    {
                        return RedirectToAction("TaiKhoan", "QuanLyTaiKhoan");
                    }
                }
                else
                {
                    if (HttpContext.Session.GetString("LoginMessage") != null && HttpContext.Session.GetString("LoginMessage") != "")
                    {
                        HttpContext.Session.Remove("LoginMessage");
                    }
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return RedirectToAction("Login");
            }
        }


        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("usertype");
            HttpContext.Session.Remove("userID");
            return RedirectToAction("Index","TrangChu");
        }


        public IActionResult Successed()
        {
            return View();
        }

        private byte[] GetByteArrayFromImage(IFormFile file)
        {
            using (var target = new MemoryStream())
            {
                file.CopyTo(target);
                return target.ToArray();
            }
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Register()
        {
            List<LoaiTaiKhoan> LoaiTaiKhoanList = (from l in dbContext.LoaiTaiKhoan
                                                   where l.ID == 3 || l.ID == 4
                                                   select new LoaiTaiKhoan()
                                                   {
                                                       ID = l.ID,
                                                       Ten = l.Ten,
                                                       ChucNang = l.ChucNang
                                                   }
                                                  ).ToList();
            ViewBag.LoaiTaiKhoanList = new SelectList(LoaiTaiKhoanList, "ID", "Ten");
            List<string> gioiTinh = new List<string>
            {
                "Nam", "Nữ"
            };
            ViewBag.GioiTinh = new SelectList(gioiTinh);
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
                taiKhoan.XacThuc = true;
                taiKhoan.SoDuVi = 0;
                taiKhoan.LoaiTaiKhoan = int.Parse(taiKhoanViewModel.LoaiTaiKhoan);

                foreach (var file in Request.Form.Files)
                {
                    MemoryStream ms = new MemoryStream();
                    file.CopyTo(ms);
                    taiKhoan.AnhDaiDien = ms.ToArray();
                    ms.Close();
                    ms.Dispose();
                }

                dbContext.TaiKhoan.Add(taiKhoan);
                dbContext.SaveChanges();
                return RedirectToAction("Index","TrangChu");
            }
            return View();
        }

        public IActionResult KhoiPhucMatKhau()
        {
            ViewBag.Status = "Chua thay doi";
            return View();
        }

        [HttpPost]
        public IActionResult KhoiPhucMatKhau(QuenMKViewModel quenMKViewModel)
        {
            var account = dbContext.TaiKhoan.FirstOrDefault(t => t.Email == quenMKViewModel.TaiKhoan && t.SoDienThoai == quenMKViewModel.SoDienThoai);
            account.MatKhau = quenMKViewModel.MatKhauMoi;
            dbContext.Update(account);
            dbContext.SaveChanges();
            ViewBag.Status = "Thay đổi mật khẩu thành công!";
            return View();
        }


        public string SendCode(string add)
        {
            var taiKhoan = dbContext.TaiKhoan.FirstOrDefault(t => t.Email == add);
            if (taiKhoan != null)
            {
                return "Email đã được sử dụng cho một tài khoản khác!";
            }
            else
            {
                Random random = new Random();
                string _random = random.Next(100000, 999999).ToString();
                string subject = "Xác thực đăng ký tài khoản";
                string body = _random + " là mã xác nhận của bạn.";
                Mail.SendMail(add, subject, body);
                return "Mã xác nhận vừa được gửi đến email của bạn!";
            }
        }


        public bool CheckAccount(string _account, string _phone)
        {
            var account = dbContext.TaiKhoan.FirstOrDefault(t => t.Email == _account && t.SoDienThoai == _phone);
            if (account != null)
                return true;
            else
                return false;
        }



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