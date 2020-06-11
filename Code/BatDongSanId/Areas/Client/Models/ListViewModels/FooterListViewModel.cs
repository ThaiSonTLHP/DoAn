using BatDongSanId.Areas.Client.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ListViewModels
{
    public class FooterListViewModel
    {
        public List<TinBDSViewModel> TinBDSViewModel { get; set; }
        public GioiThieuViewModel GioiThieuViewModel { get; set; }
    }
}
