using BatDongSanId.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ListViewModels
{
    public class QLTKListViewModel
    {
        public TaiKhoanViewModel taiKhoanViewModel { get; set; }
        public int soTinDang { get; set; }
        public int soTinLuu { get; set; }
    }
}
