using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminBatDongSan.Models.ViewModel;
using BatDongSanService;
using BatDongSanService.Models;
using Microsoft.AspNetCore.Mvc;

namespace BatDongSan.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NguoiDungController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public NguoiDungController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var nguoiDungs = (from t in _dbContext.TaiKhoan
                            join ltk in _dbContext.LoaiTaiKhoan on t.LoaiTaiKhoan equals ltk.ID
                            select new NguoiDungViewModel()
                            {
                                Ten = t.Ten,
                                Email = t.Email,
                                SoDienThoai = t.SoDienThoai,
                                DiaChi = t.DiaChi,
                                ChucVu = ltk.Ten
                            }).ToList();
            return View(nguoiDungs);
        }
    }
}