﻿using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ListViewModels
{
    public class ChiTietBDSListViewModel
    {
        public TinBDSViewModel tinBDSViewModel { get; set; }
        public List<string> hinhAnhs { get; set; }
    }
}