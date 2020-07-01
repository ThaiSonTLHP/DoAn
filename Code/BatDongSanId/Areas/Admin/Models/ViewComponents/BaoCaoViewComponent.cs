using BatDongSanId.Data;
using BatDongSanId.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Admin.Models.ViewComponents
{
    public class BaoCaoViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;

        public BaoCaoViewComponent(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var listTin = await (from b in dbContext.BaoCao
                                 join t in dbContext.TinBatDongSan on b.Tin equals t.ID
                                 where b.DaXem == false
                                 select new BaoCao()
                                 {
                                     ID = b.ID,
                                     Tin = b.Tin,
                                     LyDo = b.LyDo.Substring(0, 40)+"..."
                                 }).OrderBy(b=>b.ID).ToListAsync();
            listTin.Reverse();
            ViewBag.Count = listTin.Count();
            listTin = listTin.GetRange(0 , listTin.Count() < 5 ? listTin.Count() : 5);
            return View(listTin);
        }
    }
}
