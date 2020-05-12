using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BatDongSanService.Models;
using BatDongSanService;

namespace AdminBatDongSan.Controllers
{
    public class HuongController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public HuongController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var _huong = (from h in _dbContext.Huong
                              select new Huong()
                              {
                                  ID = h.ID,
                                  Ten = h.Ten
                              }).ToList();
            return View(_huong);
        }
    }
}