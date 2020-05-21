using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BatDongSan.Areas.Client.Controllers
{
    [Area("Client")]
    public class GioiThieuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}