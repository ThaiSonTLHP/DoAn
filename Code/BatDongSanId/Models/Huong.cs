using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Models
{
    public class Huong
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Hướng")]
        public string Ten { get; set; }
    }
}
