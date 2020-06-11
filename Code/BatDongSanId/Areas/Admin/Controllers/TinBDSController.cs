using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Data;
using BatDongSanId.Models;
using Microsoft.AspNetCore.Mvc;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TinBDSController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public TinBDSController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ChoPheDuyet()
        {
            var listTin = (from t in _dbContext.TinBatDongSan
                           join lt in _dbContext.LoaiTinBatDongSan on t.LoaiTin equals lt.ID
                           join gt in _dbContext.GoiTin on t.GoiTin equals gt.ID
                           join tk in _dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                           where t.TrangThaiDuyet == false
                           select new TinBDSViewModel {
                               ID = t.ID,
                               LoaiTin = lt.Ten,
                               GoiTin = gt.Ten,
                               NgayDang = t.NgayDang,
                               NguoiDang = tk.Ten,
                               TieuDe = t.TieuDe,
                               LienHe = tk.SoDienThoai,
                               PheDuyet = t.TrangThaiDuyet
                           }).ToList();
            return View(listTin);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ChoPheDuyet(int? id)
        {
            var tin = _dbContext.TinBatDongSan.FirstOrDefault(t => t.ID == id);
            tin.TrangThaiDuyet = true;
            _dbContext.TinBatDongSan.Update(tin);
            _dbContext.SaveChanges();
            return View();
        }
    }
}
