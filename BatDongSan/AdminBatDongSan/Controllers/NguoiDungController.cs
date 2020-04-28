using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminBatDongSan.Models.ViewModel;
using BatDongSanService;
using BatDongSanService.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminBatDongSan.Controllers
{
    public class NguoiDungController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public NguoiDungController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var nguoiDungs = (from t in _dbContext.NguoiDung
                            join cv in _dbContext.ChucVu on t.ChucVu equals cv.ID
                            select new NguoiDungViewModel()
                            {
                                ID = t.ID,
                                Ten = t.Ten,
                                SoBaiDang = t.SoBaiDang,
                                Email = t.Email,
                                SoDienThoai = t.SoDienThoai,
                                DiaChi = t.DiaChi,
                                ChucVu = cv.Ten
                            }).ToList();
            return View(nguoiDungs);
        }
    }
}