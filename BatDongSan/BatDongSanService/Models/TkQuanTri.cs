using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BatDongSanService.Models
{
    public class TkQuanTri
    {
        [Key]
        [Display(Name = "Tên tài khoản")]
        public string Id { get; set; }

        [Display(Name = "Tiêu đề")]
        public string MatKhau { get; set; }

        [Display(Name = "Tên nhân viên")]
        public string TenNhanVien { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Display(Name = "Số điện thoại")]
        public string SoDienThoai { get; set; }
    }
}
