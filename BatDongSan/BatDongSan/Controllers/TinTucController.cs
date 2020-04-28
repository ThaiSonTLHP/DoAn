using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BatDongSan.Models;
using BatDongSan.Models.ViewModels;
using BatDongSanService;

namespace BatDongSan.Controllers
{
    public class TinTucController : Controller
    {
        private readonly BatDongSanContext _dbContext;

        public TinTucController(BatDongSanContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var _tinTucList = (from t in _dbContext.TinTuc
                               join lt in _dbContext.LoaiTinTuc on t.LoaiTinTuc equals lt.ID
                               join nd in _dbContext.NguoiDung on t.NguoiDang equals nd.ID
                               select new TinTucViewModel()
                               {
                                   ID = t.ID,
                                   TieuDe = t.TieuDe,
                                   NgayDang = t.NgayDang,
                                   LoaiTinTuc = lt.Ten,
                                   NguoiDang = nd.Ten,
                                   NoiDung = t.NoiDung
                               }).ToList();
            //ViewData["ListTinTuc"] = _tinTucList;
            return View(_tinTucList);
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tinTuc = (from t in _dbContext.TinTuc
                          join lt in _dbContext.LoaiTinTuc on t.LoaiTinTuc equals lt.ID
                          join nd in _dbContext.NguoiDung on t.NguoiDang equals nd.ID
                          where t.ID == id
                          select new TinTucViewModel()
                          {
                              ID = t.ID,
                              TieuDe = t.TieuDe,
                              NgayDang = t.NgayDang,
                              LoaiTinTuc = lt.Ten,
                              NguoiDang = nd.Ten,
                              NoiDung = t.NoiDung
                          }).ToList();
            return View(tinTuc);
        }
    }
}