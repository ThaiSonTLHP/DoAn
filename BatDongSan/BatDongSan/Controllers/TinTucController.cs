using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BatDongSan.Models;
using BatDongSan.Models.ViewModels;
using BatDongSanService;

namespace BatDongSan.Controllers
{
    public class TinTucController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public TinTucController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var _tinTucList = (from t in _dbContext.TinTuc
                               join lt in _dbContext.LoaiTinTuc on t.LoaiTinTucID equals lt.Id
                               join tk in _dbContext.TKQuanTri on t.QuanTriId equals tk.Id
                               select new TinTucViewModel()
                               {
                                   Id = t.Id,
                                   TieuDe = t.TieuDe,
                                   NgayDang = t.Ngaydang,
                                   LoaiTinTuc = lt.Ten,
                                   NguoiQuanTri = tk.TenNhanVien,
                                   NoiDung = t.NoiDung
                               }).ToList();
            //ViewData["ListTinTuc"] = _tinTucList;
            return View(_tinTucList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tinTuc = (from t in _dbContext.TinTuc
                          join lt in _dbContext.LoaiTinTuc on t.LoaiTinTucID equals lt.Id
                          join tk in _dbContext.TKQuanTri on t.QuanTriId equals tk.Id
                          where t.Id == id
                          select new TinTucViewModel()
                          {
                              Id = t.Id,
                              TieuDe = t.TieuDe,
                              NgayDang = t.Ngaydang,
                              LoaiTinTuc = lt.Ten,
                              NguoiQuanTri = tk.TenNhanVien,
                              NoiDung = t.NoiDung
                          }).ToList();
            return View(tinTuc);
        }
    }
}