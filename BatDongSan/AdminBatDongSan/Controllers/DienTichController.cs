﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminBatDongSan.Controllers
{
    public class DienTichController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}