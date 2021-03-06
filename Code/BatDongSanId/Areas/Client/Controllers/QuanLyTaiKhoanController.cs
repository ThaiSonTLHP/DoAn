﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Areas.Client.Models.ListViewModels;
using BatDongSanId.Data;
using BatDongSanId.Methods;
using BatDongSanId.Models;
using BatDongSanId.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BatDongSanId.Areas.Client.Controllers
{
    [Area("Client")]
    public class QuanLyTaiKhoanController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;
        private readonly CheckUser checkUser;

        public QuanLyTaiKhoanController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
            checkUser = new CheckUser(dbContext);
        }

        public IActionResult TaiKhoan()
        {
            if (!checkUser.CheckClient(HttpContext.Session.GetInt32("userID")))
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });

            QLTKListViewModel qLTKListViewModel = new QLTKListViewModel();
            qLTKListViewModel.taiKhoanViewModel = (from t in dbContext.TaiKhoan
                                                    join ltk in dbContext.LoaiTaiKhoan on t.LoaiTaiKhoan equals ltk.ID
                                                    where (ltk.Ten == "Nhà môi giới" || ltk.Ten == "Khách hàng")
                                                    && t.ID == HttpContext.Session.GetInt32("userID")
                                                    select new TaiKhoanViewModel()
                                                    {
                                                        Ten = t.Ten,
                                                        Email = t.Email,
                                                        SoDienThoai = t.SoDienThoai,
                                                        DiaChi = t.DiaChi,
                                                        AnhDaiDienData = t.AnhDaiDien,
                                                        SoDuVi = t.SoDuVi,
                                                        LoaiTaiKhoan = ltk.Ten
                                                    }).FirstOrDefault();
            qLTKListViewModel.taiKhoanViewModel.AnhDaiDienUrl = LayUrlHinhAnh(qLTKListViewModel.taiKhoanViewModel.AnhDaiDienData);
            qLTKListViewModel.soTinDang = (from tin in dbContext.TinBatDongSan
                                          join tk in dbContext.TaiKhoan on tin.NguoiDang equals tk.ID
                                          where tk.ID == HttpContext.Session.GetInt32("userID")
                                          select new TinBatDongSan(){ID = tin.ID}).ToList().Count();
            qLTKListViewModel.soTinLuu = (from luu in dbContext.LuuTinBatDongSan
                                          join tk in dbContext.TaiKhoan on luu.TaiKhoan equals tk.ID
                                          join tin in dbContext.TinBatDongSan on luu.TinBatDongSan equals tin.ID
                                          where tk.ID == HttpContext.Session.GetInt32("userID")
                                          select new TinBatDongSan() { ID = tin.ID }).ToList().Count();

            return View(qLTKListViewModel);
        }

        public IActionResult TinDaDang()
        {
            if (!checkUser.CheckClient(HttpContext.Session.GetInt32("userID")))
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTin = layDuLieu.LayTinBDS(HttpContext.Session.GetInt32("userID"), 1);
            listTin.Reverse();
            return View(listTin);
        }

        public IActionResult TinDaLuu()
        {
            if (!checkUser.CheckClient(HttpContext.Session.GetInt32("userID")))
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTin = layDuLieu.LayTinBDS(HttpContext.Session.GetInt32("userID"), 2);
            listTin.Reverse();
            return View(listTin);
        }

        public IActionResult DoiMatKhau()
        {
            if (!checkUser.CheckClient(HttpContext.Session.GetInt32("userID")))
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            return View();
        }

        public IActionResult XacNhan()
        {
            if (!checkUser.CheckClient(HttpContext.Session.GetInt32("userID")))
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });

            return View();
        }



        //-----------------------them anh
        public IActionResult CapNhatTaiKhoan()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CapNhatTaiKhoan(TaiKhoanViewModel taiKhoanViewModel)
        {
            var taiKhoan = dbContext.TaiKhoan.FirstOrDefault(t => t.ID == taiKhoanViewModel.ID);
            foreach (var file in Request.Form.Files)
            {
                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                taiKhoan.AnhDaiDien = ms.ToArray();
                ms.Close();
                ms.Dispose();
            }
            dbContext.Update(taiKhoan);
            dbContext.SaveChanges();
            return View();
        }

        public IActionResult CapNhatTin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CapNhatTin(TinBatDongSan tinBatDongSan)
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

                img.TinBatDongSan = tinBatDongSan.ID;

                dbContext.HinhAnh.Add(img);
                dbContext.SaveChanges();
            }
            return View();
        }

        public IActionResult CapNhatNgay()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CapNhatNgay(TinBatDongSan tinBatDongSan)
        {
            var tinBDS = dbContext.TinBatDongSan.FirstOrDefault(t => t.ID == tinBatDongSan.ID);
            tinBDS.NgayLenBangTin = tinBatDongSan.NgayLenBangTin;
            dbContext.Update(tinBDS);
            dbContext.SaveChanges();
            return View();
        }

        public IActionResult CapNhatNgayDang()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CapNhatNgayDang(TinBatDongSan tinBatDongSan)
        {
            var tinBDS = dbContext.TinBatDongSan.FirstOrDefault(t => t.ID == tinBatDongSan.ID);
            tinBDS.NgayDang = tinBatDongSan.NgayDang;
            dbContext.Update(tinBDS);
            dbContext.SaveChanges();
            return View();
        }



        //--------------------ajax
        public void LuuTin(int idUser, int idTin)
        {
            if(dbContext.LuuTinBatDongSan.FirstOrDefault(x => x.TaiKhoan == idUser && x.TinBatDongSan == idTin) == null)
            {
                var luuTin = new LuuTinBatDongSan();
                luuTin.TaiKhoan = idUser;
                luuTin.TinBatDongSan = idTin;
                dbContext.LuuTinBatDongSan.Add(luuTin);
                dbContext.SaveChanges();
            }
        }

        public void BoLuuTin(int idUser, int idTin)
        {
            var luu = dbContext.LuuTinBatDongSan.FirstOrDefault(x => x.TaiKhoan == idUser && x.TinBatDongSan == idTin);
            dbContext.LuuTinBatDongSan.Remove(luu);
            dbContext.SaveChanges();
        }

        public void XacNhanDaBan(int idTin)
        {
            var tin = dbContext.TinBatDongSan.FirstOrDefault(t => t.ID == idTin);
            tin.TrangThaiGiaoDich = true;
            tin.NgayXacNhan = DateTime.Now;
            dbContext.Update(tin);
            dbContext.SaveChanges();
        }

        public string ChangePass(string pass, string newPass)
        {
            var user = dbContext.TaiKhoan.FirstOrDefault(x => x.ID == HttpContext.Session.GetInt32("userID").GetValueOrDefault());
            if(user.MatKhau == pass)
            {
                user.MatKhau = newPass;
                dbContext.Update(user);
                dbContext.SaveChanges();
                return "Thay đổi mật khẩu thành công!";
            }
            else
            {
                return "Mật khẩu cũ không đúng!";
            }
        }

        public bool GiaHan(int id, int goitin)
        {
            var tin = dbContext.TinBatDongSan.Find(id);
            var user = dbContext.TaiKhoan.Find(tin.NguoiDang);
            var goiTin = dbContext.GoiTin.Find(goitin);
            if(user.SoDuVi >= goiTin.MucPhi)
            {
                user.SoDuVi -= goiTin.MucPhi;
                tin.GoiTin = 1;
                tin.TrangThaiDuyet = true;
                tin.HetHan = 0;
                dbContext.Update(user);
                dbContext.Update(tin);
                dbContext.SaveChanges();
                return true;
            }
            else
            {
                tin.GoiTin = 1;
                tin.TrangThaiDuyet = false;
                tin.HetHan = 0;
                dbContext.Update(tin);
                dbContext.SaveChanges();
                return false;
            }
        }

        string LayUrlHinhAnh(byte[] hinhAnh)
        {
            string anhDataURL;
            if (hinhAnh != null)
            {
                string anhBase64Data = Convert.ToBase64String(hinhAnh);
                anhDataURL = string.Format("data:image/jpg;base64,{0}", anhBase64Data);
            }
            else
            {
                anhDataURL = "~/Client/img/rooms/1.jpg";
            }
            return anhDataURL;
        }
    }
}
