using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ViewModels
{
    public class GioiThieuViewModel
    {
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string GioiThieu { get; set; }
        private readonly IConfiguration configuration;

        public GioiThieuViewModel(IConfiguration _configuration)
        {
            configuration = _configuration;
            DiaChi = configuration["AppSetting:DiaChi"];
            Email = configuration["AppSetting:Email"];
            SoDienThoai = configuration["AppSetting:SoDienThoai"];
            GioiThieu = configuration["AppSetting:GioiThieu"];
        }
    }
}
