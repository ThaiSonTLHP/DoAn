using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ListViewModels
{
    public class TrangChuListViewModel
    {
        public List<TinBDSViewModel> TinVIPViewModels { get; set; }
        public List<TinBDSViewModel> TinHOTViewModels { get; set; }
        public List<TinBDSViewModel> TinThuongViewModels { get; set; }
        public List<NhaMoiGioiViewModel> NhaMoiGioiViewModels { get; set; }
        public List<TinTucViewModel> TinTucViewModels { get; set; }
    }
}
