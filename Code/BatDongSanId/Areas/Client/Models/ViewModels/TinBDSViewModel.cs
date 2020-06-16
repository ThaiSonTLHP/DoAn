using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ViewModels
{
    public class TinBDSViewModel
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Loại tin")]
        public string LoaiTin { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày đăng")]
        public DateTime NgayDang { get; set; }

        [Display(Name = "Người đăng")]
        public string NguoiDang { get; set; }

        [Display(Name = "Liên hệ")]
        public string LienHe { get; set; }

        [Display(Name = "Gói tin")]
        public string GoiTin { get; set; }

        [Display(Name = "Loại bất động sản")]
        public string LoaiBatDongSan { get; set; }

        [Display(Name = "Tỉnh thành")]
        public string TinhThanh { get; set; }

        [Display(Name = "Quận huyện")]
        public string QuanHuyen { get; set; }

        [Display(Name = "Giá")]
        public string Gia { get; set; }

        [Display(Name = "Diện tích")]
        public string DienTich { get; set; }

        [Display(Name = "Hướng")]
        public string Huong { get; set; }

        [Display(Name = "Tiêu đề")]
        public string TieuDe { get; set; }

        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }

        public string HinhAnh { get; set; }

        public string XacThuc { get; set; }

        public Boolean PheDuyet { get; set; }

        public int NguoiDangID { get; set; }
    }
}
