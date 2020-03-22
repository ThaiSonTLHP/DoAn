using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BatDongSan.Controllers
{
    public class DangTinController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}