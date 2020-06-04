using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanService.Models;

namespace BatDongSanId.Areas.Client.Models.ListViewModels
{
    public class TimKiemListViewModel
    {
        public List<TinhThanh> TinhThanhs { get; set; }
        public List<LoaiTinBatDongSan> LoaiTinBatDongSans { get; set; }
        public List<MucGia> MucGias { get; set; }
        public List<LoaiBatDongSan> LoaiBatDongSans { get; set; }
    }
}
