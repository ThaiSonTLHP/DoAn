using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanService.Models
{
    public class GoiTin
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Tên gói tin")]
        public string Ten { get; set; }

        [Display(Name = "Giá")]
        public double MucPhi { get; set; }
    }
}
