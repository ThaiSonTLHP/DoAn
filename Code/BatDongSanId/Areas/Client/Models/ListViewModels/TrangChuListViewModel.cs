using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace BatDongSanId.Areas.Client.Models.ListViewModels
{
    public class TrangChuListViewModel
    {
        public List<TinBDSViewModel> TinVIPViewModels { get; set; }
        public List<TinBDSViewModel> TinHOTViewModels { get; set; }
        public List<TinBDSViewModel> TinThuongViewModels { get; set; }
        public List<TinBDSViewModel> TinBanViewModels { get; set; }
        public List<TinBDSViewModel> ChoThueViewModels { get; set; }
        public List<TinBDSViewModel> TinMuaViewModels { get; set; }
        public List<TinBDSViewModel> TinThueViewModels { get; set; }
        public List<TinBDSViewModel> TinTinhThanhViewModels { get; set; }


        public IPagedList<TinBDSViewModel> TinPagedList { get; set; }
        public IPagedList<TinBDSViewModel> TinVIPPagedList { get; set; }
        public IPagedList<TinBDSViewModel> TinThuongPagedList { get; set; }
        public IPagedList<TinBDSViewModel> TinTinhThanhPagedList { get; set; }
        public string TinhThanh { get; set; }

        public IPagedList<TinBDSViewModel> GiaGiam { get; set; }
        public IPagedList<TinBDSViewModel> GiaTang { get; set; }
        public IPagedList<TinBDSViewModel> DienTichGiam { get; set; }
        public IPagedList<TinBDSViewModel> DienTichTang { get; set; }


        public List<TaiKhoanViewModel> TaiKhoanViewModels { get; set; }
        public List<TinTucViewModel> TinTucViewModels { get; set; }
        public List<TinBDSTinhThanhViewModel> TinBDSTinhThanhViewModels { get; set; }
    }
}
