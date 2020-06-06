using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BatDongSanId.Data;
using BatDongSanId.Models;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HuongController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public HuongController(ApplicationDbContext dbContext)
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