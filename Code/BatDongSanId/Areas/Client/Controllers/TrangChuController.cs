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


            TrangChuListViewModel _trangChu = new TrangChuListViewModel();
            var tinThuongViewModels = LayTinBDS(3, "Tin thường");
            var tinHOTViewModels = LayTinBDS(6, "Tin HOT");
            var tinVIPViewModels = LayTinBDS(12, "Tin VIP");
            var nhaMoiGioiViewModels = LayNhaMoiGioi(10);
            var tinTucViewModels = LayTinTuc(6);


            _trangChu.TinThuongViewModels = tinThuongViewModels;
            _trangChu.TinHOTViewModels = tinHOTViewModels;
            _trangChu.TinVIPViewModels = tinVIPViewModels;
            _trangChu.NhaMoiGioiViewModels = nhaMoiGioiViewModels;
            _trangChu.TinTucViewModels = tinTucViewModels;


            //var testKey = configuration["AppSetting:TinBatDongSanTime"];
            return View(_trangChu);
        }

        List<TinBDSViewModel> LayTinBDS(int soLuong, string goiTin)
        {
            var listTinBDS = (from t in _dbContext.TinBatDongSan
                                join lt in _dbContext.LoaiTinBatDongSan on t.LoaiTin equals lt.ID
                                join tk in _dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                                join gt in _dbContext.GoiTin on t.GoiTin equals gt.ID
                                join lbds in _dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                                join tt in _dbContext.TinhThanh on t.TinhThanh equals tt.ID
                                join qh in _dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                                join h in _dbContext.Huong on t.Huong equals h.ID
                                where gt.Ten == goiTin
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
                                    MoTa = t.MoTa
                                }).ToList();
            foreach(TinBDSViewModel tin in listTinBDS)
            {
                tin.HinhAnh = LayHinhAnh(tin.ID, "Tin bất động sản");
            }
            List<TinBDSViewModel> listSoLuongTin = listTinBDS.GetRange(0, soLuong>listTinBDS.Count() ? listTinBDS.Count() : soLuong);
            return listSoLuongTin;
        }

        List<NhaMoiGioiViewModel> LayNhaMoiGioi(int soLuong)
        {
            var listNhaMoiGioi = (from t in _dbContext.TaiKhoan
                                  join ltk in _dbContext.LoaiTaiKhoan on t.LoaiTaiKhoan equals ltk.ID
                                  where ltk.Ten == "Nhà môi giới"
                                  select new NhaMoiGioiViewModel()
                                  {
                                      Ten = t.Ten,
                                      Email = t.Email,
                                      SoDienThoai = t.SoDienThoai,
                                      DiaChi = t.DiaChi
                                  }).ToList();
            return listNhaMoiGioi;
        }

        List<TinTucViewModel> LayTinTuc(int soLuong)
        {
            var listTinTuc = (from t in _dbContext.TinTuc
                              join lt in _dbContext.LoaiTinTuc on t.LoaiTinTuc equals lt.ID
                              join tk in _dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                              select new TinTucViewModel()
                              {
                                  ID = t.ID,
                                  TieuDe = t.TieuDe,
                                  NgayDang = t.NgayDang,
                                  NguoiDang = tk.Ten,
                                  LoaiTinTuc = lt.Ten,
                                  NoiDung = t.NoiDung
                              }).ToList();
            foreach (TinTucViewModel tin in listTinTuc)
            {
                tin.HinhAnh = LayHinhAnh(tin.ID, "Tin tức");
            }
            List<TinTucViewModel> listSoLuongTin = listTinTuc.GetRange(0, soLuong > listTinTuc.Count() ? listTinTuc.Count() : soLuong);
            return listSoLuongTin;
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
