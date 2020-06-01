using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanService;
using BatDongSanService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BatDongSan.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(LoaiTaiKhoan = "")]
    public class LoaiBatDongSanController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public LoaiBatDongSanController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
