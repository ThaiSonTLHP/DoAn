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
        public int Id { get; set; }

        [Display(Name = "Quận huyện")]
        public string Ten { get; set; }

        [Display(Name = "Tỉnh thành")]
        public int TinhThanh { get; set; }
    }
}
