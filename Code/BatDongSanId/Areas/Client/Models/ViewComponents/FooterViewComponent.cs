using BatDongSanId.Areas.Client.Models.ListViewModels;
using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Data;
using BatDongSanId.Methods;
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
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;

        public FooterViewComponent(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            FooterListViewModel footer = new FooterListViewModel();
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTin = await (from t in dbContext.TinBatDongSan
                                            join lt in dbContext.LoaiTinBatDongSan on t.LoaiTin equals lt.ID
                                            join tk in dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                                            join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                                            join lbds in dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                                            join tt in dbContext.TinhThanh on t.TinhThanh equals tt.ID
                                            join qh in dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                                            join h in dbContext.Huong on t.Huong equals h.ID
                                            //where gt.Ten == "Tin VIP"
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
                                                TieuDe = t.MoTa.Substring(0, 80) + "...",
                                                MoTa = t.MoTa
                                            }).OrderBy(m => m.NgayDang).ToListAsync();
            if (listTin.Count() > 2)
            {
                listTin.Reverse();
                footer.TinBDSViewModel = listTin.GetRange(0, 2);
                foreach (var tin in listTin)
                {
                    tin.HinhAnh = layDuLieu.LayHinhAnh(tin.ID, "Tin bất động sản");
                }
            }
            return View(footer);
        }
    }
}
