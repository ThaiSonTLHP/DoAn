using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanService.Models
{
    public class TinhThanh
    {
        [Key]
        public string ID { get; set; }

        [Display(Name = "Tỉnh thành")]
        public string Ten { get; set; }

        [Display(Name = "Loại")]
        public string Loai { get; set; }
    }
}
