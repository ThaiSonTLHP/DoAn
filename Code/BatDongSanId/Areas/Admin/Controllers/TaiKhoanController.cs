using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using BatDongSanId.Areas.Client.Models.ListViewModels;
using BatDongSanId.Data;
using BatDongSanId.Methods;
using BatDongSanId.Models;
using BatDongSanId.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TaiKhoanController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;
        private readonly CheckUser checkUser;

        public TaiKhoanController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
            checkUser = new CheckUser(dbContext);
        }


        //-------------Danh sách-------------
        public IActionResult TaiKhoan(int loaiTK = 0, int status = 0, int option = 0, string searchString = "")
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var _taiKhoan = new List<TaiKhoanViewModel>();

            if(loaiTK != 0)
            {
                if (loaiTK == 5)
                {
                    _taiKhoan = layDuLieu.LayTaiKhoan(0, "All");
                }
                if (loaiTK == 1)
                {
                    _taiKhoan = layDuLieu.LayTaiKhoan(0, "Quản trị");
                }
                if (loaiTK == 2)
                {
                    _taiKhoan = layDuLieu.LayTaiKhoan(0, "Nhân viên");
                }
                if (loaiTK == 3)
                {
                    _taiKhoan = layDuLieu.LayTaiKhoan(0, "Nhà môi giới");
                }
                if (loaiTK == 4)
                {
                    _taiKhoan = layDuLieu.LayTaiKhoan(0, "Khách hàng");
                }
            }

            if(status != 0)
            {
                _taiKhoan = layDuLieu.LayTaiKhoan(0, "All");
            }

            if(option != 0)
            {
                _taiKhoan = layDuLieu.LayTaiKhoan(0, "All");
                //id
                if (option == 1)
                {
                    _taiKhoan = _taiKhoan.Where(t => t.ID.ToString().Contains(searchString)).ToList();
                }
                //ten
                if (option == 2)
                {
                    _taiKhoan = _taiKhoan.Where(t => t.Ten.Contains(searchString)).ToList();
                }
                //email
                if (option == 3)
                {
                    _taiKhoan = _taiKhoan.Where(t => t.Email.Contains(searchString)).ToList();
                }
                //sdt
                if (option == 4)
                {
                    _taiKhoan = _taiKhoan.Where(t => t.SoDienThoai.Contains(searchString)).ToList();
                }
            }
            
            return View(_taiKhoan);
        }

        //-------------Xem chi tiết-------------
        public IActionResult Details(int id)
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            QLTKListViewModel qLTKListViewModel = new QLTKListViewModel();
            qLTKListViewModel.taiKhoanViewModel = (from t in dbContext.TaiKhoan
                                                   join ltk in dbContext.LoaiTaiKhoan on t.LoaiTaiKhoan equals ltk.ID
                                                   where t.ID == id
                                                   select new TaiKhoanViewModel()
                                                   {
                                                       ID = t.ID,
                                                       Ten = t.Ten,
                                                       Email = t.Email,
                                                       SoDienThoai = t.SoDienThoai,
                                                       DiaChi = t.DiaChi,
                                                       AnhDaiDienData = t.AnhDaiDien,
                                                       SoDuVi = t.SoDuVi,
                                                       LoaiTaiKhoan = ltk.Ten,
                                                       XacNhan = t.XacThuc
                                                   }).FirstOrDefault();
            qLTKListViewModel.taiKhoanViewModel.AnhDaiDienUrl = LayUrlHinhAnh(qLTKListViewModel.taiKhoanViewModel.AnhDaiDienData);
            qLTKListViewModel.soTinDang = (from tin in dbContext.TinBatDongSan
                                           join tk in dbContext.TaiKhoan on tin.NguoiDang equals tk.ID
                                           where tk.ID == id
                                           select new TinBatDongSan() { ID = tin.ID }).ToList().Count();
            qLTKListViewModel.soTinLuu = (from luu in dbContext.LuuTinBatDongSan
                                          join tk in dbContext.TaiKhoan on luu.TaiKhoan equals tk.ID
                                          join tin in dbContext.TinBatDongSan on luu.TinBatDongSan equals tin.ID
                                          where tk.ID == id
                                          select new TinBatDongSan() { ID = tin.ID }).ToList().Count();
            if (qLTKListViewModel == null)
            {
                return NotFound();
            }
            return View(qLTKListViewModel);
        }



        //-------------Tạo mới-------------
        public IActionResult Create()
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            List<LoaiTaiKhoan> LoaiTaiKhoanList = dbContext.LoaiTaiKhoan.ToList();
            ViewBag.LoaiTaiKhoanList = new SelectList(LoaiTaiKhoanList, "ID", "Ten");
            List<string> gioiTinh = new List<string>
            {
                "Nam", "Nữ"
            };
            ViewBag.GioiTinh = new SelectList(gioiTinh);
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaiKhoanViewModel taiKhoanViewModel)
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
                return RedirectToAction("TaiKhoan", "TaiKhoan");
            }
            return View();
        }



        //-------------Sửa-------------
        public IActionResult Edit(int? id)
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            if (id == null)
            {
                return NotFound();
            }
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var user = layDuLieu.ChiTietTaiKhoan(id.GetValueOrDefault());
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TaiKhoanViewModel taiKhoan)
        {
            if (!checkUser.CheckSuperAdmin(HttpContext.Session.GetInt32("userID")))
            {
                if (checkUser.CheckAdmin(HttpContext.Session.GetInt32("userID")))
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                return RedirectToAction("Login", "DangNhap", new { area = "Client" });
            }

            if (id != taiKhoan.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    dbContext.Update(taiKhoan);
                    dbContext.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserExists(taiKhoan.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "TaiKhoan");
            }
            return View(taiKhoan);
        }

        private bool UserExists(int id)
        {
            return dbContext.TaiKhoan.Any(e => e.ID == id);
        }

        //-------------------ajax
        public void NapTien(int id, string tien)
        {
            var taiKhoan = dbContext.TaiKhoan.FirstOrDefault(t => t.ID == id);
            taiKhoan.SoDuVi += double.Parse(tien);
            dbContext.Update(taiKhoan);
            dbContext.SaveChanges();
        }


        public void Khoa(int id)
        {
            var taiKhoan = dbContext.TaiKhoan.FirstOrDefault(t => t.ID == id);
            taiKhoan.XacThuc = false;
            dbContext.Update(taiKhoan);
            dbContext.SaveChanges();
            Mail.SendMail(taiKhoan.Email,
                "Khóa tài khoản",
                "Tài khoản của bạn tại http://batdongsanhp.karion.com.vn đã bị khóa, vui lòng liên hệ với website hoặc số điện thoại: 0339436790 để biết thêm thông tin.");
        }

        public void MoKhoa(int id)
        {
            var taiKhoan = dbContext.TaiKhoan.FirstOrDefault(t => t.ID == id);
            taiKhoan.XacThuc = true;
            dbContext.Update(taiKhoan);
            dbContext.SaveChanges();
            Mail.SendMail(taiKhoan.Email,
                "Mở khóa tài khoản",
                "Tài khoản của bạn tại http://batdongsanhp.karion.com.vn đã được mở khóa, vui lòng liên hệ với website hoặc số điện thoại: 0339436790 để biết thêm thông tin.");
        }

        public bool Xoa(int id)
        {
            if(HttpContext.Session.GetInt32("userID").GetValueOrDefault() == id)
            {
                return false;
            }
            else
            {
                var taiKhoan = dbContext.TaiKhoan.Find(id);
                var listTin = (from t in dbContext.TinBatDongSan
                               where t.NguoiDang == taiKhoan.ID
                               select new TinBatDongSan()
                               {
                                   ID = t.ID
                               }).ToList();
                foreach (var tin in listTin)
                {
                    var listAnh = (from t in dbContext.HinhAnh
                                   where t.TinBatDongSan == tin.ID
                                   select new HinhAnh()
                                   {
                                       ID = t.ID
                                   }).ToList();
                    foreach (var anh in listAnh)
                    {
                        var hinhAnh = dbContext.HinhAnh.Find(anh.ID);
                        dbContext.HinhAnh.Remove(hinhAnh);
                        dbContext.SaveChanges();
                    }
                    var _tin = dbContext.TinBatDongSan.Find(tin.ID);
                    dbContext.TinBatDongSan.Remove(_tin);
                    dbContext.SaveChanges();
                }
                Mail.SendMail(taiKhoan.Email,
                    "Xóa tài khoản",
                    "Tài khoản của bạn tại http://batdongsanhp.karion.com.vn đã bị xóa do vi phạm quy định. " +
                    "Mọi thông tin cá nhân và các tin bất động sản đã đăng/ lưu của bạn đều bị xóa. Vui lòng liên " +
                    "hệ 0339436790 để biết thêm thông tin!");
                dbContext.TaiKhoan.Remove(taiKhoan);
                dbContext.SaveChanges();
                return true;
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