using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ViewModels
{
    public class DangNhapViewModel
    {
        [DisplayName("Tài khoản")]
        public string TaiKhoan { get; set; }

        [DisplayName("Mật khẩu")]
        public string MatKhau { get; set; }
    }
}
