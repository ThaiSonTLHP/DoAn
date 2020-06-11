using BatDongSanId.Areas.Client.Models.ListViewModels;
using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Areas.Client.Models.ViewComponents
{
    public class FooterViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext db;
        private readonly IConfiguration configuration;

        public FooterViewComponent(ApplicationDbContext db, IConfiguration configuration)
        {
            this.db = db;
            this.configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            FooterListViewModel footer = new FooterListViewModel();
            var listTin = await (from t in db.TinBatDongSan
                                            join lt in db.LoaiTinBatDongSan on t.LoaiTin equals lt.ID
                                            join tk in db.TaiKhoan on t.NguoiDang equals tk.ID
                                            join gt in db.GoiTin on t.GoiTin equals gt.ID
                                            join lbds in db.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                                            join tt in db.TinhThanh on t.TinhThanh equals tt.ID
                                            join qh in db.QuanHuyen on t.QuanHuyen equals qh.ID
                                            join h in db.Huong on t.Huong equals h.ID
                                            where gt.Ten == "Tin VIP"
                                            select new TinBDSViewModel()
                                            {
                                                ID = t.ID,
                                                LienHe = tk.SoDienThoai,
                                                NgayDang = t.NgayDang,
                                                LoaiTin = lt.Ten,
                                                NguoiDang = tk.Ten,
                                                LoaiBatDongSan = lbds.Ten,
                                                TinhThanh = tt.Ten,
                                                QuanHuyen = qh.Ten,
                                                Huong = h.Ten,
                                                DienTich = t.DienTich,
                                                Gia = t.Gia,
                                                XacThuc = t.TrangThaiXacNhan == true ? "Xác thực" : "Chưa xác thực",
                                                MoTa = t.MoTa
                                            }).OrderBy(m => m.NgayDang).ToListAsync();
            footer.TinBDSViewModel = listTin.GetRange(0, 2);

            return View(footer);
        }
    }
}
