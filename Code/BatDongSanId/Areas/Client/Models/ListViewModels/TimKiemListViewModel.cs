using BatDongSanId.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ListViewModels
{
    public class TimKiemListViewModel
    {
        public List<TinhThanh> TinhThanhs { get; set; }
        public List<QuanHuyen> QuanHuyens { get; set; }
        public List<LoaiTinBatDongSan> LoaiTinBatDongSans { get; set; }
        public List<MucGia> MucGias { get; set; }
        public List<LoaiBatDongSan> LoaiBatDongSans { get; set; }
        public List<Huong> Huongs { get; set; }
        public List<MucDienTich> MucDienTiches { get; set; }
        public List<XacThuc> XacThucs { get; set; }
        public List<ThoiGian> ThoiGians { get; set; }
    }

    public class XacThuc
    {
        public Boolean value;
        public string text;
    }

    public class ThoiGian
    {
        public int value;
        public string text;
    }
}
