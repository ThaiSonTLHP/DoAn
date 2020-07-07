using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Models
{
    public class CauHinh
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Tên")]
        public string Ten { get; set; }

        [Display(Name = "Dữ liệu string")]
        public string DuLieuString { get; set; }

        [Display(Name = "Ảnh")]
        public byte[] Anh { get; set; }

        [Display(Name = "Trạng thái hiển thị")]
        public Boolean TrangThai { get; set; }
    }
}
