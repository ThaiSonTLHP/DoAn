using BatDongSanId.Data;
using BatDongSanId.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BatDongSanId.Methods
{
    public class CheckUser
    {
        private readonly ApplicationDbContext dbContext;

        public CheckUser(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool CheckAdmin(int? id)
        {
            if (id == null) return false;
            var user = (from t in dbContext.TaiKhoan
                        where t.ID == id
                        select new TaiKhoan()
                        {
                            ID = t.ID,
                            LoaiTaiKhoan = t.LoaiTaiKhoan
                        }).FirstOrDefault();
            if (user.LoaiTaiKhoan == 1 || user.LoaiTaiKhoan == 2) return true;
            else return false;
        }

        public bool CheckSuperAdmin(int? id)
        {
            if (id == null) return false;
            var user = (from t in dbContext.TaiKhoan
                        where t.ID == id
                        select new TaiKhoan()
                        {
                            ID = t.ID,
                            LoaiTaiKhoan = t.LoaiTaiKhoan
                        }).FirstOrDefault();
            if (user.LoaiTaiKhoan == 1) return true;
            else return false;
        }

        public bool CheckClient(int? id)
        {
            if (id == null) return false;
            var user = (from t in dbContext.TaiKhoan
                        where t.ID == id
                        select new TaiKhoan()
                        {
                            ID = t.ID,
                            LoaiTaiKhoan = t.LoaiTaiKhoan
                        }).FirstOrDefault();
            if (user.LoaiTaiKhoan == 3 || user.LoaiTaiKhoan == 4) return true;
            else return false;
        }
    }
}
