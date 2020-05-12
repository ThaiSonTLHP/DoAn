using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanService;
using BatDongSanService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Design;

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

        [HttpPost]
        public IActionResult Index(TinBatDongSan tinBatDongSan)
        {
            if (ModelState.IsValid)
            {
                _dbContext.TinBatDongSan.Add(tinBatDongSan);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        //public IActionResult Them()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Them(TinBatDongSan tinBatDongSan)
        //{
        //    //if (ModelState.IsValid)
        //    //{
        //    //    _context.Add(client);
        //    //    return RedirectToAction(nameof(Index));
        //    //}
        //    return View();
        //}
    }
}