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
        private readonly ApplicationDbContext db;
        public TimKiemViewComponent(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            TimKiemListViewModel listTimKiem = new TimKiemListViewModel();
            listTimKiem.TinhThanhs = await db.TinhThanh.OrderBy(m => m.Ten).ToListAsync();
            listTimKiem.LoaiTinBatDongSans = await db.LoaiTinBatDongSan.OrderBy(m => m.Ten).ToListAsync();
            listTimKiem.MucGias = await db.MucGia.OrderBy(m => m.ID).ToListAsync();
            listTimKiem.LoaiBatDongSans = await db.LoaiBatDongSan.OrderBy(m => m.ID).ToListAsync();
            return View(listTimKiem);
        }
    }
}
