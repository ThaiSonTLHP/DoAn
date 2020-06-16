using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.ViewModels
{
    public class TaiKhoanViewModel
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }

        [Display(Name = "Tên người dùng")]
        public string Ten { get; set; }

        [Display(Name = "Giới tính")]
        public string GioiTinh { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        public string SoDienThoai { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Display(Name = "Số dư ví")]
        public double SoDuVi { get; set; }

        [Display(Name = "Loại tài khoản")]
        public string LoaiTaiKhoan { get; set; }

        public byte[] AnhDaiDienData { get; set; }

        public string AnhDaiDienUrl { get; set; }
    }
}
