using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Data;
using BatDongSanService;
using BatDongSanService.Models;
using Microsoft.AspNetCore.Mvc;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MucDienTichController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public MucDienTichController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IActionResult Index()
        {
            var _mucDienTich = (from t in _dbContext.MucDienTich
                              select new MucDienTich()
                              {
                                  ID = t.ID,
                                  Ten = t.Ten,
                                  Min = t.Min,
                                  Max = t.Max
                              }).ToList();
            //ViewData["ListTinTuc"] = _tinTucList;
            return View(_mucDienTich);
        }
    }
}