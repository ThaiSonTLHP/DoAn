using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Data;
using BatDongSanId.Methods;
using BatDongSanId.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace BatDongSanId.Areas.Client.Controllers
{
    [Area("Client")]
    public class DangTinController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;

        public DangTinController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }

        public IActionResult DangTin()
        {
            if (HttpContext.Session.GetInt32("userID") == null)
            {
                HttpContext.Session.SetString("LoginMessage","Vui lòng đăng nhập trước khi đăng tin!");
                return RedirectToAction("Login", "DangNhap");
            }
            List<LoaiTinBatDongSan> LoaiTinBatDongSan = dbContext.LoaiTinBatDongSan.ToList();
            List<GoiTin> GoiTin = dbContext.GoiTin.ToList();
            List<LoaiBatDongSan> LoaiBatDongSan = dbContext.LoaiBatDongSan.ToList();
            List<TinhThanh> TinhThanh = dbContext.TinhThanh.ToList();
            List<Huong> Huong = dbContext.Huong.ToList();

            ViewBag.LoaiTinBatDongSan = new SelectList(LoaiTinBatDongSan, "ID", "Ten");
            ViewBag.GoiTin = new SelectList(GoiTin, "ID", "Ten");
            ViewBag.LoaiBatDongSan = new SelectList(LoaiBatDongSan, "ID", "Ten");
            ViewBag.TinhThanh = new SelectList(TinhThanh, "ID", "Ten");
            ViewBag.Huong = new SelectList(Huong, "ID", "Ten");

            return View();
        }

        public JsonResult GetQuanHuyenList(string _tinhThanh)
        {
            List<QuanHuyen> QuanHuyenList = dbContext.QuanHuyen.Where(x => x.TinhThanh == _tinhThanh).ToList();

            return Json(QuanHuyenList);
        }

        [HttpPost]
        public IActionResult DangTin(TinBDSViewModel tinBDSViewModel)
        {
            var _time = DateTime.Now;
            var _nguoiDang = dbContext.TaiKhoan.FirstOrDefault(x => x.ID == HttpContext.Session.GetInt32("userID"));
            var count = (from t in dbContext.TinBatDongSan
                        join tk in dbContext.TaiKhoan on t.NguoiDang equals tk.ID
                        where t.NgayDang.Date == _time.Date
                        select new TinBatDongSan()
                        {
                            ID = t.ID
                        }).ToList().Count();
            if (count < int.Parse(configuration["AppSetting:TinPerDay"]))
            {
                var tinBatDongSan = new TinBatDongSan();
                //HttpContext.Session.SetInt32("userID", 4);
                var _goiTin = dbContext.GoiTin.FirstOrDefault(x => x.ID == int.Parse(tinBDSViewModel.GoiTin));
                var _mucGia = dbContext.MucGia.FirstOrDefault(x => (x.Min <= double.Parse(tinBDSViewModel.Gia) && x.Max >= double.Parse(tinBDSViewModel.Gia)));
                var _mucDienTich = dbContext.MucDienTich.FirstOrDefault(x => (x.Min <= double.Parse(tinBDSViewModel.DienTich) && x.Max >= double.Parse(tinBDSViewModel.DienTich)));

                //HttpContext.Session.Remove("userID");

                tinBatDongSan.LoaiTin = int.Parse(tinBDSViewModel.LoaiTin);
                tinBatDongSan.NguoiDang = _nguoiDang.ID;
                
                tinBatDongSan.NgayDang = _time;
                tinBatDongSan.TrangThaiGiaoDich = false;
                tinBatDongSan.TrangThaiXacNhan = false;
                if(_goiTin.Ten == "Tin VIP" || _goiTin.Ten == "Tin HOT")
                {
                    LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
                    if (_goiTin.Ten == "Tin VIP")
                    {
                        if(layDuLieu.LayTinBDS(int.Parse(configuration["AppSetting:TinVIPCount"]), "Tin VIP", "All").Count()<
                            int.Parse(configuration["AppSetting:TinVIPCount"]))
                        {
                            tinBatDongSan.NgayLenBangTin = _time;
                        }
                        else
                        {
                            tinBatDongSan.NgayLenBangTin = new DateTime(9999, 01, 01, 0, 0, 0);
                        }
                    }
                    else if(_goiTin.Ten == "Tin HOT")
                    {
                        if (layDuLieu.LayTinBDS(int.Parse(configuration["AppSetting:TinHOTCount"]), "Tin HOT", "All").Count() <
                            int.Parse(configuration["AppSetting:TinHOTCount"]))
                        {
                            tinBatDongSan.NgayLenBangTin = _time;
                        }
                        else
                        {
                            tinBatDongSan.NgayLenBangTin = new DateTime(9999, 01, 01, 0, 0, 0);
                        }
                    }



                    if (_nguoiDang.SoDuVi >= _goiTin.MucPhi)
                    {
                        _nguoiDang.SoDuVi -= _goiTin.MucPhi;
                        dbContext.TaiKhoan.Update(_nguoiDang);
                        tinBatDongSan.TrangThaiDuyet = true;
                    }
                    else
                    {
                        tinBatDongSan.TrangThaiDuyet = false;
                    }
                }
                else
                {
                    tinBatDongSan.NgayLenBangTin = _time;
                    tinBatDongSan.TrangThaiDuyet = true;
                }

                tinBatDongSan.GoiTin = _goiTin.ID;
                tinBatDongSan.LoaiBatDongSan = int.Parse(tinBDSViewModel.LoaiBatDongSan);
                tinBatDongSan.TinhThanh = tinBDSViewModel.TinhThanh;
                tinBatDongSan.QuanHuyen = tinBDSViewModel.QuanHuyen;
                tinBatDongSan.Gia = tinBDSViewModel.Gia;
                tinBatDongSan.MucGia = _mucGia.ID;
                tinBatDongSan.DienTich = tinBDSViewModel.DienTich;
                tinBatDongSan.MucDienTich = _mucDienTich.ID;
                tinBatDongSan.Huong = int.Parse(tinBDSViewModel.Huong);
                tinBatDongSan.TieuDe = tinBDSViewModel.TieuDe;
                tinBatDongSan.MoTa = tinBDSViewModel.MoTa;

                dbContext.TinBatDongSan.Add(tinBatDongSan);
                dbContext.SaveChanges();

                var _tinVuaThem = dbContext.TinBatDongSan.FirstOrDefault(t => t.NgayDang == _time);

                int i = 0;
                foreach (var file in Request.Form.Files)
                {
                    HinhAnh img = new HinhAnh();
                    img.Ten = file.FileName;

                    MemoryStream ms = new MemoryStream();
                    file.CopyTo(ms);
                    img.Anh = ms.ToArray();

                    ms.Close();
                    ms.Dispose();

                    img.AnhChinh = i == 0 ? true : false; i++;

                    img.TinBatDongSan = _tinVuaThem.ID;

                    dbContext.HinhAnh.Add(img);
                    dbContext.SaveChanges();
                }


                if (tinBatDongSan.TrangThaiDuyet == true)
                {
                    ViewBag.Message = "Đăng tin thành công!";
                }
                else
                {
                    ViewBag.Message = "Chờ phê duyệt! Vui lòng thanh toán và sử dụng mã số " + tinBatDongSan.ID.ToString() + " để duyệt tin! (Liên hệ số điện thoại abc)";
                }
                return RedirectToAction("DangTin");
            }
            else
            {
                ViewBag.Message = "Bạn đã đăng quá số tin cho phép trong ngày!";
                return RedirectToAction("DangTin");
            }
        }

        [HttpPost]
        public ActionResult RetrieveImage()
        {
            HinhAnh img = dbContext.HinhAnh.FirstOrDefault(i => i.ID == 5);
            string imageBase64Data = Convert.ToBase64String(img.Anh);
            string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
            ViewBag.ImageTitle = img.Ten;
            ViewBag.ImageDataUrl = imageDataURL;
            return View("Details");
        }
    }
}