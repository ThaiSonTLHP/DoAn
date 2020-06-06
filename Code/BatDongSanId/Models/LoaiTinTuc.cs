using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BatDongSanId.Models
{
    public class LoaiTinTuc
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Tên loại tin tức")]
        public string Ten { get; set; }

        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
    }
}
