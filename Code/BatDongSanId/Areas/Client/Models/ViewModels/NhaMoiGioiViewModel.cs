using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ViewModels
{
    public class NhaMoiGioiViewModel
    {
        [Key]
        public string ID { get; set; }

        [Display(Name = "Tên nhà môi giới")]
        public string Ten { get; set; }

        [Display(Name = "Số bài đăng")]
        public int SoBaiDang { get; set; }

        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Số điện thoại")]
        public string SoDienThoai { get; set; }

        public string ChucVu { get; set; }
    }
}
