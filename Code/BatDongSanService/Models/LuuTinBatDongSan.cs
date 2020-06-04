using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BatDongSanService.Models
{
    public class LuuTinBatDongSan
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Tài khoản")]
        public int TaiKhoan { get; set; }

        [Display(Name = "Tin bất động sản")]
        public int TinBatDongSan { get; set; }
    }
}
