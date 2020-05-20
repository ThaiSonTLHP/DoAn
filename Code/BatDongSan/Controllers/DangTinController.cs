using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSan.Models.ViewModels;
using BatDongSanService;
using BatDongSanService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Design;

namespace BatDongSan.Controllers
{
    public class DangTinController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public DangTinController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            List<LoaiTinBatDongSan> LoaiTinBatDongSan = _dbContext.LoaiTinBatDongSan.ToList();
            List<GoiTin> GoiTin = _dbContext.GoiTin.ToList();
            List<LoaiBatDongSan> LoaiBatDongSan = _dbContext.LoaiBatDongSan.ToList();
            List<TinhThanh> TinhThanh = _dbContext.TinhThanh.ToList();
            //List<QuanHuyen> QuanHuyen = _dbContext.QuanHuyen.ToList();
            List<Huong> Huong = _dbContext.Huong.ToList();

            ViewBag.LoaiTinBatDongSan = new SelectList(LoaiTinBatDongSan, "ID", "Ten");
            ViewBag.GoiTin = new SelectList(GoiTin, "ID", "Ten");
            ViewBag.LoaiBatDongSan = new SelectList(LoaiBatDongSan, "ID", "Ten");
            ViewBag.TinhThanh = new SelectList(TinhThanh, "ID", "Ten");
            //ViewBag.QuanHuyen = new SelectList(QuanHuyen, "ID", "Ten");
            ViewBag.Huong = new SelectList(Huong, "ID", "Ten");

            return View();
        }

        public JsonResult GetQuanHuyenList(string _tinhThanh)
        {
            List<QuanHuyen> QuanHuyenList = _dbContext.QuanHuyen.Where(x => x.TinhThanh == _tinhThanh).ToList();

            //QuanHuyenList.Insert(0, new QuanHuyen { ID = "0", Ten = "Chọn quận huyện" });

            //return Json(new SelectList(QuanHuyenList, "QuanHuyenID", "TenQuanHuyen"));

            return Json(QuanHuyenList);
        }

        [HttpPost]
        public IActionResult Index(TinBDSViewModel tinBDSViewModel)
        {
            if (ModelState.IsValid)
            {
                var tinBatDongSan = new TinBatDongSan();

                var _goiTin = _dbContext.GoiTin.FirstOrDefault(x => x.ID == int.Parse(tinBDSViewModel.GoiTin));
                var _nguoiDang = _dbContext.TaiKhoan.FirstOrDefault(x => x.Email == tinBDSViewModel.NguoiDang);
                var _mucGia = _dbContext.MucGia.FirstOrDefault(x => (x.Min <= double.Parse(tinBDSViewModel.Gia) && x.Max >= double.Parse(tinBDSViewModel.Gia)));
                var _mucDienTich = _dbContext.MucDienTich.FirstOrDefault(x => (x.Min <= double.Parse(tinBDSViewModel.DienTich) && x.Max >= double.Parse(tinBDSViewModel.DienTich)));

                tinBatDongSan.LoaiTin = int.Parse(tinBDSViewModel.LoaiTin);
                tinBatDongSan.NguoiDang = _nguoiDang.ID;
                tinBatDongSan.NgayDang = DateTime.Now;
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
                //tinBatDongSan.QuanHuyen = tinBDSViewModel.QuanHuyen;
                tinBatDongSan.QuanHuyen = "001";
                tinBatDongSan.Gia = double.Parse(tinBDSViewModel.Gia);
                tinBatDongSan.MucGia = _mucGia.ID;
                tinBatDongSan.DienTich = double.Parse(tinBDSViewModel.DienTich);
                tinBatDongSan.MucDienTich = _mucDienTich.ID;
                tinBatDongSan.Huong = int.Parse(tinBDSViewModel.Huong);
                tinBatDongSan.MoTa = tinBDSViewModel.MoTa;

                _dbContext.TinBatDongSan.Add(tinBatDongSan);
                _dbContext.SaveChanges();

                if(tinBatDongSan.TrangThaiDuyet == true)
                    return RedirectToAction("DangTinThanhCong");
                else
                    return RedirectToAction("ChoPheDuyet");
            }
            return View();
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