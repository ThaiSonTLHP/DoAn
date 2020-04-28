using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BatDongSanService.Models
{
    public class MucDienTich
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Mức diện tích")]
        public string Ten { get; set; }

        [Display(Name = "Diện tích nhỏ nhất")]
        public double Min { get; set; }

        [Display(Name = "Diện tích cao nhất")]
        public double Max { get; set; }
    }
}
