using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BatDongSanId.Areas.Client.Models.ListViewModels;
using BatDongSanId.Data;

namespace BatDongSanId.Areas.Client.Models.ViewComponents
{
    public class TimKiemViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;
        public TimKiemViewComponent(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            TimKiemListViewModel listTimKiem = new TimKiemListViewModel();
            listTimKiem.TinhThanhs = await dbContext.TinhThanh.OrderBy(m => m.Ten).ToListAsync();
            listTimKiem.LoaiTinBatDongSans = await dbContext.LoaiTinBatDongSan.OrderBy(m => m.Ten).ToListAsync();
            listTimKiem.MucGias = await dbContext.MucGia.OrderBy(m => m.ID).ToListAsync();
            listTimKiem.LoaiBatDongSans = await dbContext.LoaiBatDongSan.OrderBy(m => m.ID).ToListAsync();
            return View(listTimKiem);
        }
    }
}
