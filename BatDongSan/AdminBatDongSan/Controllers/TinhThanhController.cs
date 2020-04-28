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
                                   ID = t.ID,
                                   Ten = t.Ten
                               }).ToList();
            //ViewData["ListTinTuc"] = _tinTucList;
            return View(_tinhThanh);
        }

        [HttpGet]
        public PartialViewResult Edit(int id)
        {
            var tinhThanh = from t in _dbContext.TinhThanh
                            where t.ID == id
                            select new TinhThanh()
                            {
                                ID = t.ID,
                                Ten = t.Ten
                            };
            return PartialView(tinhThanh);
        }

        [HttpPost]
        public IActionResult Edit(TinhThanh tinhThanh)
        {
            var _tinhThanh = _dbContext.TinhThanh.Single(t => t.ID == tinhThanh.ID);
            _tinhThanh.Ten = tinhThanh.Ten;
            _dbContext.SaveChanges();
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult Delete()
        {
            //code xử lý để dưới đây


            return View();
        }
    }
}