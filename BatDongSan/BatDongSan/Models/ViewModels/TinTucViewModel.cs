using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BatDongSan.Models.ViewModels
{
    public class TinTucViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tiêu đề")]
        public string TieuDe { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày đăng")]
        public DateTime NgayDang { get; set; }

        [Display(Name = "Người đăng")]
        public string NguoiQuanTri { get; set; }

        [Display(Name = "Thể loại")]
        public string LoaiTinTuc { get; set; }

        [Display(Name = "Nội dung")]
        public string NoiDung { get; set; }
    }
}
