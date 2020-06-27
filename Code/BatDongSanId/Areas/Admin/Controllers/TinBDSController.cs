using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BatDongSanId.Areas.Client.Models.ViewModels;
using BatDongSanId.Data;
using BatDongSanId.Methods;
using BatDongSanId.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BatDongSanId.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TinBDSController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IConfiguration configuration;

        public TinBDSController(ApplicationDbContext dbContext, IConfiguration configuration)
        {
            this.dbContext = dbContext;
            this.configuration = configuration;
        }

        public IActionResult Tin()
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTin = layDuLieu.LayTinBDS();
            return View(listTin);
        }

        public IActionResult ChiTiet(int id)
        {
            return View();
        }

        public IActionResult ChoPheDuyet()
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTin = layDuLieu.LayTinBDS();
            var listChuaDuyet = new List<TinBDSViewModel>();
            foreach(var tin in listTin)
            {
                if(tin.PheDuyet == false)
                {
                    listChuaDuyet.Add(tin);
                }
            }
            return View(listChuaDuyet);
        }

        public IActionResult ChoXacThuc()
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTin = layDuLieu.LayTinBDS();
            var listChuaXacThuc = new List<TinBDSViewModel>();
            foreach (var tin in listTin)
            {
                if (tin.XacThucBool == false)
                {
                    listChuaXacThuc.Add(tin);
                }
            }
            return View(listChuaXacThuc);
        }

        public IActionResult DaGiaoDich()
        {
            LayDuLieu layDuLieu = new LayDuLieu(dbContext, configuration);
            var listTin = layDuLieu.LayTinBDS();
            var listGiaoDich = new List<TinBDSViewModel>();
            foreach (var tin in listTin)
            {
                if (tin.DaBan == true)
                {
                    listGiaoDich.Add(tin);
                }
            }
            return View(listGiaoDich);
        }


        //------------------------ajax
        public void DuyetTin(int idTin)
        {
            var tin = dbContext.TinBatDongSan.FirstOrDefault(t => t.ID == idTin);
            tin.TrangThaiDuyet = true;
            dbContext.TinBatDongSan.Update(tin);
            dbContext.SaveChanges();
        }

        public void XacThuc(int idTin)
        {
            var tin = dbContext.TinBatDongSan.FirstOrDefault(t => t.ID == idTin);
            tin.TrangThaiXacNhan = true;
            dbContext.TinBatDongSan.Update(tin);
            dbContext.SaveChanges();
        }
    }
}
