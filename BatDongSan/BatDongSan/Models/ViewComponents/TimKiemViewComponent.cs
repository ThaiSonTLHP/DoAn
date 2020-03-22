using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanService;
using Microsoft.EntityFrameworkCore;
using BatDongSan.Models.ListViewModels;

namespace BatDongSan.Models.ViewComponents
{
    public class TimKiemViewComponent : ViewComponent
    {
        private readonly BatDongSanContext db;
        public TimKiemViewComponent(BatDongSanContext db)
        {
            this.db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            TimKiemListViewModel listTimKiem = new TimKiemListViewModel();
            listTimKiem.TinhThanhs = await db.TinhThanh.OrderBy(m => m.Ten).ToListAsync();
            listTimKiem.HinhThucGiaoDiches = await db.HinhThucGiaoDich.OrderBy(m => m.Ten).ToListAsync();
            listTimKiem.MucGias = await db.MucGia.OrderBy(m => m.Ten).ToListAsync();
            listTimKiem.LoaiBatDongSans = await db.LoaiBatDongSan.OrderBy(m => m.Ten).ToListAsync();
            return View(listTimKiem);
        }
    }
}
