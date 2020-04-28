using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanService;
using BatDongSanService.Models;
using Microsoft.AspNetCore.Mvc;

namespace BatDongSan.Controllers
{
    public class DangTinController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public DangTinController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult Create(TinBatDongSan client)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(client);
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(client);
        //}
    }
}