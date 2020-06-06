using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Data;
using BatDongSanId.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TinhThanhController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public TinhThanhController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        //-------------Danh sách-------------
        public IActionResult Index()
        {
            var _tinhThanh = (from t in _dbContext.TinhThanh
                               select new TinhThanh()
                               {
                                   ID = t.ID,
                                   Ten = t.Ten
                               }).ToList();
            //ViewData["ListTinTuc"] = _tinTucList;
            return View(_tinhThanh);
        }



        //-------------Xem chi tiết-------------
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var city =  _dbContext.TinhThanh.FirstOrDefault(m => m.ID == id.ToString());

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
        public IActionResult Create(TinhThanh tinhThanh)
        {
            if (ModelState.IsValid)
            {
                _dbContext.TinhThanh.Add(tinhThanh);
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
            var city =  _dbContext.TinhThanh.Find(id);
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