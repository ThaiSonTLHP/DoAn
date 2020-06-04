using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TinTucController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}