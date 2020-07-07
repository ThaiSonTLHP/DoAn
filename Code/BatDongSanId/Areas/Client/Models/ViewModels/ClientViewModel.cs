
using BatDongSanId.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ViewModels
{
    public class ClientViewModel
    {
        public CauHinh Logo { get; set; }

        public List<SlideViewModel> Slide { get; set; }

        public CauHinh TrangChu { get; set; }

        public CauHinh TinBan { get; set; }

        public CauHinh ChoThue { get; set; }

        public CauHinh TinMua { get; set; }

        public CauHinh TinThue { get; set; }

        public CauHinh NhaMoiGioi { get; set; }

        public CauHinh TinTuc { get; set; }

        public CauHinh LienHe { get; set; }

        public CauHinh DangTin { get; set; }
    }
}
