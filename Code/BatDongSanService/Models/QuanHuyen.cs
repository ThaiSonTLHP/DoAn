using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanService.Models
{
    public class QuanHuyen
    {
        [Key]
        public string ID { get; set; }

        [Display(Name = "Quận huyện")]
        public string Ten { get; set; }

        [Display(Name = "Loại")]
        public string Loai { get; set; }

        [Display(Name = "Tỉnh thành")]
        public string TinhThanh { get; set; }
    }
}
