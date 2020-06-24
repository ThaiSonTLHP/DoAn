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

        //public TimKiemListViewModel()
        //{
        //    XacThucs = new List<XacThuc>() {
        //        new XacThuc() { ID = true , Ten = "Đã xác thực" },
        //        new XacThuc() { ID = false , Ten = "Chưa xác thực" } };
        //    //var XacThucs = new List<XacThuc>();
        //    //XacThucs.Add(new XacThuc() { ID = true})
        //    ThoiGians = new List<ThoiGian>() {
        //        new ThoiGian() { ID = 1, Ten = "24 giờ qua" },
        //        new ThoiGian() { ID = 7, Ten ="Tuần qua" },
        //        new ThoiGian() { ID = 30, Ten ="Tháng qua" } };
        //}
    }

    public class XacThuc
    {
        public Boolean ID;
        public string Ten;

        public XacThuc(Boolean ID, string Ten)
        {
            this.ID = ID;
            this.Ten = Ten;
        }
    }

    public class ThoiGian
    {
        public int ID;
        public string Ten;

        public ThoiGian(int ID, string Ten)
        {
            this.ID = ID;
            this.Ten = Ten;
        }
    }
}
