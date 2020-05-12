using BatDongSanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminBatDongSan.Models.ListViewModel
{
    public class TaiKhoanListViewModel
    {
        public List<TaiKhoan> TaiKhoans { get; set; }
        public List<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
    }
}
