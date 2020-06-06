using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Models
{
    public class LoaiBatDongSan
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Loại bất động sản")]
        public string Ten { get; set; }
    }
}
