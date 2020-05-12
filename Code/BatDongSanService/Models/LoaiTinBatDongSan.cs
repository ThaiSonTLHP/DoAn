using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BatDongSanService.Models
{
    public class LoaiTinBatDongSan
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Loại tin")]
        public string Ten { get; set; }
    }
}
