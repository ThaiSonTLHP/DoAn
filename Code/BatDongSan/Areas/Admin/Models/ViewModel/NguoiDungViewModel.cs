using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminBatDongSan.Models.ViewModel
{
    public class NguoiDungViewModel
    {
        [Key]
        [Display(Name = "Mã người dùng")]
        public string ID { get; set; }

        [Display(Name = "Tên")]
        public string Ten { get; set; }

        [Display(Name = "Chức vụ")]
        public string ChucVu { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Display(Name = "Số điện thoại")]
        public string SoDienThoai { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Số bài đăng")]
        public int SoBaiDang { get; set; }
    }
}
