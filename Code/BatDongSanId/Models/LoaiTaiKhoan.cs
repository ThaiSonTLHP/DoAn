using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Models
{
    public class LoaiTaiKhoan
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Tên tài khoản")]
        public string Ten { get; set; }

        [Display(Name = "Chức năng")]
        public string ChucNang { get; set; }
    }
}
