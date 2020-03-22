using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanService.Models
{
    public class LoaiTinRao
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Loại tin rao")]
        public string Ten { get; set; }

        [Display(Name = "Giá")]
        public float MucPhi { get; set; }
    }
}
