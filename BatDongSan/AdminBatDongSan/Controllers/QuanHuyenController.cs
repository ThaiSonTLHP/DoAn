using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminBatDongSan.Controllers
{
    public class QuanHuyenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}