using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BatDongSan.Models.ViewModels;
using BatDongSanService;
using BatDongSanService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Design;

namespace BatDongSan.Areas.Client.Controllers
{
    [Area("Client")]
    public class DangTinController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public DangTinController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult DangTin()
        {
            List<LoaiTinBatDongSan> LoaiTinBatDongSan = _dbContext.LoaiTinBatDongSan.ToList();
            List<GoiTin> GoiTin = _dbContext.GoiTin.ToList();
            List<LoaiBatDongSan> LoaiBatDongSan = _dbContext.LoaiBatDongSan.ToList();
            List<TinhThanh> TinhThanh = _dbContext.TinhThanh.ToList();
            List<Huong> Huong = _dbContext.Huong.ToList();

            ViewBag.LoaiTinBatDongSan = new SelectList(LoaiTinBatDongSan, "ID", "Ten");
            ViewBag.GoiTin = new SelectList(GoiTin, "ID", "Ten");
            ViewBag.LoaiBatDongSan = new SelectList(LoaiBatDongSan, "ID", "Ten");
            ViewBag.TinhThanh = new SelectList(TinhThanh, "ID", "Ten");
            ViewBag.Huong = new SelectList(Huong, "ID", "Ten");

            return View();
        }
        public JsonResult GetQuanHuyenList(string _tinhThanh)
        {
            List<QuanHuyen> QuanHuyenList = _dbContext.QuanHuyen.Where(x => x.TinhThanh == _tinhThanh).ToList();

            return Json(QuanHuyenList);
        }

        [HttpPost]
        public IActionResult DangTin(TinBDSViewModel tinBDSViewModel)
        {
            if (HttpContext.Session.GetInt32("userID") == null)
            {
                return RedirectToAction("Login", "DangNhap");
            }

            if (ModelState.IsValid)
            {
                var tinBatDongSan = new TinBatDongSan();

                HttpContext.Session.SetInt32("userID", 4);
                var _goiTin = _dbContext.GoiTin.FirstOrDefault(x => x.ID == int.Parse(tinBDSViewModel.GoiTin));
                var _nguoiDang = _dbContext.TaiKhoan.FirstOrDefault(x => x.ID == HttpContext.Session.GetInt32("userID"));
                var _mucGia = _dbContext.MucGia.FirstOrDefault(x => (x.Min <= double.Parse(tinBDSViewModel.Gia) && x.Max >= double.Parse(tinBDSViewModel.Gia)));
                var _mucDienTich = _dbContext.MucDienTich.FirstOrDefault(x => (x.Min <= double.Parse(tinBDSViewModel.DienTich) && x.Max >= double.Parse(tinBDSViewModel.DienTich)));

                HttpContext.Session.Remove("userID");

                tinBatDongSan.LoaiTin = int.Parse(tinBDSViewModel.LoaiTin);
                tinBatDongSan.NguoiDang = _nguoiDang.ID;

                var _time = DateTime.Now;
                tinBatDongSan.NgayDang = _time;
                tinBatDongSan.TrangThaiGiaoDich = false;
                tinBatDongSan.TrangThaiXacNhan = false;

                if(_nguoiDang.SoDuVi >= _goiTin.MucPhi)
                {
                    _nguoiDang.SoDuVi -= _goiTin.MucPhi;
                    _dbContext.TaiKhoan.Update(_nguoiDang);
                    tinBatDongSan.TrangThaiDuyet = true;
                }
                else
                {
                    tinBatDongSan.TrangThaiDuyet = false;
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
                tinBatDongSan.MoTa = tinBDSViewModel.MoTa;

                _dbContext.TinBatDongSan.Add(tinBatDongSan);
                _dbContext.SaveChanges();

                var _tinVuaThem = _dbContext.TinBatDongSan.FirstOrDefault(t => t.NgayDang == _time);

                foreach (var file in Request.Form.Files)
                {
                    HinhAnh img = new HinhAnh();
                    img.Ten = file.FileName;

                    MemoryStream ms = new MemoryStream();
                    file.CopyTo(ms);
                    img.Anh = ms.ToArray();

                    ms.Close();
                    ms.Dispose();

                    img.AnhChinh = true;
                    img.TinBatDongSan = _tinVuaThem.ID;

                    _dbContext.HinhAnh.Add(img);
                    _dbContext.SaveChanges();
                }


                if (tinBatDongSan.TrangThaiDuyet == true)
                    return RedirectToAction("DangTinThanhCong");
                else
                    return RedirectToAction("ChoPheDuyet");
            }
            else
                return View();
        }

        [HttpPost]
        public ActionResult RetrieveImage()
        {
            HinhAnh img = _dbContext.HinhAnh.FirstOrDefault(i => i.ID == 5);
            string imageBase64Data = Convert.ToBase64String(img.Anh);
            string imageDataURL = string.Format("data:image/jpg;base64,{0}", imageBase64Data);
            ViewBag.ImageTitle = img.Ten;
            ViewBag.ImageDataUrl = imageDataURL;
            return View("Details");
        }

        public IActionResult DangNhap()
        {
            return View();
        }

        public IActionResult DangTinThanhCong()
        {
            return View();
        }

        public IActionResult ChoPheDuyet()
        {
            return View();
        }
    }
}