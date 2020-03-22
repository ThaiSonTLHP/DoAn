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
        public int Id { get; set; }

        [Display(Name = "Tỉnh thành")]
        public string Ten { get; set; }
    }
}
