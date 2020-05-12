using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using AdminBatDongSan.Models.ViewModel;
using BatDongSanService;
using BatDongSanService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminBatDongSan.Controllers
{
    public class DSTaiKhoanController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public DSTaiKhoanController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }


        //-------------Danh sách-------------
        public IActionResult Index()
        {
            var _taiKhoan = (from t in _dbContext.TaiKhoan
                              join l in _dbContext.LoaiTaiKhoan on t.LoaiTaiKhoan equals l.ID
                              select new TaiKhoanViewModel()
                              {
                                  ID = t.ID,
                                  MatKhau = t.MatKhau,
                                  Ten = t.Ten,
                                  GioiTinh = (t.GioiTinh == true) ? "Nam" : "Nữ",
                                  Email = t.Email,
                                  SoDienThoai = t.SoDienThoai,
                                  DiaChi = t.DiaChi,
                                  SoDuVi = t.SoDuVi,
                                  LoaiTaiKhoan = l.Ten
                              }).ToList();
            return View(_taiKhoan);
        }



        //-------------Xem chi tiết-------------
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city = _dbContext.TinhThanh.FirstOrDefault(m => m.ID == id.ToString());

            if (city == null)
            {
                return NotFound();
            }

            return View(city);
        }



        //-------------Tạo mới-------------
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TaiKhoanViewModel taiKhoanViewModel)
        {
            if (ModelState.IsValid)
            {
                var loaiTaiKhoan = (from l in _dbContext.LoaiTaiKhoan
                                   where l.Ten == taiKhoanViewModel.LoaiTaiKhoan
                                   select new LoaiTaiKhoan()
                                   {
                                       ID = l.ID,
                                       Ten = l.Ten,
                                       ChucNang = l.ChucNang
                                   }).FirstOrDefault();
                var taiKhoan = new TaiKhoan();
                //taiKhoan.ID = taiKhoanViewModel.ID;
                taiKhoan.MatKhau = taiKhoanViewModel.MatKhau;
                taiKhoan.Ten = taiKhoanViewModel.Ten;
                taiKhoan.GioiTinh = (taiKhoanViewModel.GioiTinh == "Nam") ? true : false;
                taiKhoan.Email = taiKhoanViewModel.Email;
                taiKhoan.SoDienThoai = taiKhoanViewModel.SoDienThoai;
                taiKhoan.DiaChi = taiKhoanViewModel.DiaChi;
                taiKhoan.SoDuVi = taiKhoanViewModel.SoDuVi;
                taiKhoan.LoaiTaiKhoan = loaiTaiKhoan.ID;
                _dbContext.TaiKhoan.Add(taiKhoan);
                _dbContext.SaveChanges();
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
            var city = _dbContext.TinhThanh.Find(id);
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
                    _dbContext.Update(tinhThanh);
                    _dbContext.SaveChanges();
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

            var city = _dbContext.TinhThanh.FirstOrDefault(m => m.ID == id.ToString());
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
            var city = _dbContext.TinhThanh.Find(id);
            _dbContext.TinhThanh.Remove(city);
            _dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        private bool CityExists(string id)
        {
            return _dbContext.TinhThanh.Any(e => e.ID == id);
        }
    }
}