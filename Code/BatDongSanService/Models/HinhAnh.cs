using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BatDongSanService.Models
{
    public class HinhAnh
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Tên")]
        public string Ten { get; set; }

        [Display(Name = "Ảnh")]
        public byte[] Anh { get; set; }

        [Display(Name = "Là ảnh chính?")]
        public Boolean AnhChinh { get; set; }

        [Display(Name = "Id tin bất động sản")]
        public Nullable<int> TinBatDongSan { get; set; }

        [Display(Name = "Id tin tức")]
        public Nullable<int> TinTuc { get; set; }

        //[NotMapped]
        //[Display(Name = "Tải file")]
        //public IFormFile FileAnh { get; set; }
    }
}
