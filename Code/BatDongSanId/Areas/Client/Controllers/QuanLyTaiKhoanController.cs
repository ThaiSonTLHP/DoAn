using System;
using System.Collections.Generic;
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
        public QuanLyTaiKhoanController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }

        public IActionResult TaiKhoan()
        {
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
                                                        AnhDaiDien = t.AnhDaiDien,
                                                        SoDuVi = t.SoDuVi,
                                                        LoaiTaiKhoan = ltk.Ten
                                                    }).FirstOrDefault();
            ViewBag.HinhAnh = LayHinhAnh(qLTKListViewModel.taiKhoanViewModel.AnhDaiDien);
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

        public IActionResult ChiTietTaiKhoan(int id)
        {
            var taiKhoan = dbContext.TaiKhoan.FirstOrDefault(t => t.ID == HttpContext.Session.GetInt32("userID"));
            return View();
        }


        public IActionResult TinDaDang()
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTin = layDuLieu.LayTinBDS(HttpContext.Session.GetInt32("userID"), 1);
            return View(listTin);
        }

        public IActionResult TinDaLuu()
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTin = layDuLieu.LayTinBDS(HttpContext.Session.GetInt32("userID"), 2);
            return View(listTin);
        }

        public IActionResult QuanLyVi()
        {
            return View();
        }

        public IActionResult XacNhan()
        {
            return View();
        }

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

        string LayHinhAnh(byte[] hinhAnh)
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
