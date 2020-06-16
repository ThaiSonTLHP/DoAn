using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Data;
using BatDongSanId.Methods;
using BatDongSanId.Models;
using BatDongSanId.ViewModels;
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

        public TaiKhoanController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }


        //-------------Danh sách-------------
        public IActionResult All(int? flag)
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var _taiKhoan = new List<TaiKhoanViewModel>();
            if (flag != null)
            {
                if(flag == 1)
                {
                    _taiKhoan = layDuLieu.LayTaiKhoan(0, "Quản trị");
                }
                if (flag == 2)
                {
                    _taiKhoan = layDuLieu.LayTaiKhoan(0, "Nhân viên");
                }
                if (flag == 3)
                {
                    _taiKhoan = layDuLieu.LayTaiKhoan(0, "Nhà môi giới");
                }
                if (flag == 4)
                {
                    _taiKhoan = layDuLieu.LayTaiKhoan(0, "Khách hàng");
                }
            }
            else
            {
                ViewBag.Error = "Xảy ra lỗi!";
            }
            return View(_taiKhoan);
        }

        //-------------Xem chi tiết-------------
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = dbContext.TinhThanh.FirstOrDefault(m => m.ID == id.ToString());

            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }



        //-------------Tạo mới-------------
        public IActionResult Create()
        {
            List<LoaiTaiKhoan> LoaiTaiKhoanList = dbContext.LoaiTaiKhoan.ToList();
            ViewBag.LoaiTaiKhoanList = new SelectList(LoaiTaiKhoanList, "ID", "Ten");
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
                taiKhoan.SoDuVi = taiKhoanViewModel.SoDuVi;
                taiKhoan.LoaiTaiKhoan = int.Parse(taiKhoanViewModel.LoaiTaiKhoan);
                dbContext.TaiKhoan.Add(taiKhoan);
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }



        //-------------Sửa-------------
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var city = dbContext.TinhThanh.Find(id);
            if (city == null)
            {
                return NotFound();
            }
            return View(city);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, TinhThanh tinhThanh)
        {
            if (id.ToString() != tinhThanh.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    dbContext.Update(tinhThanh);
                    dbContext.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CityExists(tinhThanh.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tinhThanh);
        }



        //-------------Xóa-------------
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = dbContext.TinhThanh.FirstOrDefault(m => m.ID == id.ToString());
            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var city = dbContext.TinhThanh.Find(id);
            dbContext.TinhThanh.Remove(city);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool CityExists(string id)
        {
            return dbContext.TinhThanh.Any(e => e.ID == id);
        }
    }
}