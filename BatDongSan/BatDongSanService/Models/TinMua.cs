using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanService.Models
{
    public class TinMua
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày đăng")]
        public DateTime NgayDang { get; set; }

        [Display(Name = "Trạng thái")]
        public Boolean TrangThai { get; set; }

        [Display(Name = "Người mua")]
        public string NguoiMuaId { get; set; }

        [Display(Name = "Hình thức giao dịch")]
        public int HinhThucGiaoDichId { get; set; }

        [Display(Name = "Loại bất động sản")]
        public int LoaiBatDongSanId { get; set; }

        [Display(Name = "Tỉnh thành")]
        public int TinhThanhId { get; set; }

        [Display(Name = "Quận huyện")]
        public int QuanHuyenId { get; set; }

        [Display(Name = "Hướng")]
        public int HuongId { get; set; }

        [Display(Name = "Diện tích")]
        public double DienTich { get; set; }

        [Display(Name = "Giá")]
        public double Gia { get; set; }

        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
    }
}
