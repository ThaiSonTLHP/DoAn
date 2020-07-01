using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Admin.Models.ViewModel
{
    public class BaoCaoViewModel
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Tin bất động sản")]
        public string Tin { get; set; }

        [Display(Name = "Người đăng")]
        public string NguoiDang { get; set; }

        [Display(Name = "Người gửi")]
        public string NguoiGui { get; set; }

        [Display(Name = "Lý do")]
        public string LyDo { get; set; }

        public string DaXem { get; set; }
    }
}
