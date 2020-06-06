using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BatDongSanId.Models
{
    public class TaiKhoan
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }

        [Display(Name = "Tên người dùng")]
        public string Ten { get; set; }

        [Display(Name = "Giới tính")]
        public Boolean GioiTinh { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        public string SoDienThoai { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Display(Name = "Loại tài khoản")]
        public int LoaiTaiKhoan { get; set; }

        [Display(Name = "Số dư ví")]
        public double SoDuVi { get; set; }

        [Display(Name = "Trạng thái xác thực")]
        public Boolean XacThuc { get; set; }

        public byte[] AnhDaiDien { get; set; }
    }
}
