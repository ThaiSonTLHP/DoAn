using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanService.Models
{
    public class MucGia
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Mức giá")]
        public string Ten { get; set; }

        [Display(Name = "Giá thấp nhất")]
        public double Min { get; set; }

        [Display(Name = "Giá cao nhất")]
        public double Max { get; set; }
    }
}
