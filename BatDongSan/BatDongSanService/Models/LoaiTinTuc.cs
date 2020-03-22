using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BatDongSanService.Models
{
    public class LoaiTinTuc
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên loại tin tức")]
        public string Ten { get; set; }
    }
}
