using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanService.Models
{
    public class MucGia
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Mức giá")]
        public string Ten { get; set; }

        [Display(Name = "Giá thấp nhất")]
        public double GiaThapNhat { get; set; }

        [Display(Name = "Giá cao nhất")]
        public double GiaCaoNhat { get; set; }

        [Display(Name = "Loại giá")]
        public string LoaiGia { get; set; }

        [Display(Name = "Đơn vị tính")]
        public string DonViTinh { get; set; }
    }
}
