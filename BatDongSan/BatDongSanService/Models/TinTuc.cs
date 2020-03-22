using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BatDongSanService.Models
{
    public class TinTuc
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tiêu đề")]
        public string TieuDe { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày đăng")]
        public DateTime Ngaydang { get; set; }

        [Display(Name = "Người đăng")]
        public string QuanTriId { get; set; }

        [Display(Name = "Nội dung")]
        public string NoiDung { get; set; }

        [Display(Name = "Loại tin")]
        public int LoaiTinTucID { get; set; }

    }
}
