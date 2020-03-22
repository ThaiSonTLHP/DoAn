﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSan.Models.ViewModels
{
    public class TinThueViewModel
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày đăng")]
        public DateTime NgayDang { get; set; }

        [Display(Name = "Liên hệ")]
        public string LienHe { get; set; }

        [Display(Name = "Loại bất động sản")]
        public string LoaiBatDongSan { get; set; }

        [Display(Name = "Tỉnh thành")]
        public string TinhThanh { get; set; }

        [Display(Name = "Quận huyện")]
        public string QuanHuyen { get; set; }

        [Display(Name = "Giá")]
        public double Gia { get; set; }

        [Display(Name = "Diện tích")]
        public double DienTich { get; set; }

        [Display(Name = "Hướng")]
        public string Huong { get; set; }

        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
    }
}