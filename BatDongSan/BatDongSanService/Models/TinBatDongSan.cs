using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanService.Models
{
    public class TinBatDongSan
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Loại tin")]
        public int LoaiTin { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày đăng")]
        public DateTime NgayDang { get; set; }

        [Display(Name = "Trạng thái giao dịch")]
        public Boolean TrangThaiGiaoDich { get; set; }

        [Display(Name = "Trạng thái xác nhận")]
        public Boolean TrangThaiXacNhan { get; set; }

        [Display(Name = "Người đăng")]
        public string NguoiDang { get; set; }

        [Display(Name = "Gói tin")]
        public int GoiTin { get; set; }

        [Display(Name = "Loại bất động sản")]
        public int LoaiBatDongSan { get; set; }

        [Display(Name = "Tỉnh thành")]
        public int TinhThanh { get; set; }

        [Display(Name = "Quận huyện")]
        public int QuanHuyen { get; set; }

        [Display(Name = "Giá")]
        public string Gia { get; set; }

        [Display(Name = "Mức giá")]
        public int MucGia { get; set; }

        [Display(Name = "Diện tích")]
        public double DienTich { get; set; }

        [Display(Name = "Mức diện tích")]
        public int MucDienTich { get; set; }

        [Display(Name = "Hướng")]
        public int Huong { get; set; }

        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
    }
}
