using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ViewModels
{
    public class QuenMKViewModel
    {
        [DisplayName("Tài khoản/ Email")]
        public string TaiKhoan { get; set; }

        [DisplayName("Mật khẩu")]
        public string SoDienThoai { get; set; }

        [DisplayName("Mã xác nhận")]
        public string MaXacNhan { get; set; }

        [DisplayName("Mật khẩu mới")]
        public string MatKhauMoi { get; set; }
    }
}
