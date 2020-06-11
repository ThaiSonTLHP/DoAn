using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BatDongSan.Models;
using BatDongSanId.Data;
using BatDongSanId.Areas.Client.Models.ListViewModels;
using BatDongSanId.Areas.Client.Models.ViewModels;
using Microsoft.Extensions.Configuration;
using System.Security.Principal;
using BatDongSanId.Models;
using BatDongSanId.Methods;

namespace BatDongSanId.Areas.Client.Controllers
{
    [Area("Client")]
    public class TrangChuController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IConfiguration configuration;

        public TrangChuController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            this.configuration = configuration;
        }
        public IActionResult Index(/*int? size = 3, int? page*/)
        {
            //if (page == null) page = 1;
            //// 4.1 Toán tử ?? trong C# mô tả nếu page khác null thì lấy giá trị page, còn
            //// nếu page = null thì lấy giá trị 1 cho biến pageNumber.
            //int pageNumber = (page ?? 1);

            LayDuLieu layDuLieu = new LayDuLieu(_dbContext, configuration);
            TrangChuListViewModel _trangChu = new TrangChuListViewModel();
            var tinThuongViewModels = layDuLieu.LayTinBDS(3, "Tin thường", "All");
            var tinHOTViewModels = layDuLieu.LayTinBDS(6, "Tin HOT", "All");
            var tinVIPViewModels = layDuLieu.LayTinBDS(12, "Tin VIP", "All");
            var nhaMoiGioiViewModels = layDuLieu.LayNhaMoiGioi(10);
            var tinTucViewModels = layDuLieu.LayTinTuc(6);


            _trangChu.TinThuongViewModels = tinThuongViewModels;
            _trangChu.TinHOTViewModels = tinHOTViewModels;
            _trangChu.TinVIPViewModels = tinVIPViewModels;
            _trangChu.NhaMoiGioiViewModels = nhaMoiGioiViewModels;
            _trangChu.TinTucViewModels = tinTucViewModels;


            //var testKey = configuration["AppSetting:TinBatDongSanTime"];
            return View(_trangChu);
        }

        string LayHinhAnh(int id, string loaiTin)
        {
            var hinhAnh = new HinhAnh();
            if (loaiTin == "Tin bất động sản")
            {
                hinhAnh = (from ha in _dbContext.HinhAnh
                               where ha.TinBatDongSan == id
                               && ha.AnhChinh == true
                               select new HinhAnh
                               {
                                   ID = ha.ID,
                                   Ten = ha.Ten,
                                   Anh = ha.Anh,
                                   AnhChinh = ha.AnhChinh
                               }).FirstOrDefault();
            }
            else if(loaiTin == "Tin tức")
            {
                hinhAnh = (from ha in _dbContext.HinhAnh
                               where ha.TinTuc == id
                               && ha.AnhChinh == true
                               select new HinhAnh
                               {
                                   ID = ha.ID,
                                   Ten = ha.Ten,
                                   Anh = ha.Anh,
                                   AnhChinh = ha.AnhChinh
                               }).FirstOrDefault();
            }
            string anhDataURL;
            if (hinhAnh != null)
            {
                string anhBase64Data = Convert.ToBase64String(hinhAnh.Anh);
                anhDataURL = string.Format("data:image/jpg;base64,{0}", anhBase64Data);
            }
            else
            {
                anhDataURL = "~/Client/img/rooms/1.jpg";
            }
            return anhDataURL;
        }
    }
}
