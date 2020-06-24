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
            var tinThuongViewModels = layDuLieu.LayTinBDS(2, "Tin thường", "All");
            var tinHOTViewModels = layDuLieu.LayTinBDS(6, "Tin HOT", "All");
            var tinVIPViewModels = layDuLieu.LayTinBDS(int.Parse(configuration["AppSetting:TinVIPCount"]), "Tin VIP", "All");
            var nhaMoiGioiViewModels = layDuLieu.LayTaiKhoan(10, "Nhà môi giới");
            var tinTucViewModels = layDuLieu.LayTinTuc(6);


            _trangChu.TinThuongViewModels = tinThuongViewModels;
            _trangChu.TinHOTViewModels = tinHOTViewModels;
            _trangChu.TinVIPViewModels = tinVIPViewModels;
            _trangChu.TaiKhoanViewModels = nhaMoiGioiViewModels;
            _trangChu.TinTucViewModels = tinTucViewModels;


            //var testKey = configuration["AppSetting:TinBatDongSanTime"];
            return View(_trangChu);
        }
    }
}
