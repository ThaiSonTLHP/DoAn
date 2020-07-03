using BatDongSanId.Areas.Client.Models.ListViewModels;
using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Data;
using BatDongSanId.Models;
using BatDongSanId.ViewModels;
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

        // cập nhật lại trạng thái gói tin hết hạn và tin chưa lên bảng tin
        public void CapNhatTinVip()
        {
            //var listThuong = (from t in dbContext.TinBatDongSan select new TinBatDongSan(){ID = t.ID}).ToList();
            //DateTime time = new DateTime(9999, 01, 01, 0, 0, 0);
            //foreach (var tin in listThuong)
            //{
            //    var _tin = dbContext.TinBatDongSan.Find(tin.ID);
            //    _tin.NgayLenBangTin = /*_tin.NgayDang.AddYears(-10);*/ time;
            //    dbContext.Update(_tin);
            //    dbContext.SaveChanges();
            //}

            var tinThuong = dbContext.GoiTin.FirstOrDefault(g => g.Ten == "Tin thường");

            //cập nhật tin hết hạn
            var list = (from t in dbContext.TinBatDongSan
                        join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                        where
                        gt.Ten == "Tin VIP"
                        && t.TrangThaiDuyet == true
                        select new TinBatDongSan()
                        {
                            ID = t.ID,
                            GoiTin = gt.ID,
                            NgayLenBangTin = t.NgayLenBangTin
                        }).ToList();
            foreach (var tin in list)
            {
                if(DateTime.Compare(tin.NgayLenBangTin.AddDays(int.Parse(configuration["AppSetting:TinVIPTime"])), DateTime.Now) < 0)
                {
                    var _tin = dbContext.TinBatDongSan.Find(tin.ID);
                    _tin.GoiTin = tinThuong.ID;
                    _tin.HetHan = 1;
                    dbContext.Update(_tin);
                    dbContext.SaveChanges();
                }
            }

            //cập nhật tin chưa được lên
            var listUpdate = (from t in dbContext.TinBatDongSan
                              join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                              where gt.Ten == "Tin VIP"
                              && t.TrangThaiDuyet == true
                              select new TinBatDongSan()
                              {
                                  ID = t.ID,
                                  NgayLenBangTin = t.NgayLenBangTin,
                                  NgayDang = t.NgayDang
                              }).OrderBy(t=>t.NgayDang).ToList();
            listUpdate = listUpdate.GetRange(0, listUpdate.Count() < int.Parse(configuration["AppSetting:TinVIPCount"]) ? listUpdate.Count : int.Parse(configuration["AppSetting:TinVIPCount"]));
            foreach (var tin in listUpdate)
            {
                if (DateTime.Compare(tin.NgayLenBangTin, DateTime.Now) > 0)
                {
                    var _tin = dbContext.TinBatDongSan.Find(tin.ID);
                    _tin.NgayLenBangTin = DateTime.Now;
                    dbContext.Update(_tin);
                    dbContext.SaveChanges();
                }
            }
        }

        public void CapNhatTinHot()
        {
            var tinThuong = dbContext.GoiTin.FirstOrDefault(g => g.Ten == "Tin thường");
            //cập nhật tin hết hạn
            var list = (from t in dbContext.TinBatDongSan
                        join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                        where
                        gt.Ten == "Tin HOT"
                        && t.TrangThaiDuyet == true
                        select new TinBatDongSan()
                        {
                            ID = t.ID,
                            GoiTin = gt.ID,
                            NgayLenBangTin = t.NgayLenBangTin
                        }).ToList();
            foreach (var tin in list)
            {
                if (DateTime.Compare(tin.NgayLenBangTin.AddDays(int.Parse(configuration["AppSetting:TinHOTTime"])), DateTime.Now) < 0)
                {
                    var _tin = dbContext.TinBatDongSan.Find(tin.ID);
                    _tin.GoiTin = tinThuong.ID;
                    _tin.HetHan = 2;
                    dbContext.Update(_tin);
                    dbContext.SaveChanges();
                }
            }

            //cập nhật tin chưa được lên
            var listUpdate = (from t in dbContext.TinBatDongSan
                              join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                              where gt.Ten == "Tin VIP"
                              && t.TrangThaiDuyet == true
                              select new TinBatDongSan()
                              {
                                  ID = t.ID,
                                  NgayLenBangTin = t.NgayLenBangTin,
                                  NgayDang = t.NgayDang
                              }).OrderBy(t => t.NgayDang).ToList();
            listUpdate = listUpdate.GetRange(0, listUpdate.Count() < int.Parse(configuration["AppSetting:TinHOTCount"]) ? listUpdate.Count : int.Parse(configuration["AppSetting:TinHOTCount"]));
            foreach (var tin in listUpdate)
            {
                if (DateTime.Compare(tin.NgayLenBangTin, DateTime.Now) > 0)
                {
                    var _tin = dbContext.TinBatDongSan.Find(tin.ID);
                    _tin.NgayLenBangTin = DateTime.Now;
                    dbContext.Update(_tin);
                    dbContext.SaveChanges();
                }
            }
        }

        public TinBDSViewModel LayTinBDS(int id)
        {
            var tin = (from t in dbContext.TinBatDongSan
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
                            NgayDang = t.NgayDang.Date,
                            LoaiTin = lt.Ten,
                            NguoiDang = tk.Ten,
                            LoaiBatDongSan = lbds.Ten,
                            TinhThanh = tt.Ten,
                            QuanHuyen = qh.Ten,
                            Huong = h.Ten,
                            DienTich = t.DienTich,
                            Gia = t.Gia,
                            XacThuc = t.TrangThaiXacNhan == true ? "Xác thực" : "Chưa xác thực",
                            TieuDe = t.MoTa.Substring(0, 60) + "...",
                            MoTa = t.MoTa
                        }).FirstOrDefault();
            tin.Gia = GiaTien(tin.Gia);
            tin.HinhAnh = LayHinhAnh(tin.ID, "Tin bất động sản");
            return tin;
        }

        public List<TinBDSViewModel> LayTinBDS()
        {
            var listTinBDS = (from t in dbContext.TinBatDongSan
                              join lt in dbContext.LoaiTinBatDongSan on t.LoaiTin equals lt.ID
                              join tk in dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                              join gt in dbContext.GoiTin on t.GoiTin equals gt.ID
                              join lbds in dbContext.LoaiBatDongSan on t.LoaiBatDongSan equals lbds.ID
                              join tt in dbContext.TinhThanh on t.TinhThanh equals tt.ID
                              join qh in dbContext.QuanHuyen on t.QuanHuyen equals qh.ID
                              join h in dbContext.Huong on t.Huong equals h.ID
                              select new TinBDSViewModel()
                              {
                                  ID = t.ID,
                                  LienHe = tk.SoDienThoai,
                                  NgayDang = t.NgayDang,
                                  LoaiTin = lt.Ten,
                                  GoiTin = gt.Ten,
                                  PheDuyet = t.TrangThaiDuyet,
                                  NguoiDang = tk.Ten,
                                  LoaiBatDongSan = lbds.Ten,
                                  TinhThanh = tt.Ten,
                                  QuanHuyen = qh.Ten,
                                  Huong = h.Ten,
                                  DienTich = t.DienTich,
                                  Gia = t.Gia,
                                  XacThuc = t.TrangThaiXacNhan == true ? "Xác thực" : "Chưa xác thực",
                                  XacThucBool = t.TrangThaiXacNhan,
                                  TieuDe = t.MoTa.Substring(0, 60) + "...",
                                  DaBan = t.TrangThaiGiaoDich,
                                  MoTa = t.MoTa
                              }).OrderBy(x => x.ID).ToList();
            return listTinBDS;
        }

        public List<TinBDSViewModel> LayTinBDS(int soLuong, string goiTin, string loaiTinBDS)
        {
            List<TinBDSViewModel> listTinBDS = new List<TinBDSViewModel>();
            var tinThuong = dbContext.GoiTin.FirstOrDefault(g => g.Ten == "Tin thường");

            //lay theo goi tin
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
                            && t.TrangThaiGiaoDich == false
                            && t.TrangThaiDuyet == true
                              select new TinBDSViewModel()
                            {
                                ID = t.ID,
                                LienHe = tk.SoDienThoai,
                                NgayDang = t.NgayDang.Date,
                                LoaiTin = lt.Ten,
                                NguoiDang = tk.Ten,
                                LoaiBatDongSan = lbds.Ten,
                                TinhThanh = tt.Ten,
                                QuanHuyen = qh.Ten,
                                Huong = h.Ten,
                                DienTich = t.DienTich,
                                Gia = t.Gia,
                                XacThuc = t.TrangThaiXacNhan == true ? "Xác thực" : "Chưa xác thực",
                                TieuDe = t.MoTa.Substring(0, 60) + "...",
                                MoTa = t.MoTa
                            }).OrderBy(t=>t.NgayDang).ToList();
                if (goiTin == "Tin thường")
                {
                    listTinBDS.Reverse();
                }
            }

            //lay theo loai tin
            else if (goiTin == "All" && loaiTinBDS != "All")
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
                              && t.TrangThaiGiaoDich == false
                              && t.TrangThaiDuyet == true
                              select new TinBDSViewModel()
                              {
                                  ID = t.ID,
                                  LienHe = tk.SoDienThoai,
                                  NgayDang = t.NgayDang.Date,
                                  LoaiTin = lt.Ten,
                                  NguoiDang = tk.Ten,
                                  LoaiBatDongSan = lbds.Ten,
                                  TinhThanh = tt.Ten,
                                  QuanHuyen = qh.Ten,
                                  Huong = h.Ten,
                                  DienTich = t.DienTich,
                                  Gia = t.Gia,
                                  XacThuc = t.TrangThaiXacNhan == true ? "Xác thực" : "Chưa xác thực",
                                  TieuDe = t.MoTa.Substring(0, 60) + "...",
                                  MoTa = t.MoTa
                              }).OrderBy(t => t.NgayDang).ToList();
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
                                  TieuDe = t.MoTa.Substring(0, 60) + "...",
                                  DaBan = t.TrangThaiGiaoDich,
                                  MoTa = t.MoTa,
                                  HetHan = t.HetHan,
                                  GoiTin = gt.Ten
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
                                  TieuDe = t.MoTa.Substring(0, 60) + "...",
                                  DaBan = t.TrangThaiGiaoDich,
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
                                  MoTa = t.MoTa,
                                  NguoiDangID = t.NguoiDang
                              }).FirstOrDefault();
            tinBDS.Gia = GiaTien(tinBDS.Gia);
            var listHinhAnh = LayListHinhAnh(id, "Tin bất động sản");
            ChiTietBDSListViewModel chiTietBDSListViewModel = new ChiTietBDSListViewModel();
            chiTietBDSListViewModel.tinBDSViewModel = tinBDS;
            chiTietBDSListViewModel.hinhAnhs = listHinhAnh;
            chiTietBDSListViewModel.taiKhoanViewModel = ChiTietTaiKhoan(chiTietBDSListViewModel.tinBDSViewModel.NguoiDangID);
            return chiTietBDSListViewModel;
        }

        public string GiaTien(string gia)
        {
            if (Int64.Parse(gia) < 999999999)
            {
                return (Int64.Parse(gia) / 1000000).ToString() + " triệu";
            }
            else
            {
                return (Int64.Parse(gia) / 1000000000).ToString() + " tỷ";
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
                           //&& ha.AnhChinh == true
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
                           //&& ha.AnhChinh == true
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

        string LayUrlHinhAnh(byte[] hinhAnh)
        {
            string anhDataURL;
            if (hinhAnh != null)
            {
                string anhBase64Data = Convert.ToBase64String(hinhAnh);
                anhDataURL = string.Format("data:image/jpg;base64,{0}", anhBase64Data);
            }
            else
            {
                anhDataURL = "~/Client/img/rooms/1.jpg";
            }
            return anhDataURL;
        }

        public List<TaiKhoanViewModel> LayTaiKhoan(int soLuong, string loaiTaiKhoan)
        {
            var listTaiKhoan = new List<TaiKhoanViewModel>();
            if (soLuong == 0)
            {
                if(loaiTaiKhoan == "All")
                {
                    listTaiKhoan = (from t in dbContext.TaiKhoan
                                    join ltk in dbContext.LoaiTaiKhoan on t.LoaiTaiKhoan equals ltk.ID
                                    select new TaiKhoanViewModel()
                                    {
                                        ID = t.ID,
                                        MatKhau = t.MatKhau,
                                        Ten = t.Ten,
                                        GioiTinh = (t.GioiTinh == true) ? "Nam" : "Nữ",
                                        Email = t.Email,
                                        SoDienThoai = t.SoDienThoai,
                                        DiaChi = t.DiaChi,
                                        SoDuVi = t.SoDuVi,
                                        LoaiTaiKhoan = ltk.Ten,
                                        XacNhan = t.XacThuc
                                    }).ToList();
                }
                else
                {
                    listTaiKhoan = (from t in dbContext.TaiKhoan
                                    join ltk in dbContext.LoaiTaiKhoan on t.LoaiTaiKhoan equals ltk.ID
                                    where ltk.Ten == loaiTaiKhoan
                                    select new TaiKhoanViewModel()
                                    {
                                        ID = t.ID,
                                        MatKhau = t.MatKhau,
                                        Ten = t.Ten,
                                        GioiTinh = (t.GioiTinh == true) ? "Nam" : "Nữ",
                                        Email = t.Email,
                                        SoDienThoai = t.SoDienThoai,
                                        DiaChi = t.DiaChi,
                                        SoDuVi = t.SoDuVi,
                                        LoaiTaiKhoan = ltk.Ten,
                                        XacNhan = t.XacThuc
                                    }).ToList();
                }
            }
            else
            {
                listTaiKhoan = (from t in dbContext.TaiKhoan
                                join ltk in dbContext.LoaiTaiKhoan on t.LoaiTaiKhoan equals ltk.ID
                                where ltk.Ten == loaiTaiKhoan
                                select new TaiKhoanViewModel()
                                {
                                    ID = t.ID,
                                    MatKhau = t.MatKhau,
                                    Ten = t.Ten,
                                    GioiTinh = (t.GioiTinh == true) ? "Nam" : "Nữ",
                                    Email = t.Email,
                                    SoDienThoai = t.SoDienThoai,
                                    DiaChi = t.DiaChi,
                                    SoDuVi = t.SoDuVi,
                                    LoaiTaiKhoan = ltk.Ten,
                                    XacNhan = t.XacThuc
                                }).ToList().GetRange(0, soLuong);
            }
            return listTaiKhoan;
        }

        public TaiKhoanViewModel ChiTietTaiKhoan(int id)
        {
            var taiKhoan = (from t in dbContext.TaiKhoan
                            join ltk in dbContext.LoaiTaiKhoan on t.LoaiTaiKhoan equals ltk.ID
                            where t.ID == id
                            select new TaiKhoanViewModel()
                            {
                                ID = t.ID,
                                MatKhau = t.MatKhau,
                                Ten = t.Ten,
                                GioiTinh = (t.GioiTinh == true) ? "Nam" : "Nữ",
                                Email = t.Email,
                                SoDienThoai = t.SoDienThoai,
                                DiaChi = t.DiaChi,
                                SoDuVi = t.SoDuVi,
                                AnhDaiDienData = t.AnhDaiDien,
                                LoaiTaiKhoan = ltk.Ten,
                                XacNhan = t.XacThuc
                            }).FirstOrDefault();
            taiKhoan.AnhDaiDienUrl = LayUrlHinhAnh(taiKhoan.AnhDaiDienData);
            return taiKhoan;
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
                                  NoiDung = t.NoiDung.Substring(0, 200) + "..."
                              }).ToList();
            foreach (TinTucViewModel tin in listTinTuc)
            {
                tin.HinhAnh = LayHinhAnh(tin.ID, "Tin tức");
            }
            if(soLuong != 0)
            {
                listTinTuc = listTinTuc.GetRange(0, soLuong > listTinTuc.Count() ? listTinTuc.Count() : soLuong);
            }
            return listTinTuc;
        }
    }
}
