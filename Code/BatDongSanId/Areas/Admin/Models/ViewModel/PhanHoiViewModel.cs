using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Models;
using BatDongSanId.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Admin.Models.ViewModel
{
    public class PhanHoiViewModel
    {
        public TinBDSViewModel tinBDSViewModel { get; set; }
        public TaiKhoanViewModel taiKhoanViewModel { get; set; }
        public TaiKhoanViewModel taiKhoanBaoCao { get; set; }
        public BaoCao phanHoi { get; set; }
        public List<string> hinhAnhs { get; set; }
    }
}
