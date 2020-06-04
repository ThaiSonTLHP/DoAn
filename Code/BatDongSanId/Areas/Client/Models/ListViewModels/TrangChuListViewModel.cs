﻿using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ListViewModels
{
    public class TrangChuListViewModel
    {
        public List<TinBanViewModel> TinBanViewModels { get; set; }
        public List<TinMuaViewModel> TinMuaViewModels { get; set; }
        public List<TinVIPViewModel> TinVIPViewModels { get; set; }
        public List<TinThueViewModel> TinThueViewModels { get; set; }
        public List<TinChoThueViewModel> TinChoThueViewModels { get; set; }
        public List<NhaMoiGioiViewModel> NhaMoiGioiViewModels { get; set; }
        public List<TinTucViewModel> TinTucViewModels { get; set; }
        public string TinhThanhOption { get; set; }
        public string HinhThucOption { get; set; }
        public string MucGiaOption { get; set; }
        public string LoaiOption { get; set; }
    }
}
