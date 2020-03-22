using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BatDongSanService.Models
{
    public class HinhThucGiaoDich
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Hình thức giao dịch")]
        public string Ten { get; set; }
    }
}
