using BatDongSanId.Areas.Client.Models.ListViewModels;
using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Data;
using BatDongSanId.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatDongSanId.Methods
{
    public class LayDuLieu
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;
        public LayDuLieu(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }

        public List<TinBDSViewModel> LayTinBDS(int soLuong, string goiTin, string loaiTinBDS)
        {
            List<TinBDSViewModel> listTinBDS = new List<TinBDSViewModel>();
            if (goiTin != "All" && loaiTinBDS == "All")
            {
                listTinBDS = (from t in dbContext.TinBatDongSan
                            join lt in dbContext.LoaiTinBatDongSan on t.LoaiTin equals lt.ID
                            join tk in dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                            join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                            join lbds in dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                            join tt in dbContext.TinhThanh on t.TinhThanh equals tt.ID
                            join qh in dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                            join h in dbContext.Huong on t.Huong equals h.ID
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
                                XacThuc = t.TrangThaiXacNhan == true ? "Xác thực" : "Chưa xác thực",
                                MoTa = t.MoTa
                            }).ToList();
            }
            else if(goiTin == "All" && loaiTinBDS != "All")
            {
                listTinBDS = (from t in dbContext.TinBatDongSan
                              join lt in dbContext.LoaiTinBatDongSan on t.LoaiTin equals lt.ID
                              join tk in dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                              join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                              join lbds in dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                              join tt in dbContext.TinhThanh on t.TinhThanh equals tt.ID
                              join qh in dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                              join h in dbContext.Huong on t.Huong equals h.ID
                              where lt.Ten == loaiTinBDS
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
                              }).ToList();
            }
            foreach (TinBDSViewModel tin in listTinBDS)
            {
                tin.Gia = GiaTien(tin.Gia);
                tin.HinhAnh = LayHinhAnh(tin.ID, "Tin bất động sản");
            }
            List<TinBDSViewModel> listSoLuongTin = new List<TinBDSViewModel>();
            if (soLuong != 0)
            {
                listSoLuongTin = listTinBDS.GetRange(0, soLuong > listTinBDS.Count() ? listTinBDS.Count() : soLuong);
            }
            else
            {
                listSoLuongTin = listTinBDS;
            }
            return listSoLuongTin;
        }

        //flag = 1: tin dang; flag = 2: tin luu
        public List<TinBDSViewModel> LayTinBDS(int? nguoiDang, int flag)
        {
            List<TinBDSViewModel> listTinBDS = new List<TinBDSViewModel>();
            if(flag == 1)
            {
                listTinBDS = (from t in dbContext.TinBatDongSan
                              join lt in dbContext.LoaiTinBatDongSan on t.LoaiTin equals lt.ID
                              join tk in dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                              join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                              join lbds in dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                              join tt in dbContext.TinhThanh on t.TinhThanh equals tt.ID
                              join qh in dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                              join h in dbContext.Huong on t.Huong equals h.ID
                              where t.NguoiDang == nguoiDang
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
                              }).ToList();
            }
            else if(flag == 2)
            {
                listTinBDS = (from tk in dbContext.TaiKhoan
                              join luu in dbContext.LuuTinBatDongSan on tk.ID equals luu.TaiKhoan
                              join t in dbContext.TinBatDongSan on luu.TinBatDongSan equals t.ID
                              join lt in dbContext.LoaiTinBatDongSan on t.LoaiTin equals lt.ID
                              join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                              join lbds in dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                              join tt in dbContext.TinhThanh on t.TinhThanh equals tt.ID
                              join qh in dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                              join h in dbContext.Huong on t.Huong equals h.ID
                              where luu.TaiKhoan == nguoiDang
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
                              }).ToList();
            }
            foreach (TinBDSViewModel tin in listTinBDS)
            {
                tin.Gia = GiaTien(tin.Gia);
                tin.HinhAnh = LayHinhAnh(tin.ID, "Tin bất động sản");
            }
            return listTinBDS;
        }

        public ChiTietBDSListViewModel ChiTietBDS(int id)
        {
            var tinBDS = (from t in dbContext.TinBatDongSan
                              join lt in dbContext.LoaiTinBatDongSan on t.LoaiTin equals lt.ID
                              join tk in dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                              join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                              join lbds in dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                              join tt in dbContext.TinhThanh on t.TinhThanh equals tt.ID
                              join qh in dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                              join h in dbContext.Huong on t.Huong equals h.ID
                              where t.ID == id
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
                              }).FirstOrDefault();
            tinBDS.Gia = GiaTien(tinBDS.Gia);
            var listHinhAnh = LayListHinhAnh(id, "Tin bất động sản");
            ChiTietBDSListViewModel chiTietBDSListViewModel = new ChiTietBDSListViewModel();
            chiTietBDSListViewModel.tinBDSViewModel = tinBDS;
            chiTietBDSListViewModel.hinhAnhs = listHinhAnh;
            return chiTietBDSListViewModel;
        }

        public string GiaTien(string gia)
        {
            if (int.Parse(gia) < 999999999)
            {
                return (int.Parse(gia) / 1000000).ToString() + " triệu";
            }
            else
            {
                return (int.Parse(gia) / 1000000000).ToString() + " tỷ";
            }
        }

        public string LayHinhAnh(int id, string loaiTin)
        {
            var hinhAnh = new HinhAnh();
            if (loaiTin == "Tin bất động sản")
            {
                hinhAnh = (from ha in dbContext.HinhAnh
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
            else if (loaiTin == "Tin tức")
            {
                hinhAnh = (from ha in dbContext.HinhAnh
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

        public List<string> LayListHinhAnh(int id, string loaiTin)
        {
            var hinhAnh = new List<HinhAnh>();
            if (loaiTin == "Tin bất động sản")
            {
                hinhAnh = (from ha in dbContext.HinhAnh
                           where ha.TinBatDongSan == id
                           && ha.AnhChinh == true
                           select new HinhAnh
                           {
                               ID = ha.ID,
                               Ten = ha.Ten,
                               Anh = ha.Anh,
                               AnhChinh = ha.AnhChinh
                           }).ToList();
            }
            else if (loaiTin == "Tin tức")
            {
                hinhAnh = (from ha in dbContext.HinhAnh
                           where ha.TinTuc == id
                           && ha.AnhChinh == true
                           select new HinhAnh
                           {
                               ID = ha.ID,
                               Ten = ha.Ten,
                               Anh = ha.Anh,
                               AnhChinh = ha.AnhChinh
                           }).ToList();
            }
            List<string> anhDataURL = new List<string>();
            if (hinhAnh.Count != 0)
            {
                foreach(HinhAnh anh in hinhAnh)
                {
                    string anhBase64Data = Convert.ToBase64String(anh.Anh);
                    anhDataURL.Add(string.Format("data:image/jpg;base64,{0}", anhBase64Data));
                }
            }
            else
            {
                foreach (HinhAnh anh in hinhAnh)
                {
                    anhDataURL.Add(string.Format("~/Client/img/rooms/1.jpg"));
                }
            }
            return anhDataURL;
        }

        public List<NhaMoiGioiViewModel> LayNhaMoiGioi(int soLuong)
        {
            var listNhaMoiGioi = (from t in dbContext.TaiKhoan
                                  join ltk in dbContext.LoaiTaiKhoan on t.LoaiTaiKhoan equals ltk.ID
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

        public List<TinTucViewModel> LayTinTuc(int soLuong)
        {
            var listTinTuc = (from t in dbContext.TinTuc
                              join lt in dbContext.LoaiTinTuc on t.LoaiTinTuc equals lt.ID
                              join tk in dbContext.TaiKhoan on t.NguoiDang equals tk.ID
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
    }
}
