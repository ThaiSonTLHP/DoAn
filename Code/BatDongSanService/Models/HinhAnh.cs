using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BatDongSanService.Models
{
    public class HinhAnh
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Ảnh")]
        public byte[] Anh { get; set; }

        [Display(Name = "Là ảnh chính?")]
        public Boolean AnhChinh { get; set; }

        [Display(Name = "Id tin bất động sản")]
        public int TinBatDongSan { get; set; }
    }
}
