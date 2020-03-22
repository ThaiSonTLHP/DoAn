using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanService;
using BatDongSanService.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdminBatDongSan.Controllers
{
    public class TinhThanhController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public TinhThanhController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var _tinhThanh = (from t in _dbContext.TinhThanh
                               select new TinhThanh()
                               {
                                   Id = t.Id,
                                   Ten = t.Ten,
                               }).ToList();
            //ViewData["ListTinTuc"] = _tinTucList;
            return View(_tinhThanh);
        }
    }
}