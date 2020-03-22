using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdminBatDongSan.Models;
using BatDongSanService;
using BatDongSanService.Models;

namespace AdminBatDongSan.Controllers
{
    public class HomeController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public HomeController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            //var _tinTucList = (from t in _dbContext.TinTuc
            //                   join lt in _dbContext.LoaiTinTuc on t.LoaiTinTucID equals lt.Id
            //                   join tk in _dbContext.TKQuanTri on t.QuanTriId equals tk.Id
            //                   select new TinTucViewModel()
            //                   {
            //                       Id = t.Id,
            //                       TieuDe = t.TieuDe,
            //                   }).ToList();
            //IList<TinTucViewModel> tinTucList = _tinTucList;
            return View();
        }
    }
}
