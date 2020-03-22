using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanService.Models
{
    public class TkNhaMoiGioi
    {
        [Key]
        public string Id { get; set; }

        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }

        [Display(Name = "Tên nhà môi giới")]
        public string TenNhaMoiGioi { get; set; }

        [Display(Name = "Số giao dịch")]
        public int SoGiaoDich { get; set; }

        [Display(Name = "Đánh giá")]
        public float DanhGia { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Display(Name = "Số điện thoại")]
        public string SoDienThoai { get; set; }
    }
}
