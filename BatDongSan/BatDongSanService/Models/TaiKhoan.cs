using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BatDongSanService.Models
{
    public class TaiKhoan
    {
        [Key]
        [Display(Name = "Tên tài khoản")]
        public string ID { get; set; }

        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }

        [Display(Name = "Người dùng")]
        public string NguoiDung { get; set; }

        [Display(Name = "Loại tài khoản")]
        public int LoaiTaiKhoan { get; set; }
    }
}
