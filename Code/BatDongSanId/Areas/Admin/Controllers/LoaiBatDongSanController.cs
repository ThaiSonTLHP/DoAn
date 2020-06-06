using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(LoaiTaiKhoan = "")]
    public class LoaiBatDongSanController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public LoaiBatDongSanController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
