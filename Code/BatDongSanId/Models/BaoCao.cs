using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Models
{
    public class BaoCao
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Tin bất động sản")]
        public int Tin { get; set; }

        [Display(Name = "Người gửi")]
        public int NguoiGui { get; set; }

        [Display(Name = "Lý do")]
        public string LyDo { get; set; }

        public Boolean DaXem { get; set; }
    }
}
