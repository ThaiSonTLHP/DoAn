using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BatDongSanService.Models
{
    public class DienTich
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Diện tích")]
        public string Ten { get; set; }

        [Display(Name = "Diện tích min")]
        public float DienTichThapNhat { get; set; }

        [Display(Name = "Diện tích max")]
        public float DienTichCaoNhat { get; set; }
    }
}
