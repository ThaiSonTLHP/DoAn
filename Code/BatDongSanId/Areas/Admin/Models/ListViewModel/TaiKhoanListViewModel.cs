using BatDongSanId.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Admin.Models.ListViewModel
{
    public class TaiKhoanListViewModel
    {
        public List<TaiKhoan> TaiKhoans { get; set; }
        public List<LoaiTaiKhoan> LoaiTaiKhoans { get; set; }
    }
}
