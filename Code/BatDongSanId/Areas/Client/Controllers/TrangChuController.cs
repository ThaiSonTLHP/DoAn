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
        public IActionResult Index(/*int? size = 3, int? page*/int sapXepVip = 0)
        {
            //if (page == null) page = 1;
            //// 4.1 Toán tử ?? trong C# mô tả nếu page khác null thì lấy giá trị page, còn
            //// nếu page = null thì lấy giá trị 1 cho biến pageNumber.
            //int pageNumber = (page ?? 1);

            LayDuLieu layDuLieu = new LayDuLieu(_dbContext, configuration);
            //layDuLieu.CapNhatTinVip();
            //layDuLieu.CapNhatTinHot();
            TrangChuListViewModel _trangChu = new TrangChuListViewModel();

            var tinVip = layDuLieu.LayTinBDS(12, "Tin VIP", "All");
            if(sapXepVip != 0)
            {
                if (sapXepVip == 1)
                {
                    tinVip = tinVip.OrderBy(t => t.GiaGoc).ToList();
                }
                if (sapXepVip == 2)
                {
                    tinVip = tinVip.OrderByDescending(t => t.GiaGoc).ToList();
                }
                if (sapXepVip == 3)
                {
                    tinVip = tinVip.OrderBy(t => t.DienTichGoc).ToList();
                }
                if (sapXepVip == 4)
                {
                    tinVip = tinVip.OrderByDescending(t => t.DienTichGoc).ToList();
                }
            }

            _trangChu.TinThuongViewModels = layDuLieu.LayTinBDS(6, "Tin thường", "All"); ;
            _trangChu.TinHOTViewModels = layDuLieu.LayTinBDS(8, "Tin HOT", "All");
            _trangChu.TinVIPViewModels = tinVip;
            _trangChu.TaiKhoanViewModels = layDuLieu.LayTaiKhoan(10, "Nhà môi giới");
            _trangChu.TinTucViewModels = layDuLieu.LayTinTuc(6);
            _trangChu.TinBDSTinhThanhViewModels = layDuLieu.TongTinBDSByTinhThanh();

            //var testKey = configuration["AppSetting:TinBatDongSanTime"];
            return View(_trangChu);
        }
    }
}
