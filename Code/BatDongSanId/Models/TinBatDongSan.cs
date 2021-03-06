﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Models
{
    public class TinBatDongSan
    {
        [Key]
        public int ID { get; set; }

        [Range(1, 4)]
        [Display(Name = "Loại tin")]
        public int LoaiTin { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Ngày đăng")]
        public DateTime NgayDang { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Ngày lên bảng tin")]
        public DateTime NgayLenBangTin { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Ngày xác nhận giao dịch")]
        public DateTime NgayXacNhan { get; set; }

        [Display(Name = "Trạng thái giao dịch")]
        public Boolean TrangThaiGiaoDich { get; set; }

        [Display(Name = "Trạng thái duyệt")]
        public Boolean TrangThaiDuyet { get; set; }

        [Display(Name = "Trạng thái xác nhận")]
        public Boolean TrangThaiXacNhan { get; set; }

        [Display(Name = "Người đăng")]
        public int NguoiDang { get; set; }

        [Display(Name = "Gói tin")]
        public int GoiTin { get; set; }

        [Display(Name = "Loại bất động sản")]
        public int LoaiBatDongSan { get; set; }

        [Display(Name = "Tỉnh thành")]
        public string TinhThanh { get; set; }

        [Display(Name = "Quận huyện")]
        public string QuanHuyen { get; set; }

        [Display(Name = "Giá")]
        public string Gia { get; set; }

        [Display(Name = "Mức giá")]
        public int MucGia { get; set; }

        [Display(Name = "Diện tích")]
        public string DienTich { get; set; }

        [Display(Name = "Mức diện tích")]
        public int MucDienTich { get; set; }

        [Display(Name = "Hướng")]
        public int Huong { get; set; }

        [Display(Name = "Tiêu đề")]
        public string TieuDe { get; set; }

        [Display(Name = "Mô tả")]
        [Required]
        public string MoTa { get; set; }

        [Display(Name = "Gói tin trước hết hạn")]
        public int HetHan { get; set; }

        [Display(Name = "Lượt xem")]
        public int LuotXem { get; set; }
    }
}
